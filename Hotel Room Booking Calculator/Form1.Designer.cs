namespace Hotel_Room_Booking_Calculator
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblroomtype = new System.Windows.Forms.Label();
            this.lblnumberofnights = new System.Windows.Forms.Label();
            this.lblpricepernight = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.txtpriceNight = new System.Windows.Forms.TextBox();
            this.txtRoomtype = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.lblservucetax = new System.Windows.Forms.Label();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.LblDiscount = new System.Windows.Forms.Label();
            this.LblTotalAmount = new System.Windows.Forms.Label();
            this.LblServiceTax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(72, 33);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(154, 20);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Enter Guest Name  :";
            // 
            // lblroomtype
            // 
            this.lblroomtype.AutoSize = true;
            this.lblroomtype.Location = new System.Drawing.Point(82, 100);
            this.lblroomtype.Name = "lblroomtype";
            this.lblroomtype.Size = new System.Drawing.Size(144, 20);
            this.lblroomtype.TabIndex = 1;
            this.lblroomtype.Text = "lEnter Room Type :";
            // 
            // lblnumberofnights
            // 
            this.lblnumberofnights.AutoSize = true;
            this.lblnumberofnights.Location = new System.Drawing.Point(40, 179);
            this.lblnumberofnights.Name = "lblnumberofnights";
            this.lblnumberofnights.Size = new System.Drawing.Size(186, 20);
            this.lblnumberofnights.TabIndex = 2;
            this.lblnumberofnights.Text = "Enter Number Of Nights :";
            // 
            // lblpricepernight
            // 
            this.lblpricepernight.AutoSize = true;
            this.lblpricepernight.Location = new System.Drawing.Point(62, 248);
            this.lblpricepernight.Name = "lblpricepernight";
            this.lblpricepernight.Size = new System.Drawing.Size(164, 20);
            this.lblpricepernight.TabIndex = 3;
            this.lblpricepernight.Text = "Enter Price Per Nigth :";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(326, 12);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(327, 47);
            this.txtname.TabIndex = 4;
            // 
            // txtNights
            // 
            this.txtNights.Location = new System.Drawing.Point(326, 152);
            this.txtNights.Multiline = true;
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(334, 47);
            this.txtNights.TabIndex = 5;
            // 
            // txtpriceNight
            // 
            this.txtpriceNight.Location = new System.Drawing.Point(326, 220);
            this.txtpriceNight.Multiline = true;
            this.txtpriceNight.Name = "txtpriceNight";
            this.txtpriceNight.Size = new System.Drawing.Size(334, 48);
            this.txtpriceNight.TabIndex = 7;
            // 
            // txtRoomtype
            // 
            this.txtRoomtype.Location = new System.Drawing.Point(326, 77);
            this.txtRoomtype.Multiline = true;
            this.txtRoomtype.Name = "txtRoomtype";
            this.txtRoomtype.Size = new System.Drawing.Size(327, 43);
            this.txtRoomtype.TabIndex = 6;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(331, 307);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(253, 64);
            this.btncalculate.TabIndex = 8;
            this.btncalculate.Text = "Calculate Booking";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // lblservucetax
            // 
            this.lblservucetax.AutoSize = true;
            this.lblservucetax.Location = new System.Drawing.Point(127, 392);
            this.lblservucetax.Name = "lblservucetax";
            this.lblservucetax.Size = new System.Drawing.Size(98, 20);
            this.lblservucetax.TabIndex = 9;
            this.lblservucetax.Text = "Service Tax :";
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.AutoSize = true;
            this.lblDiscountAmount.Location = new System.Drawing.Point(85, 461);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(140, 20);
            this.lblDiscountAmount.TabIndex = 10;
            this.lblDiscountAmount.Text = "Discount Amount :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(113, 531);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(112, 20);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total Amount :";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(355, 392);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(0, 20);
            this.lblService.TabIndex = 12;
            // 
            // LblDiscount
            // 
            this.LblDiscount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblDiscount.Location = new System.Drawing.Point(326, 442);
            this.LblDiscount.Name = "LblDiscount";
            this.LblDiscount.Size = new System.Drawing.Size(258, 42);
            this.LblDiscount.TabIndex = 13;
            // 
            // LblTotalAmount
            // 
            this.LblTotalAmount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblTotalAmount.Location = new System.Drawing.Point(326, 508);
            this.LblTotalAmount.Name = "LblTotalAmount";
            this.LblTotalAmount.Size = new System.Drawing.Size(264, 46);
            this.LblTotalAmount.TabIndex = 14;
            // 
            // LblServiceTax
            // 
            this.LblServiceTax.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblServiceTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblServiceTax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblServiceTax.Location = new System.Drawing.Point(326, 392);
            this.LblServiceTax.Name = "LblServiceTax";
            this.LblServiceTax.Size = new System.Drawing.Size(258, 36);
            this.LblServiceTax.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.LblServiceTax);
            this.Controls.Add(this.LblTotalAmount);
            this.Controls.Add(this.LblDiscount);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDiscountAmount);
            this.Controls.Add(this.lblservucetax);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtpriceNight);
            this.Controls.Add(this.txtRoomtype);
            this.Controls.Add(this.txtNights);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblpricepernight);
            this.Controls.Add(this.lblnumberofnights);
            this.Controls.Add(this.lblroomtype);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblroomtype;
        private System.Windows.Forms.Label lblnumberofnights;
        private System.Windows.Forms.Label lblpricepernight;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.TextBox txtpriceNight;
        private System.Windows.Forms.TextBox txtRoomtype;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label lblservucetax;
        private System.Windows.Forms.Label lblDiscountAmount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label LblDiscount;
        private System.Windows.Forms.Label LblTotalAmount;
        private System.Windows.Forms.Label LblServiceTax;
    }
}

