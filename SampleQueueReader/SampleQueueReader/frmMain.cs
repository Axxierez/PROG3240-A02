﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Messaging;
using System.Data.SqlClient;

namespace SampleQueueReader
{
    public partial class frmMain : Form
    {
        MessageQueue msmq = new MessageQueue();
        Boolean bRead = false;
        String queueName = "\\private$\\yoyo";
        String connectionString="";
        SqlConnection conn;
        public frmMain()
        {
            InitializeComponent();
            msmq.Formatter = new ActiveXMessageFormatter();
            msmq.MessageReadPropertyFilter.LookupId = true;
            msmq.SynchronizingObject = this;
            msmq.ReceiveCompleted += new ReceiveCompletedEventHandler(msmq_ReceiveCompleted);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstQueueData.Items.Clear();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtQueueServer.Text = System.Windows.Forms.SystemInformation.ComputerName;
            IsRunning(false);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtQueueServer.Text == "")
            {
                MessageBox.Show("Message Queue Server required");
            }
            if (txtDatabaseConnectionString.Text == "")
            {
                MessageBox.Show("Connection String required");
            }
            if(txtDatabaseConnectionString.Text!=""&&txtQueueServer.Text!="")
            {
                msmq.Path = "Formatname:Direct=os:" + txtQueueServer.Text + queueName;
                bRead = true;
                msmq.BeginReceive();
                connectionString = txtDatabaseConnectionString.Text;
                conn= new SqlConnection(connectionString);
                conn.ChangeDatabase("yoyoData");
                conn.Open();

                IsRunning(true);
            }

        }

        void msmq_ReceiveCompleted(object sender, ReceiveCompletedEventArgs e)
        {
            try
            {
                lstQueueData.Items.Insert(0,e.Message.Body.ToString());
                msmq.EndReceive(e.AsyncResult);
                if (chkCount.Checked)
                {
                    txtRemaining.Text = GetMessageCount(msmq).ToString();
                }
                Application.DoEvents();
                if (bRead)
                {
                    msmq.BeginReceive();
                }
                
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;
                string[] values = e.Message.Body.ToString().Split(',');
                cmd.CommandText = "INSERT INTO yoyo VALUES('" +
                    values[0] + "','" +
                    values[1] + "','" +
                    values[2] + "','" +
                    values[3] + "','" +
                    values[4] + "','" +
                    values[5] + "','" +
                    values[6] + "'); ";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();
                reader.Close();

            }
            catch
            {
               MessageBox.Show("Unhandled Exception");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            bRead = false;
            IsRunning(false);
            conn.Close();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            lstQueueData.Items.Clear();
        }

        private int GetMessageCount(MessageQueue m)
        {
            Int32 count = 0;
            MessageEnumerator msgEnum = m.GetMessageEnumerator2();
            while (msgEnum.MoveNext(new TimeSpan(0, 0, 0)))
            {
                count++;
            }
            return count;
        }

        private void IsRunning(Boolean state)
        {
            if (state == true)
            {
                btnStart.Enabled = false;
                btnStop.Enabled = true;
                btnSingleRead.Enabled = false;
            }
            else
            {
                btnStart.Enabled = true;
                btnStop.Enabled = false ;
                btnSingleRead.Enabled = true;
            }
        }

        private void btnSingleRead_Click(object sender, EventArgs e)
        {
            if (txtQueueServer.Text == "")
            {
                MessageBox.Show("Message Queue Server required");
            }
            else
            {
                msmq.Path = "Formatname:Direct=os:" + txtQueueServer.Text + queueName;
                try
                {
                    System.Messaging.Message msg = msmq.Receive(new TimeSpan(0));
                    if (msg != null)
                    {
                        lstQueueData.Items.Insert(0, msg.Body.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot read - probably empty queue or queue non existent");
                }
            }

        }

        private void btnPurgeQ_Click(object sender, EventArgs e)
        {
            msmq.Purge();
        }

    }
}
