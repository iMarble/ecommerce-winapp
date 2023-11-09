using System;

namespace LoginApp
{
    partial class Seller
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
            this.btnviewProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnRmvProduct = new System.Windows.Forms.Button();
            this.btnupdateProduxt = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SellerName = new System.Windows.Forms.Label();
            this.SellerId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "What do you want to do?";
            // 
            // btnviewProduct
            // 
            this.btnviewProduct.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewProduct.Location = new System.Drawing.Point(58, 97);
            this.btnviewProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnviewProduct.Name = "btnviewProduct";
            this.btnviewProduct.Size = new System.Drawing.Size(174, 60);
            this.btnviewProduct.TabIndex = 1;
            this.btnviewProduct.Text = "View Products";
            this.btnviewProduct.UseVisualStyleBackColor = true;
            this.btnviewProduct.Click += new System.EventHandler(this.btnviewProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(58, 188);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(174, 60);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "Add Products";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnRmvProduct
            // 
            this.btnRmvProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRmvProduct.Location = new System.Drawing.Point(58, 278);
            this.btnRmvProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRmvProduct.Name = "btnRmvProduct";
            this.btnRmvProduct.Size = new System.Drawing.Size(214, 48);
            this.btnRmvProduct.TabIndex = 3;
            this.btnRmvProduct.Text = "Remove Product";
            this.btnRmvProduct.UseVisualStyleBackColor = true;
            this.btnRmvProduct.Click += new System.EventHandler(this.btnRmvProduct_Click);
            // 
            // btnupdateProduxt
            // 
            this.btnupdateProduxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdateProduxt.Location = new System.Drawing.Point(58, 374);
            this.btnupdateProduxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnupdateProduxt.Name = "btnupdateProduxt";
            this.btnupdateProduxt.Size = new System.Drawing.Size(214, 45);
            this.btnupdateProduxt.TabIndex = 4;
            this.btnupdateProduxt.Text = "Update Product";
            this.btnupdateProduxt.UseVisualStyleBackColor = true;
            this.btnupdateProduxt.Click += new System.EventHandler(this.btnupdateProduxt_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(495, 512);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(147, 60);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SellerName
            // 
            this.SellerName.AutoSize = true;
            this.SellerName.Location = new System.Drawing.Point(522, 49);
            this.SellerName.Name = "SellerName";
            this.SellerName.Size = new System.Drawing.Size(51, 20);
            this.SellerName.TabIndex = 6;
            this.SellerName.Text = "label2";
            this.SellerName.Visible = false;
            // 
            // SellerId
            // 
            this.SellerId.AutoSize = true;
            this.SellerId.Location = new System.Drawing.Point(522, 97);
            this.SellerId.Name = "SellerId";
            this.SellerId.Size = new System.Drawing.Size(51, 20);
            this.SellerId.TabIndex = 7;
            this.SellerId.Text = "label2";
            this.SellerId.Visible = false;
            // 
            // Seller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(682, 591);
            this.Controls.Add(this.SellerId);
            this.Controls.Add(this.SellerName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnupdateProduxt);
            this.Controls.Add(this.btnRmvProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnviewProduct);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Seller";
            this.Text = "Seller";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnviewProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnRmvProduct;
        private System.Windows.Forms.Button btnupdateProduxt;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label SellerName;
        private System.Windows.Forms.Label SellerId;
    }
}

