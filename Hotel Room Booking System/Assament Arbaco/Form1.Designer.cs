namespace Assament_Arbaco
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
            this.grouppersonal = new System.Windows.Forms.GroupBox();
            this.txtnumberofguest = new System.Windows.Forms.TextBox();
            this.lblnumberofguest = new System.Windows.Forms.Label();
            this.txtnumberofnights = new System.Windows.Forms.TextBox();
            this.lblguestname = new System.Windows.Forms.Label();
            this.txtguestage = new System.Windows.Forms.TextBox();
            this.lblnumberofnights = new System.Windows.Forms.Label();
            this.txtguestname = new System.Windows.Forms.TextBox();
            this.lblguestage = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grouplevels = new System.Windows.Forms.GroupBox();
            this.radiobtnhight = new System.Windows.Forms.RadioButton();
            this.radiobtnnormal = new System.Windows.Forms.RadioButton();
            this.radiobtnstndard = new System.Windows.Forms.RadioButton();
            this.groupoption = new System.Windows.Forms.GroupBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.listBoxDisblay = new System.Windows.Forms.ListBox();
            this.checkbreak = new System.Windows.Forms.CheckBox();
            this.grouppersonal.SuspendLayout();
            this.grouplevels.SuspendLayout();
            this.groupoption.SuspendLayout();
            this.SuspendLayout();
            // 
            // grouppersonal
            // 
            this.grouppersonal.Controls.Add(this.txtnumberofguest);
            this.grouppersonal.Controls.Add(this.lblnumberofguest);
            this.grouppersonal.Controls.Add(this.txtnumberofnights);
            this.grouppersonal.Controls.Add(this.lblguestname);
            this.grouppersonal.Controls.Add(this.txtguestage);
            this.grouppersonal.Controls.Add(this.lblnumberofnights);
            this.grouppersonal.Controls.Add(this.txtguestname);
            this.grouppersonal.Controls.Add(this.lblguestage);
            this.grouppersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grouppersonal.Location = new System.Drawing.Point(42, 27);
            this.grouppersonal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grouppersonal.Name = "grouppersonal";
            this.grouppersonal.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grouppersonal.Size = new System.Drawing.Size(701, 300);
            this.grouppersonal.TabIndex = 0;
            this.grouppersonal.TabStop = false;
            this.grouppersonal.Text = "Personal Information";
            // 
            // txtnumberofguest
            // 
            this.txtnumberofguest.Location = new System.Drawing.Point(289, 250);
            this.txtnumberofguest.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtnumberofguest.Name = "txtnumberofguest";
            this.txtnumberofguest.Size = new System.Drawing.Size(494, 28);
            this.txtnumberofguest.TabIndex = 4;
            // 
            // lblnumberofguest
            // 
            this.lblnumberofguest.AutoSize = true;
            this.lblnumberofguest.Location = new System.Drawing.Point(9, 235);
            this.lblnumberofguest.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblnumberofguest.Name = "lblnumberofguest";
            this.lblnumberofguest.Size = new System.Drawing.Size(179, 22);
            this.lblnumberofguest.TabIndex = 4;
            this.lblnumberofguest.Text = "Number of Guest  :";
            // 
            // txtnumberofnights
            // 
            this.txtnumberofnights.Location = new System.Drawing.Point(289, 187);
            this.txtnumberofnights.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtnumberofnights.Name = "txtnumberofnights";
            this.txtnumberofnights.Size = new System.Drawing.Size(494, 28);
            this.txtnumberofnights.TabIndex = 3;
            // 
            // lblguestname
            // 
            this.lblguestname.AutoSize = true;
            this.lblguestname.Location = new System.Drawing.Point(23, 57);
            this.lblguestname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblguestname.Name = "lblguestname";
            this.lblguestname.Size = new System.Drawing.Size(138, 22);
            this.lblguestname.TabIndex = 1;
            this.lblguestname.Text = "Guest Name  :";
            // 
            // txtguestage
            // 
            this.txtguestage.Location = new System.Drawing.Point(289, 123);
            this.txtguestage.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtguestage.Name = "txtguestage";
            this.txtguestage.Size = new System.Drawing.Size(494, 28);
            this.txtguestage.TabIndex = 2;
            // 
            // lblnumberofnights
            // 
            this.lblnumberofnights.AllowDrop = true;
            this.lblnumberofnights.AutoSize = true;
            this.lblnumberofnights.Location = new System.Drawing.Point(23, 191);
            this.lblnumberofnights.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblnumberofnights.Name = "lblnumberofnights";
            this.lblnumberofnights.Size = new System.Drawing.Size(171, 22);
            this.lblnumberofnights.TabIndex = 3;
            this.lblnumberofnights.Text = "Number of Nights:";
            // 
            // txtguestname
            // 
            this.txtguestname.Location = new System.Drawing.Point(289, 57);
            this.txtguestname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtguestname.Name = "txtguestname";
            this.txtguestname.Size = new System.Drawing.Size(494, 28);
            this.txtguestname.TabIndex = 1;
            // 
            // lblguestage
            // 
            this.lblguestage.AutoSize = true;
            this.lblguestage.Location = new System.Drawing.Point(23, 123);
            this.lblguestage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblguestage.Name = "lblguestage";
            this.lblguestage.Size = new System.Drawing.Size(122, 22);
            this.lblguestage.TabIndex = 2;
            this.lblguestage.Text = "Guest Age  :";
            // 
            // grouplevels
            // 
            this.grouplevels.Controls.Add(this.radiobtnhight);
            this.grouplevels.Controls.Add(this.radiobtnnormal);
            this.grouplevels.Controls.Add(this.radiobtnstndard);
            this.grouplevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grouplevels.Location = new System.Drawing.Point(19, 344);
            this.grouplevels.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grouplevels.Name = "grouplevels";
            this.grouplevels.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grouplevels.Size = new System.Drawing.Size(644, 103);
            this.grouplevels.TabIndex = 1;
            this.grouplevels.TabStop = false;
            this.grouplevels.Text = "Room Type";
            // 
            // radiobtnhight
            // 
            this.radiobtnhight.AutoSize = true;
            this.radiobtnhight.Location = new System.Drawing.Point(406, 49);
            this.radiobtnhight.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radiobtnhight.Name = "radiobtnhight";
            this.radiobtnhight.Size = new System.Drawing.Size(82, 26);
            this.radiobtnhight.TabIndex = 2;
            this.radiobtnhight.TabStop = true;
            this.radiobtnhight.Text = "Hight";
            this.radiobtnhight.UseVisualStyleBackColor = true;
            // 
            // radiobtnnormal
            // 
            this.radiobtnnormal.AutoSize = true;
            this.radiobtnnormal.Location = new System.Drawing.Point(246, 49);
            this.radiobtnnormal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radiobtnnormal.Name = "radiobtnnormal";
            this.radiobtnnormal.Size = new System.Drawing.Size(98, 26);
            this.radiobtnnormal.TabIndex = 1;
            this.radiobtnnormal.TabStop = true;
            this.radiobtnnormal.Text = "Normal";
            this.radiobtnnormal.UseVisualStyleBackColor = true;
            // 
            // radiobtnstndard
            // 
            this.radiobtnstndard.AutoSize = true;
            this.radiobtnstndard.Location = new System.Drawing.Point(82, 49);
            this.radiobtnstndard.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radiobtnstndard.Name = "radiobtnstndard";
            this.radiobtnstndard.Size = new System.Drawing.Size(116, 26);
            this.radiobtnstndard.TabIndex = 0;
            this.radiobtnstndard.TabStop = true;
            this.radiobtnstndard.Text = "Standard";
            this.radiobtnstndard.UseVisualStyleBackColor = true;
            // 
            // groupoption
            // 
            this.groupoption.Controls.Add(this.checkbreak);
            this.groupoption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupoption.Location = new System.Drawing.Point(3, 437);
            this.groupoption.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupoption.Name = "groupoption";
            this.groupoption.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupoption.Size = new System.Drawing.Size(697, 102);
            this.groupoption.TabIndex = 2;
            this.groupoption.TabStop = false;
            this.groupoption.Text = "Aditional Options";
            this.groupoption.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(62, 572);
            this.btncalculate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(137, 48);
            this.btncalculate.TabIndex = 3;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(331, 572);
            this.btnclear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(132, 48);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(579, 572);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 48);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // listBoxDisblay
            // 
            this.listBoxDisblay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDisblay.FormattingEnabled = true;
            this.listBoxDisblay.ItemHeight = 22;
            this.listBoxDisblay.Location = new System.Drawing.Point(764, 120);
            this.listBoxDisblay.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listBoxDisblay.Name = "listBoxDisblay";
            this.listBoxDisblay.Size = new System.Drawing.Size(419, 488);
            this.listBoxDisblay.TabIndex = 6;
            // 
            // checkbreak
            // 
            this.checkbreak.Location = new System.Drawing.Point(112, 32);
            this.checkbreak.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.checkbreak.Name = "checkbreak";
            this.checkbreak.Size = new System.Drawing.Size(854, 66);
            this.checkbreak.TabIndex = 0;
            this.checkbreak.Text = "Breakfast (10 Per Guset Per Nights)";
            this.checkbreak.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1197, 730);
            this.Controls.Add(this.listBoxDisblay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.groupoption);
            this.Controls.Add(this.grouplevels);
            this.Controls.Add(this.grouppersonal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grouppersonal.ResumeLayout(false);
            this.grouppersonal.PerformLayout();
            this.grouplevels.ResumeLayout(false);
            this.grouplevels.PerformLayout();
            this.groupoption.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grouppersonal;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblguestname;
        private System.Windows.Forms.Label lblnumberofnights;
        private System.Windows.Forms.Label lblguestage;
        private System.Windows.Forms.Label lblnumberofguest;
        private System.Windows.Forms.TextBox txtnumberofguest;
        private System.Windows.Forms.TextBox txtnumberofnights;
        private System.Windows.Forms.TextBox txtguestage;
        private System.Windows.Forms.TextBox txtguestname;
        private System.Windows.Forms.GroupBox grouplevels;
        private System.Windows.Forms.RadioButton radiobtnnormal;
        private System.Windows.Forms.RadioButton radiobtnstndard;
        private System.Windows.Forms.RadioButton radiobtnhight;
        private System.Windows.Forms.GroupBox groupoption;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox listBoxDisblay;
        private System.Windows.Forms.CheckBox checkbreak;
    }
}

