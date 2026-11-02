namespace Assament_file_qeybta_2
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
            this.btncreate = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnopenfiledialog = new System.Windows.Forms.Button();
            this.btnsavefiledialog = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(50, 77);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(204, 87);
            this.btncreate.TabIndex = 0;
            this.btncreate.Text = "Create";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // btnopenfiledialog
            // 
            this.btnopenfiledialog.Location = new System.Drawing.Point(345, 77);
            this.btnopenfiledialog.Name = "btnopenfiledialog";
            this.btnopenfiledialog.Size = new System.Drawing.Size(229, 118);
            this.btnopenfiledialog.TabIndex = 1;
            this.btnopenfiledialog.Text = "Openfiledialog";
            this.btnopenfiledialog.UseVisualStyleBackColor = true;
            this.btnopenfiledialog.Click += new System.EventHandler(this.btnopenfiledialog_Click);
            // 
            // btnsavefiledialog
            // 
            this.btnsavefiledialog.Location = new System.Drawing.Point(131, 254);
            this.btnsavefiledialog.Name = "btnsavefiledialog";
            this.btnsavefiledialog.Size = new System.Drawing.Size(239, 95);
            this.btnsavefiledialog.TabIndex = 2;
            this.btnsavefiledialog.Text = "Savefiledialog";
            this.btnsavefiledialog.UseVisualStyleBackColor = true;
            this.btnsavefiledialog.Click += new System.EventHandler(this.btnsavefiledialog_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(676, 11);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(414, 504);
            this.listBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 435);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(502, 61);
            this.textBox1.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 586);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnsavefiledialog);
            this.Controls.Add(this.btnopenfiledialog);
            this.Controls.Add(this.btncreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncreate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnopenfiledialog;
        private System.Windows.Forms.Button btnsavefiledialog;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

