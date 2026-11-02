using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assament_file_qeybta_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            //imprt calass - create newfile
            StreamWriter output;

            //open the file
            //creating new file -create text()
            output = File.CreateText("C:\\Users\\hp\\OneDrive\\Desktop\\zameyy\\Teast.txt");
            //procces file
            //write the file-write or writline
            output.WriteLine(" Class ca242");
            output.WriteLine("jmahuriya universty");
            output.WriteLine("c# progaraming");
            //the close file
            output.Close();
        }

        private void btnopenfiledialog_Click(object sender, EventArgs e)
        {
            StreamReader read;
            DialogResult result;
            result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                read = new StreamReader(openFileDialog1.FileName);
                string lines;
                while (read.EndOfStream == false)
                {
                    lines = read.ReadLine();
                    listBox1.Items.Add(lines);
                }
            }
        }

        private void btnsavefiledialog_Click(object sender, EventArgs e)
        {
            StreamWriter write;
            DialogResult result;
            result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                write = new StreamWriter(saveFileDialog1.FileName);
                write.WriteLine(textBox1.Text);
                write.Close();
                MessageBox.Show("save filed");
            }
        }
    }
}
