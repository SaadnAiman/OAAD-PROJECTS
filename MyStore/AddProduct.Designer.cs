namespace MyStore
{
    partial class AddProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.PPricetxt = new System.Windows.Forms.TextBox();
            this.lblprice = new System.Windows.Forms.Label();
            this.PQuantitytxt = new System.Windows.Forms.TextBox();
            this.lblquantity = new System.Windows.Forms.Label();
            this.lblproductname = new System.Windows.Forms.Label();
            this.PNametxt = new System.Windows.Forms.TextBox();
            this.lbljnc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnreset);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.PPricetxt);
            this.panel1.Controls.Add(this.lblprice);
            this.panel1.Controls.Add(this.PQuantitytxt);
            this.panel1.Controls.Add(this.lblquantity);
            this.panel1.Controls.Add(this.lblproductname);
            this.panel1.Controls.Add(this.PNametxt);
            this.panel1.Controls.Add(this.lbljnc);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 265);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyStore.Properties.Resources.IMG_2203;
            this.pictureBox1.InitialImage = global::MyStore.Properties.Resources.IMG_2203;
            this.pictureBox1.Location = new System.Drawing.Point(18, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(27, 227);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 28);
            this.btnreset.TabIndex = 19;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(190, 227);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 28);
            this.btnadd.TabIndex = 18;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // PPricetxt
            // 
            this.PPricetxt.Location = new System.Drawing.Point(118, 179);
            this.PPricetxt.Multiline = true;
            this.PPricetxt.Name = "PPricetxt";
            this.PPricetxt.Size = new System.Drawing.Size(177, 24);
            this.PPricetxt.TabIndex = 17;
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(14, 178);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(40, 19);
            this.lblprice.TabIndex = 16;
            this.lblprice.Text = "Price";
            // 
            // PQuantitytxt
            // 
            this.PQuantitytxt.Location = new System.Drawing.Point(118, 138);
            this.PQuantitytxt.Multiline = true;
            this.PQuantitytxt.Name = "PQuantitytxt";
            this.PQuantitytxt.Size = new System.Drawing.Size(177, 24);
            this.PQuantitytxt.TabIndex = 15;
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantity.Location = new System.Drawing.Point(14, 137);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(60, 19);
            this.lblquantity.TabIndex = 14;
            this.lblquantity.Text = "Quantity";
            // 
            // lblproductname
            // 
            this.lblproductname.AutoSize = true;
            this.lblproductname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductname.Location = new System.Drawing.Point(14, 90);
            this.lblproductname.Name = "lblproductname";
            this.lblproductname.Size = new System.Drawing.Size(98, 19);
            this.lblproductname.TabIndex = 13;
            this.lblproductname.Text = "Product Name";
            // 
            // PNametxt
            // 
            this.PNametxt.Location = new System.Drawing.Point(118, 91);
            this.PNametxt.Multiline = true;
            this.PNametxt.Name = "PNametxt";
            this.PNametxt.Size = new System.Drawing.Size(177, 24);
            this.PNametxt.TabIndex = 8;
            // 
            // lbljnc
            // 
            this.lbljnc.AutoSize = true;
            this.lbljnc.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljnc.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbljnc.Location = new System.Drawing.Point(86, 8);
            this.lbljnc.Name = "lbljnc";
            this.lbljnc.Size = new System.Drawing.Size(220, 36);
            this.lbljnc.TabIndex = 6;
            this.lbljnc.Text = "jewels.n.Crafts";
            this.lbljnc.Click += new System.EventHandler(this.label3_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 268);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(344, 307);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbljnc;
        private System.Windows.Forms.TextBox PNametxt;
        private System.Windows.Forms.TextBox PPricetxt;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.TextBox PQuantitytxt;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.Label lblproductname;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}