namespace C__Assament
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
            this.prodect = new System.Windows.Forms.GroupBox();
            this.lblpackages = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtpackages = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.quantitydiscount = new System.Windows.Forms.GroupBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblqimodhimis = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.prodect.SuspendLayout();
            this.quantitydiscount.SuspendLayout();
            this.SuspendLayout();
            // 
            // prodect
            // 
            this.prodect.Controls.Add(this.btncalculate);
            this.prodect.Controls.Add(this.btnExit);
            this.prodect.Controls.Add(this.btnClear);
            this.prodect.Controls.Add(this.txtprice);
            this.prodect.Controls.Add(this.txtpackages);
            this.prodect.Controls.Add(this.lblprice);
            this.prodect.Controls.Add(this.lblpackages);
            this.prodect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodect.Location = new System.Drawing.Point(12, 50);
            this.prodect.Name = "prodect";
            this.prodect.Size = new System.Drawing.Size(620, 298);
            this.prodect.TabIndex = 0;
            this.prodect.TabStop = false;
            this.prodect.Text = "Prodect information";
            // 
            // lblpackages
            // 
            this.lblpackages.AutoSize = true;
            this.lblpackages.Location = new System.Drawing.Point(48, 62);
            this.lblpackages.Name = "lblpackages";
            this.lblpackages.Size = new System.Drawing.Size(236, 29);
            this.lblpackages.TabIndex = 0;
            this.lblpackages.Text = "Number of packages";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(48, 130);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(173, 29);
            this.lblprice.TabIndex = 1;
            this.lblprice.Text = "Pricepackages";
            // 
            // txtpackages
            // 
            this.txtpackages.Location = new System.Drawing.Point(327, 62);
            this.txtpackages.Name = "txtpackages";
            this.txtpackages.Size = new System.Drawing.Size(257, 35);
            this.txtpackages.TabIndex = 2;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(327, 124);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(257, 35);
            this.txtprice.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(218, 221);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 54);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(377, 212);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 63);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(52, 212);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(130, 63);
            this.btncalculate.TabIndex = 7;
            this.btncalculate.Text = "calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // quantitydiscount
            // 
            this.quantitydiscount.Controls.Add(this.lblqimodhimis);
            this.quantitydiscount.Controls.Add(this.lblQuantity);
            this.quantitydiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitydiscount.Location = new System.Drawing.Point(12, 357);
            this.quantitydiscount.Name = "quantitydiscount";
            this.quantitydiscount.Size = new System.Drawing.Size(720, 255);
            this.quantitydiscount.TabIndex = 1;
            this.quantitydiscount.TabStop = false;
            this.quantitydiscount.Text = "Quantity Discount table";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblQuantity.Location = new System.Drawing.Point(31, 42);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(100, 29);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblqimodhimis
            // 
            this.lblqimodhimis.AutoSize = true;
            this.lblqimodhimis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblqimodhimis.Location = new System.Drawing.Point(447, 31);
            this.lblqimodhimis.Name = "lblqimodhimis";
            this.lblqimodhimis.Size = new System.Drawing.Size(114, 29);
            this.lblqimodhimis.TabIndex = 5;
            this.lblqimodhimis.Text = "Descount";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(767, 50);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(363, 424);
            this.listBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 613);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.quantitydiscount);
            this.Controls.Add(this.prodect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.prodect.ResumeLayout(false);
            this.prodect.PerformLayout();
            this.quantitydiscount.ResumeLayout(false);
            this.quantitydiscount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox prodect;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblpackages;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtpackages;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.GroupBox quantitydiscount;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblqimodhimis;
        private System.Windows.Forms.ListBox listBox;
    }
}

