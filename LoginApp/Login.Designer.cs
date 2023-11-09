using System;

namespace LoginApp
{
    partial class Login
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
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.txtboxUserpass = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnNewAcc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Location = new System.Drawing.Point(199, 96);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(214, 26);
            this.txtboxUsername.TabIndex = 0;
            // 
            // txtboxUserpass
            // 
            this.txtboxUserpass.Location = new System.Drawing.Point(199, 147);
            this.txtboxUserpass.Name = "txtboxUserpass";
            this.txtboxUserpass.Size = new System.Drawing.Size(214, 26);
            this.txtboxUserpass.TabIndex = 1;
            this.txtboxUserpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSignUp_KeyDown);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(199, 207);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(97, 38);
            this.btnSignUp.TabIndex = 2;
            this.btnSignUp.Text = "Login";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnNewAcc
            // 
            this.btnNewAcc.Location = new System.Drawing.Point(316, 207);
            this.btnNewAcc.Name = "btnNewAcc";
            this.btnNewAcc.Size = new System.Drawing.Size(97, 38);
            this.btnNewAcc.TabIndex = 3;
            this.btnNewAcc.TabStop = false;
            this.btnNewAcc.Text = "SignUp";
            this.btnNewAcc.UseVisualStyleBackColor = true;
            this.btnNewAcc.Click += new System.EventHandler(this.btnNewAcc_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewAcc);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtboxUserpass);
            this.Controls.Add(this.txtboxUsername);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.TextBox txtboxUserpass;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnNewAcc;
    }
}

