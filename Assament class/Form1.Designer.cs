namespace Assament_class
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
            this.lblfood = new System.Windows.Forms.Label();
            this.lblfoodbrise = new System.Windows.Forms.Label();
            this.lblfood2 = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtfood1 = new System.Windows.Forms.TextBox();
            this.txtfood2 = new System.Windows.Forms.TextBox();
            this.txtfood3 = new System.Windows.Forms.TextBox();
            this.txtfood4 = new System.Windows.Forms.TextBox();
            this.bttcalculate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblfood
            // 
            this.lblfood.AutoSize = true;
            this.lblfood.Location = new System.Drawing.Point(103, 32);
            this.lblfood.Name = "lblfood";
            this.lblfood.Size = new System.Drawing.Size(96, 20);
            this.lblfood.TabIndex = 0;
            this.lblfood.Text = "Enter food  :";
            // 
            // lblfoodbrise
            // 
            this.lblfoodbrise.AutoSize = true;
            this.lblfoodbrise.Location = new System.Drawing.Point(70, 103);
            this.lblfoodbrise.Name = "lblfoodbrise";
            this.lblfoodbrise.Size = new System.Drawing.Size(113, 20);
            this.lblfoodbrise.TabIndex = 1;
            this.lblfoodbrise.Text = "Enter food 2   :";
            // 
            // lblfood2
            // 
            this.lblfood2.AutoSize = true;
            this.lblfood2.Location = new System.Drawing.Point(85, 160);
            this.lblfood2.Name = "lblfood2";
            this.lblfood2.Size = new System.Drawing.Size(103, 20);
            this.lblfood2.TabIndex = 2;
            this.lblfood2.Text = "Enter price1 :";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(103, 243);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(64, 20);
            this.lblprice.TabIndex = 3;
            this.lblprice.Text = "price2  :";
            // 
            // txtfood1
            // 
            this.txtfood1.Location = new System.Drawing.Point(319, 29);
            this.txtfood1.Multiline = true;
            this.txtfood1.Name = "txtfood1";
            this.txtfood1.Size = new System.Drawing.Size(222, 47);
            this.txtfood1.TabIndex = 4;
            // 
            // txtfood2
            // 
            this.txtfood2.Location = new System.Drawing.Point(319, 103);
            this.txtfood2.Multiline = true;
            this.txtfood2.Name = "txtfood2";
            this.txtfood2.Size = new System.Drawing.Size(229, 40);
            this.txtfood2.TabIndex = 5;
            // 
            // txtfood3
            // 
            this.txtfood3.Location = new System.Drawing.Point(312, 171);
            this.txtfood3.Multiline = true;
            this.txtfood3.Name = "txtfood3";
            this.txtfood3.Size = new System.Drawing.Size(229, 45);
            this.txtfood3.TabIndex = 6;
            // 
            // txtfood4
            // 
            this.txtfood4.Location = new System.Drawing.Point(312, 243);
            this.txtfood4.Multiline = true;
            this.txtfood4.Name = "txtfood4";
            this.txtfood4.Size = new System.Drawing.Size(229, 38);
            this.txtfood4.TabIndex = 7;
            this.txtfood4.TextChanged += new System.EventHandler(this.txtfood4_TextChanged);
            // 
            // bttcalculate
            // 
            this.bttcalculate.Location = new System.Drawing.Point(300, 437);
            this.bttcalculate.Name = "bttcalculate";
            this.bttcalculate.Size = new System.Drawing.Size(194, 64);
            this.bttcalculate.TabIndex = 8;
            this.bttcalculate.Text = "calculate button";
            this.bttcalculate.UseVisualStyleBackColor = true;
            this.bttcalculate.Click += new System.EventHandler(this.bttcalculate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 10;
            // 
            // lblresult
            // 
            this.lblresult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblresult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblresult.Location = new System.Drawing.Point(217, 321);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(447, 92);
            this.lblresult.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bttcalculate);
            this.Controls.Add(this.txtfood4);
            this.Controls.Add(this.txtfood3);
            this.Controls.Add(this.txtfood2);
            this.Controls.Add(this.txtfood1);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblfood2);
            this.Controls.Add(this.lblfoodbrise);
            this.Controls.Add(this.lblfood);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfood;
        private System.Windows.Forms.Label lblfoodbrise;
        private System.Windows.Forms.Label lblfood2;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.TextBox txtfood1;
        private System.Windows.Forms.TextBox txtfood2;
        private System.Windows.Forms.TextBox txtfood3;
        private System.Windows.Forms.TextBox txtfood4;
        private System.Windows.Forms.Button bttcalculate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblresult;
    }
}

