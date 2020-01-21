namespace Chapter7ProgramTableofSquare
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtStrtTbl = new System.Windows.Forms.TextBox();
            this.txtEndTbl = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblNumberSqr = new System.Windows.Forms.Label();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting Table Value:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ending Table Value:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtStrtTbl
            // 
            this.txtStrtTbl.Location = new System.Drawing.Point(220, 13);
            this.txtStrtTbl.Name = "txtStrtTbl";
            this.txtStrtTbl.Size = new System.Drawing.Size(100, 20);
            this.txtStrtTbl.TabIndex = 2;
            this.txtStrtTbl.Text = "0";
            // 
            // txtEndTbl
            // 
            this.txtEndTbl.Location = new System.Drawing.Point(220, 50);
            this.txtEndTbl.Name = "txtEndTbl";
            this.txtEndTbl.Size = new System.Drawing.Size(100, 20);
            this.txtEndTbl.TabIndex = 3;
            this.txtEndTbl.Text = "100";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(13, 101);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Ca&lculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(127, 101);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(245, 101);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNumber.Location = new System.Drawing.Point(13, 162);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(100, 20);
            this.lblNumber.TabIndex = 7;
            this.lblNumber.Text = "Number";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNumberSqr
            // 
            this.lblNumberSqr.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblNumberSqr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumberSqr.Location = new System.Drawing.Point(170, 163);
            this.lblNumberSqr.Name = "lblNumberSqr";
            this.lblNumberSqr.Size = new System.Drawing.Size(150, 20);
            this.lblNumberSqr.TabIndex = 8;
            this.lblNumberSqr.Text = "Number Squared";
            this.lblNumberSqr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(13, 209);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(307, 225);
            this.lstOutput.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 452);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.lblNumberSqr);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtEndTbl);
            this.Controls.Add(this.txtStrtTbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Text = "Table of Squares";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStrtTbl;
        private System.Windows.Forms.TextBox txtEndTbl;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblNumberSqr;
        private System.Windows.Forms.ListBox lstOutput;
    }
}

