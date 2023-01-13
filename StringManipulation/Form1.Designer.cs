namespace StringManipulation
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
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnParseName = new System.Windows.Forms.Button();
            this.btnEditPhoneNumber = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(113, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(113, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Phone Number";
            // 
            // txtFullName
            // 
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Location = new System.Drawing.Point(343, 61);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(218, 28);
            this.txtFullName.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNumber.Location = new System.Drawing.Point(343, 139);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(218, 28);
            this.txtPhoneNumber.TabIndex = 2;
            // 
            // btnParseName
            // 
            this.btnParseName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnParseName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnParseName.Location = new System.Drawing.Point(221, 220);
            this.btnParseName.Name = "btnParseName";
            this.btnParseName.Size = new System.Drawing.Size(221, 47);
            this.btnParseName.TabIndex = 3;
            this.btnParseName.Text = "Parse Name";
            this.btnParseName.UseVisualStyleBackColor = false;
            // 
            // btnEditPhoneNumber
            // 
            this.btnEditPhoneNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditPhoneNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditPhoneNumber.Location = new System.Drawing.Point(221, 286);
            this.btnEditPhoneNumber.Name = "btnEditPhoneNumber";
            this.btnEditPhoneNumber.Size = new System.Drawing.Size(221, 47);
            this.btnEditPhoneNumber.TabIndex = 4;
            this.btnEditPhoneNumber.Text = "Edit Phone Number";
            this.btnEditPhoneNumber.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(221, 352);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(221, 47);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 446);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEditPhoneNumber);
            this.Controls.Add(this.btnParseName);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnParseName;
        private System.Windows.Forms.Button btnEditPhoneNumber;
        private System.Windows.Forms.Button btnExit;
    }
}

