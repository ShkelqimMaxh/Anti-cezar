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
            char Cipher(char ch, int key)
            {
                if (!char.IsLetter(ch))
                    return ch;

                char offset = char.IsUpper(ch) ? 'A' : 'a';
                return (char)((((ch + key) - offset) % 26) + offset);
            }

            string Encipher(string input, int key)
            {
                string output = string.Empty;

                foreach (char ch in input)
                    output += Cipher(ch, key);

                return output;
            }
            string textCezar = System.IO.File.ReadAllText(filePath.Text);

            if (encryptedFile.Text.Contains(" OF ") == true || encryptedFile.Text.Contains(" UT "))
            {
                int shtyerja = 1;


                decryptedFile.Text = Encipher(textCezar, 26-int);

            }
            else if (...)
            {
               ...

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
                    string lines = System.IO.File.ReadAllText(filePath.Text);

                    encryptedFile.Text = lines;
                }
                catch
                {

                }
            }
            catch
            {

            }

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
