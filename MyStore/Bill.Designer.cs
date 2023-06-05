namespace MyStore
{
    partial class Bill
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
            this.thanklbl = new System.Windows.Forms.Label();
            this.ttltxt = new System.Windows.Forms.TextBox();
            this.totaltxt = new System.Windows.Forms.TextBox();
            this.cartgrid = new System.Windows.Forms.DataGridView();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblqty = new System.Windows.Forms.Label();
            this.ttlitemlbl = new System.Windows.Forms.Label();
            this.lbljnc = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.label2datelbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.thanklbl);
            this.panel1.Controls.Add(this.ttltxt);
            this.panel1.Controls.Add(this.totaltxt);
            this.panel1.Controls.Add(this.cartgrid);
            this.panel1.Controls.Add(this.lblqty);
            this.panel1.Controls.Add(this.ttlitemlbl);
            this.panel1.Controls.Add(this.lbljnc);
            this.panel1.Controls.Add(this.lbldate);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.label2datelbl);
            this.panel1.Controls.Add(this.namelbl);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 517);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyStore.Properties.Resources.IMG_2203;
            this.pictureBox1.InitialImage = global::MyStore.Properties.Resources.IMG_2203;
            this.pictureBox1.Location = new System.Drawing.Point(60, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // thanklbl
            // 
            this.thanklbl.AutoSize = true;
            this.thanklbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanklbl.ForeColor = System.Drawing.Color.Crimson;
            this.thanklbl.Location = new System.Drawing.Point(56, 485);
            this.thanklbl.Name = "thanklbl";
            this.thanklbl.Size = new System.Drawing.Size(304, 21);
            this.thanklbl.TabIndex = 13;
            this.thanklbl.Text = "THANKYOU YOU FOR SHOPPING.";
            this.thanklbl.Click += new System.EventHandler(this.thanklbl_Click);
            // 
            // ttltxt
            // 
            this.ttltxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ttltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttltxt.Location = new System.Drawing.Point(281, 441);
            this.ttltxt.Multiline = true;
            this.ttltxt.Name = "ttltxt";
            this.ttltxt.ReadOnly = true;
            this.ttltxt.Size = new System.Drawing.Size(118, 25);
            this.ttltxt.TabIndex = 12;
            this.ttltxt.Text = " 0";
            // 
            // totaltxt
            // 
            this.totaltxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totaltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaltxt.Location = new System.Drawing.Point(3, 441);
            this.totaltxt.Multiline = true;
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.ReadOnly = true;
            this.totaltxt.Size = new System.Drawing.Size(281, 25);
            this.totaltxt.TabIndex = 11;
            this.totaltxt.Text = "                         Total :";
            // 
            // cartgrid
            // 
            this.cartgrid.AllowUserToAddRows = false;
            this.cartgrid.AllowUserToDeleteRows = false;
            this.cartgrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cartgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PName,
            this.PQty,
            this.PPrice,
            this.Total});
            this.cartgrid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cartgrid.Location = new System.Drawing.Point(3, 131);
            this.cartgrid.Name = "cartgrid";
            this.cartgrid.ReadOnly = true;
            this.cartgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartgrid.Size = new System.Drawing.Size(393, 304);
            this.cartgrid.TabIndex = 10;
            // 
            // PName
            // 
            this.PName.DataPropertyName = "PName";
            this.PName.HeaderText = "Product Name";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            this.PName.Width = 140;
            // 
            // PQty
            // 
            this.PQty.DataPropertyName = "Quantity";
            this.PQty.HeaderText = "Qty";
            this.PQty.Name = "PQty";
            this.PQty.ReadOnly = true;
            this.PQty.Width = 50;
            // 
            // PPrice
            // 
            this.PPrice.DataPropertyName = "Price";
            this.PPrice.HeaderText = "Price";
            this.PPrice.Name = "PPrice";
            this.PPrice.ReadOnly = true;
            this.PPrice.Width = 80;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 80;
            // 
            // lblqty
            // 
            this.lblqty.AutoSize = true;
            this.lblqty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqty.Location = new System.Drawing.Point(92, 101);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(0, 19);
            this.lblqty.TabIndex = 7;
            this.lblqty.Click += new System.EventHandler(this.lblqty_Click);
            // 
            // ttlitemlbl
            // 
            this.ttlitemlbl.AutoSize = true;
            this.ttlitemlbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttlitemlbl.Location = new System.Drawing.Point(10, 101);
            this.ttlitemlbl.Name = "ttlitemlbl";
            this.ttlitemlbl.Size = new System.Drawing.Size(81, 19);
            this.ttlitemlbl.TabIndex = 6;
            this.ttlitemlbl.Text = "Total Item : ";
            // 
            // lbljnc
            // 
            this.lbljnc.AutoSize = true;
            this.lbljnc.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljnc.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbljnc.Location = new System.Drawing.Point(131, 18);
            this.lbljnc.Name = "lbljnc";
            this.lbljnc.Size = new System.Drawing.Size(220, 36);
            this.lbljnc.TabIndex = 5;
            this.lbljnc.Text = "jewels.n.Crafts";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(232, 72);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(0, 19);
            this.lbldate.TabIndex = 3;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(63, 69);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(0, 19);
            this.lblname.TabIndex = 2;
            this.lblname.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2datelbl
            // 
            this.label2datelbl.AutoSize = true;
            this.label2datelbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2datelbl.Location = new System.Drawing.Point(193, 69);
            this.label2datelbl.Name = "label2datelbl";
            this.label2datelbl.Size = new System.Drawing.Size(49, 19);
            this.label2datelbl.TabIndex = 1;
            this.label2datelbl.Text = "Date : ";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.Location = new System.Drawing.Point(12, 69);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(57, 19);
            this.namelbl.TabIndex = 0;
            this.namelbl.Text = "Name : ";
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 519);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(422, 558);
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2datelbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbljnc;
        private System.Windows.Forms.Label lblqty;
        private System.Windows.Forms.Label ttlitemlbl;
        private System.Windows.Forms.DataGridView cartgrid;
        private System.Windows.Forms.TextBox totaltxt;
        private System.Windows.Forms.Label thanklbl;
        private System.Windows.Forms.TextBox ttltxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn PPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}