namespace Range_Application
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtinteger = new System.Windows.Forms.TextBox();
            this.lblinteger = new System.Windows.Forms.Label();
            this.lblrange = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.btnexit);
            this.groupBox1.Controls.Add(this.btncalculate);
            this.groupBox1.Controls.Add(this.lbloutput);
            this.groupBox1.Controls.Add(this.lblrange);
            this.groupBox1.Controls.Add(this.lblinteger);
            this.groupBox1.Controls.Add(this.txtinteger);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(119, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 378);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Range Cheaker Application";
            // 
            // txtinteger
            // 
            this.txtinteger.Location = new System.Drawing.Point(108, 106);
            this.txtinteger.Name = "txtinteger";
            this.txtinteger.Size = new System.Drawing.Size(304, 35);
            this.txtinteger.TabIndex = 1;
            // 
            // lblinteger
            // 
            this.lblinteger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinteger.Location = new System.Drawing.Point(65, 44);
            this.lblinteger.Name = "lblinteger";
            this.lblinteger.Size = new System.Drawing.Size(421, 59);
            this.lblinteger.TabIndex = 2;
            this.lblinteger.Text = "Enter An Integer In THe Range Of 1 Throught 10:";
            // 
            // lblrange
            // 
            this.lblrange.Location = new System.Drawing.Point(158, 155);
            this.lblrange.Name = "lblrange";
            this.lblrange.Size = new System.Drawing.Size(232, 46);
            this.lblrange.TabIndex = 3;
            this.lblrange.Text = "Range Decision:";
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(108, 201);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(304, 67);
            this.lbloutput.TabIndex = 4;
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(60, 282);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(137, 81);
            this.btncalculate.TabIndex = 1;
            this.btncalculate.Text = "Cheked The Range";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(357, 302);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(137, 42);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Exit:";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(214, 300);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(137, 44);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "Clea&r";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblinteger;
        private System.Windows.Forms.TextBox txtinteger;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Label lblrange;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btncalculate;
    }
}

