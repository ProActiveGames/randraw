namespace randraw
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.NumericUpDown();
            this.btnGo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.chkNoHeader = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input file csv";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(16, 32);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(599, 26);
            this.txtInput.TabIndex = 1;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(621, 31);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(47, 36);
            this.btnInput.TabIndex = 2;
            this.btnInput.Text = "...";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(621, 110);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(47, 36);
            this.btnOutput.TabIndex = 6;
            this.btnOutput.Text = "...";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(16, 111);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(599, 26);
            this.txtOutput.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output file csv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of rows to draw";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(16, 201);
            this.txtNum.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(120, 26);
            this.txtNum.TabIndex = 8;
            this.txtNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(547, 296);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(121, 43);
            this.btnGo.TabIndex = 11;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Random.org API key";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(255, 200);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(360, 26);
            this.txtKey.TabIndex = 10;
            // 
            // chkNoHeader
            // 
            this.chkNoHeader.AutoSize = true;
            this.chkNoHeader.Location = new System.Drawing.Point(429, 64);
            this.chkNoHeader.Name = "chkNoHeader";
            this.chkNoHeader.Size = new System.Drawing.Size(186, 24);
            this.chkNoHeader.TabIndex = 3;
            this.chkNoHeader.Text = "No header in CSV file";
            this.chkNoHeader.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 307);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 20);
            this.lblStatus.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 359);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.chkNoHeader);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Draw";
            ((System.ComponentModel.ISupportInitialize)(this.txtNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtNum;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.CheckBox chkNoHeader;
        private System.Windows.Forms.Label lblStatus;
    }
}

