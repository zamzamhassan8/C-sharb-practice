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

namespace Assament_files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreatefile_Click(object sender, EventArgs e)
        {
            //creating file to use it to read
            //import class
            StreamWriter myfile;
            //creating the file
            myfile = File.CreateText("Test.txt");
            //process to rhiht in the file
            myfile.WriteLine("my name is zamzam Hassan Ahmed");
            myfile.WriteLine("Iam student at jumhuria university my fucalt is IT bachular computer Application");
            myfile.WriteLine("My Age is 20");

            //colsing the file
            myfile.Close();
            //message to know the file is creating
            MessageBox.Show("secceful creating the file.");

        }

        private void btnReadUsing_Click(object sender, EventArgs e)
        {

            try
            {
                string filePath = "Test.txt";

                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);

                    listBox.Items.Clear();
                    foreach (string line in lines)
                    {
                        listBox.Items.Add(line);
                    }
                    MessageBox.Show("Feylka waxaa lagu akhriyay habka cusub ee File.ReadAllLines()!");
                }
                else
                {
                    MessageBox.Show("Feylka lama helin! Fadlan marka hore riix badhanka 'Creating New file' si aad u abuurto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnDelatefile_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "Test.txt";

                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    MessageBox.Show("Feylka 'Test.txt' si buuxda ayaa loo tirtiray!");
                    listBox.Items.Clear(); // Safreenna ListBox-ka
                }
                else
                {
                    MessageBox.Show("Feylkan ma jiro ama mar hore ayaa la tirtiray.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnitemfile_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "Test.txt";

                if (listBox.SelectedIndex != -1)
                {
                    listBox.Items.RemoveAt(listBox.SelectedIndex);

                    StreamWriter writer = File.CreateText(filePath);
                    foreach (var item in listBox.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }
                    writer.Close();

                    MessageBox.Show("Item-kii aad dooratay waa la tirtiray, feylkiina waa la cusboonaysiiyay!");
                }
                else
                {
                    MessageBox.Show("Fadlan marka hore ListBox-ka ka dooro item-ka aad rabto inaad tirtirto!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
    }

