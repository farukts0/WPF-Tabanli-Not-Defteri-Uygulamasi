using System;
using System.IO;
using System.Windows.Forms;

namespace NotDefteriUygulamasi
{
    public partial class MainForm : Form
    {
        private string dosyaYolu = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metinAlani.Clear();
            dosyaYolu = "";
        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                dosyaYolu = fileDialog.FileName;
                metinAlani.Text = File.ReadAllText(dosyaYolu);
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dosyaYolu != "")
            {
                File.WriteAllText(dosyaYolu, metinAlani.Text);
            }
            else
            {
                SaveFileDialog fileDialog = new SaveFileDialog();
                fileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    dosyaYolu = fileDialog.FileName;
                    File.WriteAllText(dosyaYolu, metinAlani.Text);
                }
            }
        }

        private void farkliKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                dosyaYolu = fileDialog.FileName;
                File.WriteAllText(dosyaYolu, metinAlani.Text);
            }
        }
    }
}
