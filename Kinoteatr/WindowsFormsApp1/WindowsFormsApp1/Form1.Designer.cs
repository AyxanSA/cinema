namespace WindowsFormsApp1
{
    partial class Forum1
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
            this.BtnZal1 = new System.Windows.Forms.Button();
            this.BtnZal2 = new System.Windows.Forms.Button();
            this.BtnZal3 = new System.Windows.Forms.Button();
            this.PnlSeats = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectedPlace = new System.Windows.Forms.Label();
            this.LblTotalPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnZal1
            // 
            this.BtnZal1.Location = new System.Drawing.Point(31, 23);
            this.BtnZal1.Name = "BtnZal1";
            this.BtnZal1.Size = new System.Drawing.Size(157, 41);
            this.BtnZal1.TabIndex = 0;
            this.BtnZal1.Text = "1ci Zal";
            this.BtnZal1.UseVisualStyleBackColor = true;
            this.BtnZal1.Click += new System.EventHandler(this.SelectHall_click);
            // 
            // BtnZal2
            // 
            this.BtnZal2.Location = new System.Drawing.Point(31, 88);
            this.BtnZal2.Name = "BtnZal2";
            this.BtnZal2.Size = new System.Drawing.Size(157, 41);
            this.BtnZal2.TabIndex = 1;
            this.BtnZal2.Text = "2ci Zal";
            this.BtnZal2.UseVisualStyleBackColor = true;
            this.BtnZal2.Click += new System.EventHandler(this.SelectHall_click);
            // 
            // BtnZal3
            // 
            this.BtnZal3.Location = new System.Drawing.Point(31, 153);
            this.BtnZal3.Name = "BtnZal3";
            this.BtnZal3.Size = new System.Drawing.Size(157, 41);
            this.BtnZal3.TabIndex = 2;
            this.BtnZal3.Text = "3cu Zal";
            this.BtnZal3.UseVisualStyleBackColor = true;
            this.BtnZal3.Click += new System.EventHandler(this.SelectHall_click);
            // 
            // PnlSeats
            // 
            this.PnlSeats.Location = new System.Drawing.Point(262, 23);
            this.PnlSeats.Name = "PnlSeats";
            this.PnlSeats.Size = new System.Drawing.Size(513, 244);
            this.PnlSeats.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "SecilmisYerler";
            // 
            // SelectedPlace
            // 
            this.SelectedPlace.AutoSize = true;
            this.SelectedPlace.Location = new System.Drawing.Point(39, 254);
            this.SelectedPlace.Name = "SelectedPlace";
            this.SelectedPlace.Size = new System.Drawing.Size(0, 13);
            this.SelectedPlace.TabIndex = 5;
            // 
            // LblTotalPrice
            // 
            this.LblTotalPrice.AutoSize = true;
            this.LblTotalPrice.Location = new System.Drawing.Point(39, 308);
            this.LblTotalPrice.Name = "LblTotalPrice";
            this.LblTotalPrice.Size = new System.Drawing.Size(0, 13);
            this.LblTotalPrice.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Toplam Qiymet";
            // 
            // BtnBook
            // 
            this.BtnBook.Location = new System.Drawing.Point(41, 337);
            this.BtnBook.Name = "BtnBook";
            this.BtnBook.Size = new System.Drawing.Size(118, 23);
            this.BtnBook.TabIndex = 8;
            this.BtnBook.Text = "Rezerv";
            this.BtnBook.UseVisualStyleBackColor = true;
            this.BtnBook.Visible = false;
            this.BtnBook.Click += new System.EventHandler(this.BtnBook_Click);
            // 
            // Forum1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.BtnBook);
            this.Controls.Add(this.LblTotalPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectedPlace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PnlSeats);
            this.Controls.Add(this.BtnZal3);
            this.Controls.Add(this.BtnZal2);
            this.Controls.Add(this.BtnZal1);
            this.Name = "Forum1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnZal1;
        private System.Windows.Forms.Button BtnZal2;
        private System.Windows.Forms.Button BtnZal3;
        private System.Windows.Forms.Panel PnlSeats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SelectedPlace;
        private System.Windows.Forms.Label LblTotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBook;
    }
}

