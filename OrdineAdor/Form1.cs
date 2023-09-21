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
        string currentLocation = "";

        private void DisplayFiles(string filePath)
        {
            string[] filesList = Directory.GetDirectories(filePath).Concat(Directory.GetFiles(filePath)).ToArray();
            panel_FilesList.Controls.Clear();
            currentLocation = filePath;

            for (int i = 0; i < filesList.Length - 1; i++)
            {
                bool isHidden = ((File.GetAttributes(filesList[i]) & FileAttributes.Hidden) == FileAttributes.Hidden);

                if (!isHidden)
                {
                    // Get the name of the file from the path
                    var startOfName = filesList[i].LastIndexOf("\\");
                    var fileName = filesList[i].Substring(startOfName + 1, filesList[i].Length - (startOfName + 1));

                    // Display the file or folder as a button
                    Button newButton = new Button();
                    newButton.Text = fileName;
                    newButton.Name = filesList[i];
                    newButton.Location = new Point(70, 70);
                    newButton.Size = new Size(800, 100);
                    newButton.TextAlign = ContentAlignment.MiddleLeft;
                    newButton.Padding = new Padding(24, 0, 0, 0);
                    panel_FilesList.Controls.Add(newButton);
                }
            }
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

        private void panel_FilesList_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
