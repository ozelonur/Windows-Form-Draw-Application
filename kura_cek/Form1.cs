using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kura_cek
{
    public partial class Form1 : Form
    {
        static List<string> katilimcilar = new List<string>();
        static List<string> asiller = new List<string>();
        static List<string> yedekler = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void isimEkleButon_Click(object sender, EventArgs e)
        {
            katilimcilar.Add(isimTextBox.Text);
            katilimciListBox.Items.Add(isimTextBox.Text);
            isimTextBox.Clear();
           
        }

        private void silButon_Click(object sender, EventArgs e)
        {
            katilimciListBox.Items.Remove(katilimciListBox.SelectedItem);
            katilimcilar.Remove(katilimciListBox.SelectedItem.ToString());
        }
      
        private void kuraCekButton_Click(object sender, EventArgs e)
        {
            
                Random rand = new Random();
                for (int i = 0; i < (Convert.ToInt32(asilTextBox.Text)); i++)
                {
                    int rasgele = rand.Next(0, katilimcilar.Count);
                    asilListBox.Items.Add(katilimcilar[rasgele]);
                    katilimcilar.RemoveAt(rasgele);
                }

                for (int i = 0; i < (Convert.ToInt32(yedekTextBox.Text)); i++)
                {
                    int rasgele = rand.Next(0, katilimcilar.Count);
                    yedekListBox.Items.Add(katilimcilar[rasgele]);
                    katilimcilar.RemoveAt(rasgele);
                }
            
            
        }
    }
}
