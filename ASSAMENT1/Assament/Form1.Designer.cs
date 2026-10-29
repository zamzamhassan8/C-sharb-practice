namespace Assament
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.txtsemester = new System.Windows.Forms.TextBox();
            this.lblstudentname = new System.Windows.Forms.Label();
            this.lblstudentID = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.lblsemester = new System.Windows.Forms.Label();
            this.bttshowinfo = new System.Windows.Forms.Button();
            this.bttclear = new System.Windows.Forms.Button();
            this.lblshowinfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(354, 43);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(264, 26);
            this.txtname.TabIndex = 4;
            // 
            // txtstudentid
            // 
            this.txtstudentid.Location = new System.Drawing.Point(354, 130);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(264, 26);
            this.txtstudentid.TabIndex = 5;
            // 
            // txtdepartment
            // 
            this.txtdepartment.Location = new System.Drawing.Point(354, 209);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(271, 26);
            this.txtdepartment.TabIndex = 6;
            // 
            // txtsemester
            // 
            this.txtsemester.Location = new System.Drawing.Point(354, 287);
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(271, 26);
            this.txtsemester.TabIndex = 7;
            // 
            // lblstudentname
            // 
            this.lblstudentname.AutoSize = true;
            this.lblstudentname.Location = new System.Drawing.Point(131, 49);
            this.lblstudentname.Name = "lblstudentname";
            this.lblstudentname.Size = new System.Drawing.Size(162, 20);
            this.lblstudentname.TabIndex = 8;
            this.lblstudentname.Text = "Enter student name  :";
            // 
            // lblstudentID
            // 
            this.lblstudentID.AutoSize = true;
            this.lblstudentID.Location = new System.Drawing.Point(137, 136);
            this.lblstudentID.Name = "lblstudentID";
            this.lblstudentID.Size = new System.Drawing.Size(139, 20);
            this.lblstudentID.TabIndex = 9;
            this.lblstudentID.Text = "Enter student ID  :";
            // 
            // lbldepartment
            // 
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.Location = new System.Drawing.Point(137, 228);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(146, 20);
            this.lbldepartment.TabIndex = 10;
            this.lbldepartment.Text = "Enter department  :";
            // 
            // lblsemester
            // 
            this.lblsemester.AutoSize = true;
            this.lblsemester.Location = new System.Drawing.Point(146, 305);
            this.lblsemester.Name = "lblsemester";
            this.lblsemester.Size = new System.Drawing.Size(130, 20);
            this.lblsemester.TabIndex = 11;
            this.lblsemester.Text = "Enter semester  :";
            // 
            // bttshowinfo
            // 
            this.bttshowinfo.Location = new System.Drawing.Point(135, 448);
            this.bttshowinfo.Name = "bttshowinfo";
            this.bttshowinfo.Size = new System.Drawing.Size(152, 64);
            this.bttshowinfo.TabIndex = 13;
            this.bttshowinfo.Text = "Show info";
            this.bttshowinfo.UseVisualStyleBackColor = true;
            this.bttshowinfo.Click += new System.EventHandler(this.bttshowinfo_Click);
            // 
            // bttclear
            // 
            this.bttclear.Location = new System.Drawing.Point(466, 448);
            this.bttclear.Name = "bttclear";
            this.bttclear.Size = new System.Drawing.Size(152, 64);
            this.bttclear.TabIndex = 14;
            this.bttclear.Text = "Clear";
            this.bttclear.UseVisualStyleBackColor = true;
            this.bttclear.Click += new System.EventHandler(this.bttclear_Click);
            // 
            // lblshowinfo
            // 
            this.lblshowinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblshowinfo.Location = new System.Drawing.Point(150, 352);
            this.lblshowinfo.Name = "lblshowinfo";
            this.lblshowinfo.Size = new System.Drawing.Size(495, 77);
            this.lblshowinfo.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 524);
            this.Controls.Add(this.lblshowinfo);
            this.Controls.Add(this.bttclear);
            this.Controls.Add(this.bttshowinfo);
            this.Controls.Add(this.lblsemester);
            this.Controls.Add(this.lbldepartment);
            this.Controls.Add(this.lblstudentID);
            this.Controls.Add(this.lblstudentname);
            this.Controls.Add(this.txtsemester);
            this.Controls.Add(this.txtdepartment);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.TextBox txtsemester;
        private System.Windows.Forms.Label lblstudentname;
        private System.Windows.Forms.Label lblstudentID;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label lblsemester;
        private System.Windows.Forms.Button bttshowinfo;
        private System.Windows.Forms.Button bttclear;
        private System.Windows.Forms.Label lblshowinfo;
    }
}

