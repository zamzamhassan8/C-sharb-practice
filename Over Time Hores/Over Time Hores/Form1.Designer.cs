namespace Over_Time_Hores
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
            this.lblhoursworked = new System.Windows.Forms.Label();
            this.lblhourlypay = new System.Windows.Forms.Label();
            this.lblgroospay = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.txthours = new System.Windows.Forms.TextBox();
            this.txthourly = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblhoursworked
            // 
            this.lblhoursworked.Location = new System.Drawing.Point(127, 106);
            this.lblhoursworked.Name = "lblhoursworked";
            this.lblhoursworked.Size = new System.Drawing.Size(146, 23);
            this.lblhoursworked.TabIndex = 0;
            this.lblhoursworked.Text = "Hours Worked:";
            this.lblhoursworked.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblhourlypay
            // 
            this.lblhourlypay.Location = new System.Drawing.Point(127, 149);
            this.lblhourlypay.Name = "lblhourlypay";
            this.lblhourlypay.Size = new System.Drawing.Size(146, 42);
            this.lblhourlypay.TabIndex = 1;
            this.lblhourlypay.Text = "Hourly Pay Rate:";
            // 
            // lblgroospay
            // 
            this.lblgroospay.Location = new System.Drawing.Point(148, 192);
            this.lblgroospay.Name = "lblgroospay";
            this.lblgroospay.Size = new System.Drawing.Size(150, 52);
            this.lblgroospay.TabIndex = 2;
            this.lblgroospay.Text = "Groos Pay:";
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(254, 191);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(188, 51);
            this.lbloutput.TabIndex = 3;
            // 
            // txthours
            // 
            this.txthours.Location = new System.Drawing.Point(258, 103);
            this.txthours.Name = "txthours";
            this.txthours.Size = new System.Drawing.Size(212, 26);
            this.txthours.TabIndex = 4;
            // 
            // txthourly
            // 
            this.txthourly.Location = new System.Drawing.Point(258, 147);
            this.txthourly.Name = "txthourly";
            this.txthourly.Size = new System.Drawing.Size(212, 26);
            this.txthourly.TabIndex = 5;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(104, 266);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(148, 76);
            this.btncalculate.TabIndex = 6;
            this.btncalculate.Text = "Calculate Gross Pay";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(258, 266);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(148, 76);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "Clea&r";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(412, 266);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(148, 76);
            this.btnexit.TabIndex = 8;
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
            this.Controls.Add(this.txthourly);
            this.Controls.Add(this.txthours);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lblgroospay);
            this.Controls.Add(this.lblhourlypay);
            this.Controls.Add(this.lblhoursworked);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhoursworked;
        private System.Windows.Forms.Label lblhourlypay;
        private System.Windows.Forms.Label lblgroospay;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.TextBox txthours;
        private System.Windows.Forms.TextBox txthourly;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

