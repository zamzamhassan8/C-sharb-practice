namespace Average_Cost
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
            this.lblScore1 = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblScore3 = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.txtscore1 = new System.Windows.Forms.TextBox();
            this.txtScor2 = new System.Windows.Forms.TextBox();
            this.txtScore3 = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtScore3);
            this.groupBox1.Controls.Add(this.txtScor2);
            this.groupBox1.Controls.Add(this.txtscore1);
            this.groupBox1.Controls.Add(this.lbloutput);
            this.groupBox1.Controls.Add(this.lblAverage);
            this.groupBox1.Controls.Add(this.lblScore3);
            this.groupBox1.Controls.Add(this.lblScore2);
            this.groupBox1.Controls.Add(this.lblScore1);
            this.groupBox1.Location = new System.Drawing.Point(139, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblScore1
            // 
            this.lblScore1.Location = new System.Drawing.Point(63, 56);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(123, 34);
            this.lblScore1.TabIndex = 0;
            this.lblScore1.Text = "Score1:";
            // 
            // lblScore2
            // 
            this.lblScore2.Location = new System.Drawing.Point(63, 90);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(123, 27);
            this.lblScore2.TabIndex = 1;
            this.lblScore2.Text = "Score2:";
            // 
            // lblScore3
            // 
            this.lblScore3.Location = new System.Drawing.Point(63, 128);
            this.lblScore3.Name = "lblScore3";
            this.lblScore3.Size = new System.Drawing.Size(123, 23);
            this.lblScore3.TabIndex = 2;
            this.lblScore3.Text = "Score3:";
            // 
            // lblAverage
            // 
            this.lblAverage.Location = new System.Drawing.Point(77, 165);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(84, 61);
            this.lblAverage.TabIndex = 3;
            this.lblAverage.Text = "Average:";
            this.lblAverage.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(183, 165);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(187, 61);
            this.lbloutput.TabIndex = 4;
            // 
            // txtscore1
            // 
            this.txtscore1.Location = new System.Drawing.Point(145, 55);
            this.txtscore1.Name = "txtscore1";
            this.txtscore1.Size = new System.Drawing.Size(270, 26);
            this.txtscore1.TabIndex = 5;
            this.txtscore1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtScor2
            // 
            this.txtScor2.Location = new System.Drawing.Point(145, 87);
            this.txtScor2.Name = "txtScor2";
            this.txtScor2.Size = new System.Drawing.Size(270, 26);
            this.txtScor2.TabIndex = 6;
            // 
            // txtScore3
            // 
            this.txtScore3.Location = new System.Drawing.Point(145, 122);
            this.txtScore3.Name = "txtScore3";
            this.txtScore3.Size = new System.Drawing.Size(270, 26);
            this.txtScore3.TabIndex = 7;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(206, 307);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(158, 97);
            this.btncalculate.TabIndex = 1;
            this.btncalculate.Text = "Calculate Avrage";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(396, 307);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(158, 47);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "Clea&r ";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(396, 358);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(158, 46);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtScore3;
        private System.Windows.Forms.TextBox txtScor2;
        private System.Windows.Forms.TextBox txtscore1;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblScore3;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

