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
            this.bPathText = new System.Windows.Forms.Button();
            this.bPathMusic = new System.Windows.Forms.Button();
            this.textMusic = new System.Windows.Forms.RichTextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.songTime = new System.Windows.Forms.Timer(this.components);
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
            // bPathText
            // 
            this.bPathText.BackColor = System.Drawing.Color.Gray;
            this.bPathText.Location = new System.Drawing.Point(661, 377);
            this.bPathText.Name = "bPathText";
            this.bPathText.Size = new System.Drawing.Size(78, 61);
            this.bPathText.TabIndex = 3;
            this.bPathText.Text = "Text";
            this.bPathText.UseVisualStyleBackColor = false;
            this.bPathText.Click += new System.EventHandler(this.bPathText_Click);
            // 
            // bPathMusic
            // 
            this.bPathMusic.BackColor = System.Drawing.Color.Gray;
            this.bPathMusic.Location = new System.Drawing.Point(577, 377);
            this.bPathMusic.Name = "bPathMusic";
            this.bPathMusic.Size = new System.Drawing.Size(78, 61);
            this.bPathMusic.TabIndex = 4;
            this.bPathMusic.Text = "Music";
            this.bPathMusic.UseVisualStyleBackColor = false;
            this.bPathMusic.Click += new System.EventHandler(this.bPathMusic_Click);
            // 
            // textMusic
            // 
            this.textMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMusic.ForeColor = System.Drawing.Color.White;
            this.textMusic.Location = new System.Drawing.Point(0, 0);
            this.textMusic.Name = "textMusic";
            this.textMusic.ReadOnly = true;
            this.textMusic.Size = new System.Drawing.Size(751, 359);
            this.textMusic.TabIndex = 5;
            this.textMusic.Text = "";
            this.textMusic.ZoomFactor = 2F;
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.Color.Gray;
            this.comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Dzisiaj w Betlejem",
            "Cicha noc",
            "Przybieżeli do Betlejem"});
            this.comboBox.Location = new System.Drawing.Point(355, 377);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(194, 24);
            this.comboBox.TabIndex = 8;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // songTime
            // 
            this.songTime.Enabled = true;
            this.songTime.Interval = 1000;
            this.songTime.Tick += new System.EventHandler(this.songTime_Tick);
            // 
            // Karaoke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(751, 450);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.textMusic);
            this.Controls.Add(this.bPathMusic);
            this.Controls.Add(this.bPathText);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bPlay);
            this.MaximumSize = new System.Drawing.Size(769, 497);
            this.MinimumSize = new System.Drawing.Size(769, 497);
            this.Name = "Karaoke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bPlay;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bPathText;
        private System.Windows.Forms.Button bPathMusic;
        private System.Windows.Forms.RichTextBox textMusic;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Timer songTime;
    }
}

