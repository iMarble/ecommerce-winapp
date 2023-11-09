namespace LoginApp
{
    partial class DeleteProductSeller
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
            this.labelWhichProduct = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnCancelProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWhichProduct
            // 
            this.labelWhichProduct.AutoSize = true;
            this.labelWhichProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWhichProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelWhichProduct.Location = new System.Drawing.Point(51, 55);
            this.labelWhichProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWhichProduct.Name = "labelWhichProduct";
            this.labelWhichProduct.Size = new System.Drawing.Size(415, 25);
            this.labelWhichProduct.TabIndex = 0;
            this.labelWhichProduct.Text = "Which Product would you like to Remove?";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(72, 120);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(155, 25);
            this.labelProductName.TabIndex = 1;
            this.labelProductName.Text = "Product Name:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(234, 117);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveProduct.Location = new System.Drawing.Point(34, 215);
            this.btnRemoveProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(192, 75);
            this.btnRemoveProduct.TabIndex = 3;
            this.btnRemoveProduct.Text = "Remove";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnCancelProduct
            // 
            this.btnCancelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelProduct.Location = new System.Drawing.Point(300, 215);
            this.btnCancelProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelProduct.Name = "btnCancelProduct";
            this.btnCancelProduct.Size = new System.Drawing.Size(194, 75);
            this.btnCancelProduct.TabIndex = 4;
            this.btnCancelProduct.Text = "Cancel";
            this.btnCancelProduct.UseVisualStyleBackColor = true;
            this.btnCancelProduct.Click += new System.EventHandler(this.btnCancelProduct_Click);
            // 
            // DeleteProductSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(736, 449);
            this.Controls.Add(this.btnCancelProduct);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelWhichProduct);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DeleteProductSeller";
            this.Text = "Remove Product Form";
            this.Load += new System.EventHandler(this.DeleteProductSeller_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeleteProductSeller_Close);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWhichProduct;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnCancelProduct;
    }
}