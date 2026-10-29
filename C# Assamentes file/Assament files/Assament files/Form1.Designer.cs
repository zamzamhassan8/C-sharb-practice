namespace Assament_files
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
            this.btnDelatefile = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCreatefile = new System.Windows.Forms.Button();
            this.btnitemfile = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnReadother = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDelatefile
            // 
            this.btnDelatefile.Location = new System.Drawing.Point(36, 260);
            this.btnDelatefile.Name = "btnDelatefile";
            this.btnDelatefile.Size = new System.Drawing.Size(166, 70);
            this.btnDelatefile.TabIndex = 0;
            this.btnDelatefile.Text = "Delate file";
            this.btnDelatefile.UseVisualStyleBackColor = true;
            this.btnDelatefile.Click += new System.EventHandler(this.btnDelatefile_Click);
            // 
            // btnCreatefile
            // 
            this.btnCreatefile.Location = new System.Drawing.Point(60, 74);
            this.btnCreatefile.Name = "btnCreatefile";
            this.btnCreatefile.Size = new System.Drawing.Size(174, 70);
            this.btnCreatefile.TabIndex = 1;
            this.btnCreatefile.Text = "Create New file";
            this.btnCreatefile.UseVisualStyleBackColor = true;
            this.btnCreatefile.Click += new System.EventHandler(this.btnCreatefile_Click);
            // 
            // btnitemfile
            // 
            this.btnitemfile.Location = new System.Drawing.Point(306, 260);
            this.btnitemfile.Name = "btnitemfile";
            this.btnitemfile.Size = new System.Drawing.Size(186, 70);
            this.btnitemfile.TabIndex = 2;
            this.btnitemfile.Text = "Delate  the item file";
            this.btnitemfile.UseVisualStyleBackColor = true;
            this.btnitemfile.Click += new System.EventHandler(this.btnitemfile_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(748, 8);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(354, 544);
            this.listBox.TabIndex = 3;
            // 
            // btnReadother
            // 
            this.btnReadother.Location = new System.Drawing.Point(318, 74);
            this.btnReadother.Name = "btnReadother";
            this.btnReadother.Size = new System.Drawing.Size(269, 91);
            this.btnReadother.TabIndex = 4;
            this.btnReadother.Text = "Read other function";
            this.btnReadother.UseVisualStyleBackColor = true;
            this.btnReadother.Click += new System.EventHandler(this.btnReadUsing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 561);
            this.Controls.Add(this.btnReadother);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnitemfile);
            this.Controls.Add(this.btnCreatefile);
            this.Controls.Add(this.btnDelatefile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelatefile;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCreatefile;
        private System.Windows.Forms.Button btnitemfile;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnReadother;
    }
}

