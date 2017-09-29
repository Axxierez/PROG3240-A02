namespace LiveReport
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblTotalMolded = new System.Windows.Forms.Label();
            this.lblTotalMoldedCount = new System.Windows.Forms.Label();
            this.txtDatabaseConnectionString = new System.Windows.Forms.TextBox();
            this.lblTotalSuccessMoldCount = new System.Windows.Forms.Label();
            this.lblTotalSuccessMold = new System.Windows.Forms.Label();
            this.lblConnectionString = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblYieldAtAssemblyCount = new System.Windows.Forms.Label();
            this.lblYieldAtAssembly = new System.Windows.Forms.Label();
            this.lblTotalPartsSuccessfullyAsbCount = new System.Windows.Forms.Label();
            this.lblTotalPartsSuccessfullyAsb = new System.Windows.Forms.Label();
            this.lblYieldAtPaintCount = new System.Windows.Forms.Label();
            this.lblYieldAtPaint = new System.Windows.Forms.Label();
            this.lblSuccessfullyPaintedCount = new System.Windows.Forms.Label();
            this.lblSuccessfullyPainted = new System.Windows.Forms.Label();
            this.lblYieldAtMoldCount = new System.Windows.Forms.Label();
            this.lblYieldAtMold = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(12, 12);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 0;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // lblTotalMolded
            // 
            this.lblTotalMolded.AutoSize = true;
            this.lblTotalMolded.Location = new System.Drawing.Point(140, 30);
            this.lblTotalMolded.Name = "lblTotalMolded";
            this.lblTotalMolded.Size = new System.Drawing.Size(69, 13);
            this.lblTotalMolded.TabIndex = 1;
            this.lblTotalMolded.Text = "Total Molded";
            // 
            // lblTotalMoldedCount
            // 
            this.lblTotalMoldedCount.AutoSize = true;
            this.lblTotalMoldedCount.Location = new System.Drawing.Point(225, 30);
            this.lblTotalMoldedCount.Name = "lblTotalMoldedCount";
            this.lblTotalMoldedCount.Size = new System.Drawing.Size(13, 13);
            this.lblTotalMoldedCount.TabIndex = 2;
            this.lblTotalMoldedCount.Text = "0";
            // 
            // txtDatabaseConnectionString
            // 
            this.txtDatabaseConnectionString.Location = new System.Drawing.Point(771, 15);
            this.txtDatabaseConnectionString.Name = "txtDatabaseConnectionString";
            this.txtDatabaseConnectionString.Size = new System.Drawing.Size(163, 20);
            this.txtDatabaseConnectionString.TabIndex = 3;
            // 
            // lblTotalSuccessMoldCount
            // 
            this.lblTotalSuccessMoldCount.AutoSize = true;
            this.lblTotalSuccessMoldCount.Location = new System.Drawing.Point(225, 61);
            this.lblTotalSuccessMoldCount.Name = "lblTotalSuccessMoldCount";
            this.lblTotalSuccessMoldCount.Size = new System.Drawing.Size(13, 13);
            this.lblTotalSuccessMoldCount.TabIndex = 4;
            this.lblTotalSuccessMoldCount.Text = "0";
            // 
            // lblTotalSuccessMold
            // 
            this.lblTotalSuccessMold.AutoSize = true;
            this.lblTotalSuccessMold.Location = new System.Drawing.Point(78, 61);
            this.lblTotalSuccessMold.Name = "lblTotalSuccessMold";
            this.lblTotalSuccessMold.Size = new System.Drawing.Size(131, 13);
            this.lblTotalSuccessMold.TabIndex = 5;
            this.lblTotalSuccessMold.Text = "Total Successfully Molded";
            // 
            // lblConnectionString
            // 
            this.lblConnectionString.AutoSize = true;
            this.lblConnectionString.Location = new System.Drawing.Point(625, 18);
            this.lblConnectionString.Name = "lblConnectionString";
            this.lblConnectionString.Size = new System.Drawing.Size(140, 13);
            this.lblConnectionString.TabIndex = 6;
            this.lblConnectionString.Text = "Database Connection String";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblYieldAtAssemblyCount);
            this.groupBox1.Controls.Add(this.lblYieldAtAssembly);
            this.groupBox1.Controls.Add(this.lblTotalPartsSuccessfullyAsbCount);
            this.groupBox1.Controls.Add(this.lblTotalPartsSuccessfullyAsb);
            this.groupBox1.Controls.Add(this.lblYieldAtPaintCount);
            this.groupBox1.Controls.Add(this.lblYieldAtPaint);
            this.groupBox1.Controls.Add(this.lblSuccessfullyPaintedCount);
            this.groupBox1.Controls.Add(this.lblSuccessfullyPainted);
            this.groupBox1.Controls.Add(this.lblYieldAtMoldCount);
            this.groupBox1.Controls.Add(this.lblYieldAtMold);
            this.groupBox1.Controls.Add(this.lblTotalMoldedCount);
            this.groupBox1.Controls.Add(this.lblTotalSuccessMold);
            this.groupBox1.Controls.Add(this.lblTotalMolded);
            this.groupBox1.Controls.Add(this.lblTotalSuccessMoldCount);
            this.groupBox1.Location = new System.Drawing.Point(669, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 287);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // lblYieldAtAssemblyCount
            // 
            this.lblYieldAtAssemblyCount.AutoSize = true;
            this.lblYieldAtAssemblyCount.Location = new System.Drawing.Point(225, 186);
            this.lblYieldAtAssemblyCount.Name = "lblYieldAtAssemblyCount";
            this.lblYieldAtAssemblyCount.Size = new System.Drawing.Size(13, 13);
            this.lblYieldAtAssemblyCount.TabIndex = 17;
            this.lblYieldAtAssemblyCount.Text = "0";
            // 
            // lblYieldAtAssembly
            // 
            this.lblYieldAtAssembly.AutoSize = true;
            this.lblYieldAtAssembly.Location = new System.Drawing.Point(120, 186);
            this.lblYieldAtAssembly.Name = "lblYieldAtAssembly";
            this.lblYieldAtAssembly.Size = new System.Drawing.Size(90, 13);
            this.lblYieldAtAssembly.TabIndex = 16;
            this.lblYieldAtAssembly.Text = "Yield At Assembly";
            // 
            // lblTotalPartsSuccessfullyAsbCount
            // 
            this.lblTotalPartsSuccessfullyAsbCount.AutoSize = true;
            this.lblTotalPartsSuccessfullyAsbCount.Location = new System.Drawing.Point(225, 162);
            this.lblTotalPartsSuccessfullyAsbCount.Name = "lblTotalPartsSuccessfullyAsbCount";
            this.lblTotalPartsSuccessfullyAsbCount.Size = new System.Drawing.Size(13, 13);
            this.lblTotalPartsSuccessfullyAsbCount.TabIndex = 13;
            this.lblTotalPartsSuccessfullyAsbCount.Text = "0";
            // 
            // lblTotalPartsSuccessfullyAsb
            // 
            this.lblTotalPartsSuccessfullyAsb.AutoSize = true;
            this.lblTotalPartsSuccessfullyAsb.Location = new System.Drawing.Point(35, 162);
            this.lblTotalPartsSuccessfullyAsb.Name = "lblTotalPartsSuccessfullyAsb";
            this.lblTotalPartsSuccessfullyAsb.Size = new System.Drawing.Size(174, 13);
            this.lblTotalPartsSuccessfullyAsb.TabIndex = 12;
            this.lblTotalPartsSuccessfullyAsb.Text = "Total Parts Successfully Assembled";
            // 
            // lblYieldAtPaintCount
            // 
            this.lblYieldAtPaintCount.AutoSize = true;
            this.lblYieldAtPaintCount.Location = new System.Drawing.Point(225, 139);
            this.lblYieldAtPaintCount.Name = "lblYieldAtPaintCount";
            this.lblYieldAtPaintCount.Size = new System.Drawing.Size(13, 13);
            this.lblYieldAtPaintCount.TabIndex = 11;
            this.lblYieldAtPaintCount.Text = "0";
            // 
            // lblYieldAtPaint
            // 
            this.lblYieldAtPaint.AutoSize = true;
            this.lblYieldAtPaint.Location = new System.Drawing.Point(140, 139);
            this.lblYieldAtPaint.Name = "lblYieldAtPaint";
            this.lblYieldAtPaint.Size = new System.Drawing.Size(69, 13);
            this.lblYieldAtPaint.TabIndex = 10;
            this.lblYieldAtPaint.Text = "Yield at Paint";
            // 
            // lblSuccessfullyPaintedCount
            // 
            this.lblSuccessfullyPaintedCount.AutoSize = true;
            this.lblSuccessfullyPaintedCount.Location = new System.Drawing.Point(225, 116);
            this.lblSuccessfullyPaintedCount.Name = "lblSuccessfullyPaintedCount";
            this.lblSuccessfullyPaintedCount.Size = new System.Drawing.Size(13, 13);
            this.lblSuccessfullyPaintedCount.TabIndex = 9;
            this.lblSuccessfullyPaintedCount.Text = "0";
            // 
            // lblSuccessfullyPainted
            // 
            this.lblSuccessfullyPainted.AutoSize = true;
            this.lblSuccessfullyPainted.Location = new System.Drawing.Point(78, 116);
            this.lblSuccessfullyPainted.Name = "lblSuccessfullyPainted";
            this.lblSuccessfullyPainted.Size = new System.Drawing.Size(132, 13);
            this.lblSuccessfullyPainted.TabIndex = 8;
            this.lblSuccessfullyPainted.Text = "Total Successfully Painted";
            // 
            // lblYieldAtMoldCount
            // 
            this.lblYieldAtMoldCount.AutoSize = true;
            this.lblYieldAtMoldCount.Location = new System.Drawing.Point(225, 89);
            this.lblYieldAtMoldCount.Name = "lblYieldAtMoldCount";
            this.lblYieldAtMoldCount.Size = new System.Drawing.Size(13, 13);
            this.lblYieldAtMoldCount.TabIndex = 7;
            this.lblYieldAtMoldCount.Text = "0";
            // 
            // lblYieldAtMold
            // 
            this.lblYieldAtMold.AutoSize = true;
            this.lblYieldAtMold.Location = new System.Drawing.Point(140, 89);
            this.lblYieldAtMold.Name = "lblYieldAtMold";
            this.lblYieldAtMold.Size = new System.Drawing.Size(69, 13);
            this.lblYieldAtMold.TabIndex = 6;
            this.lblYieldAtMold.Text = "Yield At Mold";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 632);
            this.Controls.Add(this.lblConnectionString);
            this.Controls.Add(this.txtDatabaseConnectionString);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Live Report";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label lblTotalMolded;
        private System.Windows.Forms.Label lblTotalMoldedCount;
        private System.Windows.Forms.TextBox txtDatabaseConnectionString;
        private System.Windows.Forms.Label lblTotalSuccessMoldCount;
        private System.Windows.Forms.Label lblTotalSuccessMold;
        private System.Windows.Forms.Label lblConnectionString;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblYieldAtMoldCount;
        private System.Windows.Forms.Label lblYieldAtMold;
        private System.Windows.Forms.Label lblSuccessfullyPaintedCount;
        private System.Windows.Forms.Label lblSuccessfullyPainted;
        private System.Windows.Forms.Label lblYieldAtPaintCount;
        private System.Windows.Forms.Label lblYieldAtPaint;
        private System.Windows.Forms.Label lblTotalPartsSuccessfullyAsbCount;
        private System.Windows.Forms.Label lblTotalPartsSuccessfullyAsb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblYieldAtAssembly;
        private System.Windows.Forms.Label lblYieldAtAssemblyCount;
    }
}

