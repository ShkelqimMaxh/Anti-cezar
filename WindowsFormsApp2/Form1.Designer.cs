namespace WindowsFormsApp2
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
            this.uploadFileBtn = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.TextBox();
            this.loadFileBtn = new System.Windows.Forms.Button();
            this.decryptFileBtn = new System.Windows.Forms.Button();
            this.saveFileBtn = new System.Windows.Forms.Button();
            this.encryptedFile = new System.Windows.Forms.RichTextBox();
            this.decryptedFile = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // uploadFileBtn
            // 
            this.uploadFileBtn.Location = new System.Drawing.Point(33, 27);
            this.uploadFileBtn.Name = "uploadFileBtn";
            this.uploadFileBtn.Size = new System.Drawing.Size(224, 53);
            this.uploadFileBtn.TabIndex = 0;
            this.uploadFileBtn.Text = "Upload a file";
            this.uploadFileBtn.UseVisualStyleBackColor = true;
            this.uploadFileBtn.Click += new System.EventHandler(this.UploadFileBtn_Click);
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(33, 102);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(224, 20);
            this.filePath.TabIndex = 1;
            // 
            // loadFileBtn
            // 
            this.loadFileBtn.Location = new System.Drawing.Point(33, 138);
            this.loadFileBtn.Name = "loadFileBtn";
            this.loadFileBtn.Size = new System.Drawing.Size(224, 37);
            this.loadFileBtn.TabIndex = 2;
            this.loadFileBtn.Text = "Load File";
            this.loadFileBtn.UseVisualStyleBackColor = true;
            this.loadFileBtn.Click += new System.EventHandler(this.LoadFileBtn_Click);
            // 
            // decryptFileBtn
            // 
            this.decryptFileBtn.Location = new System.Drawing.Point(445, 27);
            this.decryptFileBtn.Name = "decryptFileBtn";
            this.decryptFileBtn.Size = new System.Drawing.Size(291, 53);
            this.decryptFileBtn.TabIndex = 3;
            this.decryptFileBtn.Text = "Decrypt file";
            this.decryptFileBtn.UseVisualStyleBackColor = true;
            this.decryptFileBtn.Click += new System.EventHandler(this.DecryptFileBtn_Click);
            // 
            // saveFileBtn
            // 
            this.saveFileBtn.Location = new System.Drawing.Point(534, 319);
            this.saveFileBtn.Name = "saveFileBtn";
            this.saveFileBtn.Size = new System.Drawing.Size(202, 38);
            this.saveFileBtn.TabIndex = 6;
            this.saveFileBtn.Text = "Save File";
            this.saveFileBtn.UseVisualStyleBackColor = true;
            // 
            // encryptedFile
            // 
            this.encryptedFile.Location = new System.Drawing.Point(33, 205);
            this.encryptedFile.Name = "encryptedFile";
            this.encryptedFile.Size = new System.Drawing.Size(224, 152);
            this.encryptedFile.TabIndex = 7;
            this.encryptedFile.Text = "";
            this.encryptedFile.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // decryptedFile
            // 
            this.decryptedFile.Location = new System.Drawing.Point(445, 102);
            this.decryptedFile.Name = "decryptedFile";
            this.decryptedFile.Size = new System.Drawing.Size(291, 176);
            this.decryptedFile.TabIndex = 8;
            this.decryptedFile.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.decryptedFile);
            this.Controls.Add(this.encryptedFile);
            this.Controls.Add(this.saveFileBtn);
            this.Controls.Add(this.decryptFileBtn);
            this.Controls.Add(this.loadFileBtn);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.uploadFileBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadFileBtn;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button loadFileBtn;
        private System.Windows.Forms.Button decryptFileBtn;
        private System.Windows.Forms.Button saveFileBtn;
        private System.Windows.Forms.RichTextBox encryptedFile;
        private System.Windows.Forms.RichTextBox decryptedFile;
    }
}

