using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DecryptFileBtn_Click(object sender, EventArgs e)
        {
            if (encryptedFile.Text.Contains(" much ") == true)
            {
                string a = "working";
                decryptedFile.Items.Add(a);

            }
            else
            {
                string b = "asd";
                decryptedFile.Items.Add(b);
            }
        }

        private void UploadFileBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog browse = new OpenFileDialog();
                browse.ShowDialog();
                if (browse.ShowDialog() == DialogResult.OK)
                {
                    filePath.Text = browse.FileName;
                }
            }
            catch
            {

            }
        }

        private void LoadFileBtn_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    string[] lines = System.IO.File.ReadAllLines(filePath.Text.Trim());

                    foreach (string line in lines)
                    {
                        encryptedFile.Items.Add(line);
                    }
                }
                catch
                {

                }
            }
            catch
            {

            }

        }
    }
}
