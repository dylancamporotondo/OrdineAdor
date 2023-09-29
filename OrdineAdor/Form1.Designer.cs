
namespace OrdineAdor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_Desktop = new System.Windows.Forms.Button();
            this.button_Documents = new System.Windows.Forms.Button();
            this.button_Pictures = new System.Windows.Forms.Button();
            this.button_Music = new System.Windows.Forms.Button();
            this.button_Videos = new System.Windows.Forms.Button();
            this.panel_FilesList = new System.Windows.Forms.FlowLayoutPanel();
            this.back_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.quit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Desktop
            // 
            this.button_Desktop.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.button_Desktop, "button_Desktop");
            this.button_Desktop.Name = "button_Desktop";
            this.button_Desktop.UseVisualStyleBackColor = false;
            this.button_Desktop.Click += new System.EventHandler(this.button_Desktop_Click);
            // 
            // button_Documents
            // 
            this.button_Documents.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.button_Documents, "button_Documents");
            this.button_Documents.Name = "button_Documents";
            this.button_Documents.UseVisualStyleBackColor = false;
            this.button_Documents.Click += new System.EventHandler(this.button_Documents_Click);
            // 
            // button_Pictures
            // 
            this.button_Pictures.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.button_Pictures, "button_Pictures");
            this.button_Pictures.Name = "button_Pictures";
            this.button_Pictures.UseVisualStyleBackColor = false;
            this.button_Pictures.Click += new System.EventHandler(this.button_Pictures_Click);
            // 
            // button_Music
            // 
            this.button_Music.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.button_Music, "button_Music");
            this.button_Music.Name = "button_Music";
            this.button_Music.UseVisualStyleBackColor = false;
            this.button_Music.Click += new System.EventHandler(this.button_Music_Click);
            // 
            // button_Videos
            // 
            this.button_Videos.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.button_Videos, "button_Videos");
            this.button_Videos.Name = "button_Videos";
            this.button_Videos.UseVisualStyleBackColor = false;
            this.button_Videos.Click += new System.EventHandler(this.button_Videos_Click);
            // 
            // panel_FilesList
            // 
            resources.ApplyResources(this.panel_FilesList, "panel_FilesList");
            this.panel_FilesList.Name = "panel_FilesList";
            this.panel_FilesList.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_FilesList_Paint);
            // 
            // back_button
            // 
            resources.ApplyResources(this.back_button, "back_button");
            this.back_button.Name = "back_button";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // quit_Button
            // 
            this.quit_Button.BackColor = System.Drawing.Color.IndianRed;
            resources.ApplyResources(this.quit_Button, "quit_Button");
            this.quit_Button.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.quit_Button.Name = "quit_Button";
            this.quit_Button.UseVisualStyleBackColor = false;
            this.quit_Button.Click += new System.EventHandler(this.quit_Button_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ControlBox = false;
            this.Controls.Add(this.quit_Button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.panel_FilesList);
            this.Controls.Add(this.button_Videos);
            this.Controls.Add(this.button_Music);
            this.Controls.Add(this.button_Pictures);
            this.Controls.Add(this.button_Documents);
            this.Controls.Add(this.button_Desktop);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Desktop;
        private System.Windows.Forms.Button button_Documents;
        private System.Windows.Forms.Button button_Pictures;
        private System.Windows.Forms.Button button_Music;
        private System.Windows.Forms.Button button_Videos;
        private System.Windows.Forms.FlowLayoutPanel panel_FilesList;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button quit_Button;
    }
}

