namespace kura_cek
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
            this.isimTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.isimEkleButon = new System.Windows.Forms.Button();
            this.asilTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yedekTextBox = new System.Windows.Forms.TextBox();
            this.katilimciListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.asilListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.yedekListBox = new System.Windows.Forms.ListBox();
            this.kuraCekButton = new System.Windows.Forms.Button();
            this.silButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // isimTextBox
            // 
            this.isimTextBox.Location = new System.Drawing.Point(12, 25);
            this.isimTextBox.Name = "isimTextBox";
            this.isimTextBox.Size = new System.Drawing.Size(565, 20);
            this.isimTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim Gir";
            // 
            // isimEkleButon
            // 
            this.isimEkleButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isimEkleButon.Location = new System.Drawing.Point(583, 19);
            this.isimEkleButon.Name = "isimEkleButon";
            this.isimEkleButon.Size = new System.Drawing.Size(75, 30);
            this.isimEkleButon.TabIndex = 2;
            this.isimEkleButon.Text = "EKLE";
            this.isimEkleButon.UseVisualStyleBackColor = true;
            this.isimEkleButon.Click += new System.EventHandler(this.isimEkleButon_Click);
            // 
            // asilTextBox
            // 
            this.asilTextBox.Location = new System.Drawing.Point(12, 70);
            this.asilTextBox.Name = "asilTextBox";
            this.asilTextBox.Size = new System.Drawing.Size(646, 20);
            this.asilTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kaç Kişi Asil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kaç Kişi Yedek";
            // 
            // yedekTextBox
            // 
            this.yedekTextBox.Location = new System.Drawing.Point(12, 115);
            this.yedekTextBox.Name = "yedekTextBox";
            this.yedekTextBox.Size = new System.Drawing.Size(646, 20);
            this.yedekTextBox.TabIndex = 6;
            // 
            // katilimciListBox
            // 
            this.katilimciListBox.FormattingEnabled = true;
            this.katilimciListBox.Location = new System.Drawing.Point(12, 161);
            this.katilimciListBox.Name = "katilimciListBox";
            this.katilimciListBox.Size = new System.Drawing.Size(181, 251);
            this.katilimciListBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Katılımcılar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(199, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Asiller";
            // 
            // asilListBox
            // 
            this.asilListBox.FormattingEnabled = true;
            this.asilListBox.Location = new System.Drawing.Point(199, 161);
            this.asilListBox.Name = "asilListBox";
            this.asilListBox.Size = new System.Drawing.Size(181, 303);
            this.asilListBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(396, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Yedekler";
            // 
            // yedekListBox
            // 
            this.yedekListBox.FormattingEnabled = true;
            this.yedekListBox.Location = new System.Drawing.Point(396, 161);
            this.yedekListBox.Name = "yedekListBox";
            this.yedekListBox.Size = new System.Drawing.Size(181, 303);
            this.yedekListBox.TabIndex = 13;
            // 
            // kuraCekButton
            // 
            this.kuraCekButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.kuraCekButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kuraCekButton.ForeColor = System.Drawing.Color.Black;
            this.kuraCekButton.Location = new System.Drawing.Point(583, 161);
            this.kuraCekButton.Name = "kuraCekButton";
            this.kuraCekButton.Size = new System.Drawing.Size(75, 303);
            this.kuraCekButton.TabIndex = 15;
            this.kuraCekButton.Text = "KURA ÇEK";
            this.kuraCekButton.UseVisualStyleBackColor = false;
            this.kuraCekButton.Click += new System.EventHandler(this.kuraCekButton_Click);
            // 
            // silButon
            // 
            this.silButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.silButon.Location = new System.Drawing.Point(12, 418);
            this.silButon.Name = "silButon";
            this.silButon.Size = new System.Drawing.Size(181, 41);
            this.silButon.TabIndex = 16;
            this.silButon.Text = "SİL";
            this.silButon.UseVisualStyleBackColor = true;
            this.silButon.Click += new System.EventHandler(this.silButon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 471);
            this.Controls.Add(this.silButon);
            this.Controls.Add(this.kuraCekButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.yedekListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.asilListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.katilimciListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yedekTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.asilTextBox);
            this.Controls.Add(this.isimEkleButon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isimTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox isimTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button isimEkleButon;
        private System.Windows.Forms.TextBox asilTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yedekTextBox;
        private System.Windows.Forms.ListBox katilimciListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox asilListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox yedekListBox;
        private System.Windows.Forms.Button kuraCekButton;
        private System.Windows.Forms.Button silButon;
    }
}

