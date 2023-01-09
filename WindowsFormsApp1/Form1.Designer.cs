namespace WindowsFormsApp1
{
    partial class Karaoke
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Karaoke));
            this.bPlay = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.textMusic = new System.Windows.Forms.RichTextBox();
            this.songTime = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.changeSong = new System.Windows.Forms.ToolStripMenuItem();
            this.dzisiajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cichaNocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przybieżeliDoBetlejemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectSong = new System.Windows.Forms.ToolStripMenuItem();
            this.selectText = new System.Windows.Forms.ToolStripMenuItem();
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            this.nameSong = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bPlay
            // 
            this.bPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bPlay.Image = ((System.Drawing.Image)(resources.GetObject("bPlay.Image")));
            this.bPlay.Location = new System.Drawing.Point(0, 365);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(76, 85);
            this.bPlay.TabIndex = 7;
            this.bPlay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bPlay.UseVisualStyleBackColor = true;
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // bStop
            // 
            this.bStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bStop.Image = ((System.Drawing.Image)(resources.GetObject("bStop.Image")));
            this.bStop.Location = new System.Drawing.Point(76, 365);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(78, 85);
            this.bStop.TabIndex = 6;
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // textMusic
            // 
            this.textMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMusic.ForeColor = System.Drawing.Color.Wheat;
            this.textMusic.Location = new System.Drawing.Point(0, 31);
            this.textMusic.Name = "textMusic";
            this.textMusic.ReadOnly = true;
            this.textMusic.Size = new System.Drawing.Size(751, 328);
            this.textMusic.TabIndex = 5;
            this.textMusic.Text = "";
            this.textMusic.ZoomFactor = 2F;
            // 
            // songTime
            // 
            this.songTime.Enabled = true;
            this.songTime.Interval = 1000;
            this.songTime.Tick += new System.EventHandler(this.songTime_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.progressBar1.ForeColor = System.Drawing.Color.Indigo;
            this.progressBar1.Location = new System.Drawing.Point(160, 412);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(575, 22);
            this.progressBar1.TabIndex = 10;
            // 
            // menu
            // 
            this.menu.GripMargin = new System.Windows.Forms.Padding(2);
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeSong,
            this.selectSong,
            this.selectText});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(747, 28);
            this.menu.TabIndex = 11;
            this.menu.Text = "menuStrip1";
            // 
            // changeSong
            // 
            this.changeSong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dzisiajToolStripMenuItem,
            this.cichaNocToolStripMenuItem,
            this.przybieżeliDoBetlejemToolStripMenuItem});
            this.changeSong.Name = "changeSong";
            this.changeSong.Size = new System.Drawing.Size(111, 26);
            this.changeSong.Text = "Change Song";
            // 
            // dzisiajToolStripMenuItem
            // 
            this.dzisiajToolStripMenuItem.Name = "dzisiajToolStripMenuItem";
            this.dzisiajToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.dzisiajToolStripMenuItem.Text = "Dzisiaj w Betleem";
            this.dzisiajToolStripMenuItem.Click += new System.EventHandler(this.dzisiajToolStripMenuItem_Click);
            // 
            // cichaNocToolStripMenuItem
            // 
            this.cichaNocToolStripMenuItem.Name = "cichaNocToolStripMenuItem";
            this.cichaNocToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.cichaNocToolStripMenuItem.Text = "Cicha noc";
            this.cichaNocToolStripMenuItem.Click += new System.EventHandler(this.cichaNocToolStripMenuItem_Click);
            // 
            // przybieżeliDoBetlejemToolStripMenuItem
            // 
            this.przybieżeliDoBetlejemToolStripMenuItem.Name = "przybieżeliDoBetlejemToolStripMenuItem";
            this.przybieżeliDoBetlejemToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.przybieżeliDoBetlejemToolStripMenuItem.Text = "Przybieżeli do Betlejem";
            this.przybieżeliDoBetlejemToolStripMenuItem.Click += new System.EventHandler(this.przybieżeliDoBetlejemToolStripMenuItem_Click);
            // 
            // selectSong
            // 
            this.selectSong.Name = "selectSong";
            this.selectSong.Size = new System.Drawing.Size(101, 26);
            this.selectSong.Text = "Select Song";
            this.selectSong.Click += new System.EventHandler(this.selectSongToolStripMenuItem_Click);
            // 
            // selectText
            // 
            this.selectText.Name = "selectText";
            this.selectText.Size = new System.Drawing.Size(94, 26);
            this.selectText.Text = "Select Text";
            this.selectText.Click += new System.EventHandler(this.selectTextToolStripMenuItem_Click);
            // 
            // timerProgress
            // 
            this.timerProgress.Enabled = true;
            this.timerProgress.Interval = 1000;
            this.timerProgress.Tick += new System.EventHandler(this.timerProgress_Tick);
            // 
            // nameSong
            // 
            this.nameSong.AutoSize = true;
            this.nameSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameSong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameSong.Location = new System.Drawing.Point(228, 365);
            this.nameSong.Name = "nameSong";
            this.nameSong.Size = new System.Drawing.Size(0, 29);
            this.nameSong.TabIndex = 12;
            // 
            // Karaoke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(747, 446);
            this.Controls.Add(this.nameSong);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textMusic);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bPlay);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menu;
            this.MaximumSize = new System.Drawing.Size(769, 497);
            this.MinimumSize = new System.Drawing.Size(769, 497);
            this.Name = "Karaoke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bPlay;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.RichTextBox textMusic;
        private System.Windows.Forms.Timer songTime;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem changeSong;
        private System.Windows.Forms.ToolStripMenuItem selectSong;
        private System.Windows.Forms.ToolStripMenuItem selectText;
        private System.Windows.Forms.ToolStripMenuItem dzisiajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cichaNocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przybieżeliDoBetlejemToolStripMenuItem;
        private System.Windows.Forms.Timer timerProgress;
        private System.Windows.Forms.Label nameSong;
    }
}

