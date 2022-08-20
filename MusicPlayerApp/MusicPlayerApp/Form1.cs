using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        string[] path, files;

        private void BtnSelectSong_Click(object sender, EventArgs e)
        {
            OpenFileDialog _file = new OpenFileDialog();
            _file.Multiselect = true;
            if (_file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = _file.SafeFileNames; //儲存檔名
                path = _file.FileNames; // 儲存路徑
                
                for (int i = 0; i < files.Length; i++)
                {
                    ListBoxSongs.Items.Add(files[i]);
                }
            }

            if (ListBoxSongs.Items.Count > 0)
            {
                axWindowsMediaPlayer1.URL = path[0];
            }
        }

        private void ListBoxSong_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = path[ListBoxSongs.SelectedIndex];
        }

        private void ClosePictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
