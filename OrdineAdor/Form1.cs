using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OrdineAdor
{
    public partial class Form1 : Form
    {
        private void DisplayFiles(string filePath)
        {
            // prova
        }
        public Form1()
        {
            InitializeComponent();
            DisplayFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }

        private void button_Desktop_Click(object sender, EventArgs e)
        {
            DisplayFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }

        private void button_Documents_Click(object sender, EventArgs e)
        {
            DisplayFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        }

        private void button_Videos_Click(object sender, EventArgs e)
        {
            DisplayFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
        }

        private void button_Music_Click(object sender, EventArgs e)
        {
            DisplayFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
        }

        private void button_Pictures_Click(object sender, EventArgs e)
        {
            DisplayFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
        }
    }
}
