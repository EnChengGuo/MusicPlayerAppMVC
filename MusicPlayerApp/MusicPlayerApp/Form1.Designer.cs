
namespace MusicPlayerApp
{
    partial class MusicPlayerApp
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerApp));
            this.TopPannel = new System.Windows.Forms.Panel();
            this.ClosePictureBox = new System.Windows.Forms.PictureBox();
            this.LB_Logal = new System.Windows.Forms.Label();
            this.ListBoxSongs = new System.Windows.Forms.ListBox();
            this.BtnSelectSong = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.TopPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPannel
            // 
            this.TopPannel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.TopPannel.Controls.Add(this.ClosePictureBox);
            this.TopPannel.Controls.Add(this.LB_Logal);
            this.TopPannel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPannel.Location = new System.Drawing.Point(0, 0);
            this.TopPannel.Name = "TopPannel";
            this.TopPannel.Size = new System.Drawing.Size(800, 48);
            this.TopPannel.TabIndex = 0;
            // 
            // ClosePictureBox
            // 
            this.ClosePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ClosePictureBox.Image")));
            this.ClosePictureBox.Location = new System.Drawing.Point(749, 0);
            this.ClosePictureBox.Name = "ClosePictureBox";
            this.ClosePictureBox.Size = new System.Drawing.Size(51, 45);
            this.ClosePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClosePictureBox.TabIndex = 2;
            this.ClosePictureBox.TabStop = false;
            this.ClosePictureBox.Click += new System.EventHandler(this.ClosePictureBox_Click);
            // 
            // LB_Logal
            // 
            this.LB_Logal.AutoSize = true;
            this.LB_Logal.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Logal.Location = new System.Drawing.Point(3, 13);
            this.LB_Logal.Name = "LB_Logal";
            this.LB_Logal.Size = new System.Drawing.Size(201, 25);
            this.LB_Logal.TabIndex = 1;
            this.LB_Logal.Text = "Music Player APP";
            // 
            // ListBoxSong
            // 
            this.ListBoxSongs.FormattingEnabled = true;
            this.ListBoxSongs.ItemHeight = 12;
            this.ListBoxSongs.Location = new System.Drawing.Point(588, 54);
            this.ListBoxSongs.Name = "ListBoxSong";
            this.ListBoxSongs.Size = new System.Drawing.Size(200, 328);
            this.ListBoxSongs.TabIndex = 1;
            this.ListBoxSongs.SelectedIndexChanged += new System.EventHandler(this.ListBoxSong_SelectedIndexChanged);
            // 
            // BtnSelectSong
            // 
            this.BtnSelectSong.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnSelectSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelectSong.ForeColor = System.Drawing.Color.White;
            this.BtnSelectSong.Location = new System.Drawing.Point(588, 399);
            this.BtnSelectSong.Name = "BtnSelectSong";
            this.BtnSelectSong.Size = new System.Drawing.Size(200, 39);
            this.BtnSelectSong.TabIndex = 2;
            this.BtnSelectSong.Text = "Select Song";
            this.BtnSelectSong.UseVisualStyleBackColor = false;
            this.BtnSelectSong.Click += new System.EventHandler(this.BtnSelectSong_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(21, 54);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(534, 328);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // MusicPlayerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.BtnSelectSong);
            this.Controls.Add(this.ListBoxSongs);
            this.Controls.Add(this.TopPannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusicPlayerApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlayerApp";
            this.TopPannel.ResumeLayout(false);
            this.TopPannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPannel;
        private System.Windows.Forms.PictureBox ClosePictureBox;
        private System.Windows.Forms.Label LB_Logal;
        private System.Windows.Forms.ListBox ListBoxSongs;
        private System.Windows.Forms.Button BtnSelectSong;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

