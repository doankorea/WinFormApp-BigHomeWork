namespace fa_icon_demo.CustomControls
{
    partial class btnProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnProduct));
            this.ItemImages = new System.Windows.Forms.PictureBox();
            this.ItemName = new System.Windows.Forms.Label();
            this.ItemPrice = new System.Windows.Forms.Label();
            this.btnbuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ItemImages)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemImages
            // 
            this.ItemImages.Location = new System.Drawing.Point(8, 12);
            this.ItemImages.Name = "ItemImages";
            this.ItemImages.Size = new System.Drawing.Size(140, 105);
            this.ItemImages.TabIndex = 0;
            this.ItemImages.TabStop = false;
            // 
            // ItemName
            // 
            this.ItemName.AutoSize = true;
            this.ItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName.ForeColor = System.Drawing.Color.Gainsboro;
            this.ItemName.Location = new System.Drawing.Point(5, 120);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(76, 18);
            this.ItemName.TabIndex = 1;
            this.ItemName.Text = "ItemName";
            // 
            // ItemPrice
            // 
            this.ItemPrice.AutoSize = true;
            this.ItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemPrice.ForeColor = System.Drawing.Color.White;
            this.ItemPrice.Location = new System.Drawing.Point(4, 158);
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.Size = new System.Drawing.Size(51, 22);
            this.ItemPrice.TabIndex = 2;
            this.ItemPrice.Text = "Price";
            // 
            // btnbuy
            // 
            this.btnbuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.btnbuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbuy.BackgroundImage")));
            this.btnbuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnbuy.FlatAppearance.BorderSize = 0;
            this.btnbuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuy.Location = new System.Drawing.Point(8, 183);
            this.btnbuy.Name = "btnbuy";
            this.btnbuy.Size = new System.Drawing.Size(144, 28);
            this.btnbuy.TabIndex = 3;
            this.btnbuy.UseVisualStyleBackColor = false;
            // 
            // btnProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(160, 218);
            this.Controls.Add(this.btnbuy);
            this.Controls.Add(this.ItemPrice);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.ItemImages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "btnProduct";
            this.Text = "btnProduct";
            ((System.ComponentModel.ISupportInitialize)(this.ItemImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ItemImages;
        private System.Windows.Forms.Label ItemName;
        private System.Windows.Forms.Label ItemPrice;
        private System.Windows.Forms.Button btnbuy;
    }
}