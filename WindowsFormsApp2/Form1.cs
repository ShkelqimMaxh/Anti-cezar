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
            string textCezar = System.IO.File.ReadAllText(filePath.Text).ToUpper();

            if (encryptedFile.Text.Contains(" OF ") == true || encryptedFile.Text.Contains(" UT "))
            {
                int shtyerja = 1;


                decryptedFile.Text = Encipher(textCezar, 26 - shtyerja );

            }
            else if (encryptedFile.Text.Contains(" PG ") == true || encryptedFile.Text.Contains(" VG "))
            {
                int shtyerja = 2;

                decryptedFile.Text = Encipher(textCezar, 26 - shtyerja);

            }
            else if (encryptedFile.Text.Contains(" QH ") == true || encryptedFile.Text.Contains(" WH "))
            {
                int shtyerja = 3;

                decryptedFile.Text = Encipher(textCezar, 26 - shtyerja);

            }
            else if (encryptedFile.Text.Contains(" RI ") == true || encryptedFile.Text.Contains(" XI "))
            {

                int shtyerja = 4;

                decryptedFile.Text = Encipher(textCezar, 26 - shtyerja);
            }
            else if (encryptedFile.Text.Contains(" SJ ") == true || encryptedFile.Text.Contains(" YJ "))
            {
                int shtyerja = 5;

                decryptedFile.Text = Encipher(textCezar, 26 - shtyerja);
            }
            else if (encryptedFile.Text.Contains(" TK ") == true || encryptedFile.Text.Contains(" ZK "))
            {
                int shtyerja = 6;

                decryptedFile.Text = Encipher(textCezar, 26 - shtyerja);
            }
            else if (encryptedFile.Text.Contains(" UL ") == true || encryptedFile.Text.Contains(" AL "))
            {
                int shtyerja = 7;

                decryptedFile.Text = Encipher(textCezar, 26 - shtyerja);

            }
            else if (encryptedFile.Text.Contains(" VM ") == true || encryptedFile.Text.Contains(" BM "))
            {
                int shtyerja = 8;

                decryptedFile.Text = Encipher(textCezar, 26 - shtyerja);

            }
            else if (encryptedFile.Text.Contains(" WN ") == true || encryptedFile.Text.Contains(" CN "))
            {
                int shtyerja = 9;

                decryptedFile.Text = Encipher(textCezar, 26 - shtyerja);
            }
            else if (encryptedFile.Text.Contains(" XO ") == true || encryptedFile.Text.Contains(" DO "))
            {
                int shtyerja = 10;

                decryptedFile.Text = Encipher(textCezar, 26 - shtyerja);
            }
            else if (encryptedFile.Text.Contains(" YP ") == true || encryptedFile.Text.Contains(" EP "))
            {
                int shtyerja = 11;

                decryptedFile.Text = Encipher(textCezar, 26 - shtyerja);
            }
            else if (encryptedFile.Text.Contains(" ZQ ") == true || encryptedFile.Text.Contains(" FQ "))
            {
                int shtyerja = 12;

                decryptedFile.Text = Encipher(textCezar, 26 - shtyerja);
            }
            else if (encryptedFile.Text.Contains(" AR ") == true || encryptedFile.Text.Contains(" GR "))
            {
                int shtyerja = 13;

                decryptedFile.Text = Encipher(textCezar, 26 - shtyerja);
            }
            else if (encryptedFile.Text.Contains(" BS ") == true || encryptedFile.Text.Contains(" HS "))
            {
                int shtyerja = 14;

                decryptedFile.Text = Encipher(textCezar, 26 - shtyerja);
            }
            else if (encryptedFile.Text.Contains(" CT ") == true || encryptedFile.Text.Contains(" IT "))
            {
                int shtyerja = 15;

                decryptedFile.Text = Encipher(textCezar, 26 - shtyerja);
            }
            else if (encryptedFile.Text.Contains(" DU ") == true || encryptedFile.Text.Contains(" JU "))
            {
                int shtyerja = 16;

                decryptedFile.Text = Encipher(textCezar, 26 - shtyerja);
            }
            else if (encryptedFile.Text.Contains(" EV ") == true || encryptedFile.Text.Contains(" KV "))
            {
                int shtyerja = 17;

                decryptedFile.Text = Encipher(textCezar, 26 - shtyerja);
            }
            else if (encryptedFile.Text.Contains(" FW ") == true || encryptedFile.Text.Contains(" LW "))
            {
                int shtyerja = 18;

                decryptedFile.Text = Encipher(textCezar, 26 - shtyerja);
            }
            else if (encryptedFile.Text.Contains(" GX ") == true || encryptedFile.Text.Contains(" MX "))
            {

                int shtyerja = 19;

                decryptedFile.Text = Encipher(textCezar, 26 - shtyerja);
            }
            else if (encryptedFile.Text.Contains(" HY ") == true || encryptedFile.Text.Contains(" NY "))
            {
                int shtyerja = 20;

                decryptedFile.Text = Encipher(textCezar, 26 - shtyerja);
            }
            else if (encryptedFile.Text.Contains(" IZ ") == true || encryptedFile.Text.Contains(" OZ "))
            {
                int shtyerja = 21;

                decryptedFile.Text = Encipher(textCezar, 26 - shtyerja);
            }
            else if (encryptedFile.Text.Contains(" JA ") == true || encryptedFile.Text.Contains(" PA "))
            {
                int shtyerja = 22;

                decryptedFile.Text = Encipher(textCezar, 26 - shtyerja);
            }
            else if (encryptedFile.Text.Contains(" KB ") == true || encryptedFile.Text.Contains(" QB "))
            {
                int shtyerja = 23;


                decryptedFile.Text = Encipher(textCezar, 26 - shtyerja);
            }
            else if (encryptedFile.Text.Contains(" LC ") == true || encryptedFile.Text.Contains(" RC "))
            {
                int shtyerja = 24;

                decryptedFile.Text = Encipher(textCezar, 26 - shtyerja);
            }
            else if (encryptedFile.Text.Contains(" MD ") == true || encryptedFile.Text.Contains(" SD "))
            {
                int shtyerja = 25;

                decryptedFile.Text = Encipher(textCezar, 26 - shtyerja);
            }
            else if (encryptedFile.Text.Contains(" NE ") == true || encryptedFile.Text.Contains(" TE "))
            {
                int shtyerja = 26;

                decryptedFile.Text = Encipher(textCezar, 26 - shtyerja);
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

                    encryptedFile.Text = lines.ToUpper();
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
