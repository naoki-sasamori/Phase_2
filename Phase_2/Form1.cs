using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phase_2
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();

        public Form1()
        {
            InitializeComponent();

            // 各トラックバーの最大値設定
            trackBarWidth.Maximum   = Screen.PrimaryScreen.Bounds.Width;
            trackBarHeight.Maximum  = Screen.PrimaryScreen.Bounds.Height;

            // 各トラックバーの初期値設定
            trackBarMove.Value      = 1;
            trackBarHeight.Value    = 1;
            trackBarWidth.Value     = 1;
            trackBarRed.Value       = 0;
            trackBarGreen.Value     = 0;
            trackBarBlue.Value      = 0;

            // 各トラックバーの初期値表示
            labelMove.Text          = trackBarMove.Value.ToString();
            labelWidth.Text         = trackBarWidth.Value.ToString();
            labelHeight.Text        = trackBarHeight.Value.ToString();
            labelRed.Text           = trackBarRed.Value.ToString();
            labelGreen.Text         = trackBarGreen.Value.ToString();
            labelBlue.Text          = trackBarBlue.Value.ToString();
        }

        

        // ----------「子ウィンドウ表示」チェックボックス
        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            //Form2 form2 = new Form2();

            // オン／オフにより子ウィンドウの表示／非表示を切り替え
            if (checkBoxShow.Checked)
            {
                form2.Show();
            }
            else
            {
                form2.Hide();
            }
        }

        // ----------「移動量」トラックバー
        private void trackBarMove_Scroll(object sender, EventArgs e)
        {
            labelMove.Text = trackBarMove.Value.ToString();
        }

        // ----------「幅」トラックバー
        private void trackBarWidth_Scroll(object sender, EventArgs e)
        {
            // 値表示
            labelWidth.Text = trackBarWidth.Value.ToString();

            // 子フォームの幅変更
            form2.Width = trackBarWidth.Value;
        }

        // ----------「高」トラックバー
        private void trackBarHeight_Scroll(object sender, EventArgs e)
        {
            // 値表示
            labelHeight.Text = trackBarHeight.Value.ToString();

            // 子フォームの高変更
            form2.Height = trackBarHeight.Value;
        }

        // ----------「R」トラックバー
        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            // 値表示
            labelRed.Text = trackBarRed.Value.ToString();

            // 子フォームの背景色変更
            form2.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        // ----------「G」トラックバー
        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            // 値表示
            labelGreen.Text = trackBarGreen.Value.ToString();

            // 子フォームの背景色変更
            form2.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        // ----------「B」トラックバー
        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            // 値表示
            labelBlue.Text = trackBarBlue.Value.ToString();

            // 子フォームの背景色変更
            form2.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        // ----------「↑」ボタン
        private void buttonUp_Click(object sender, EventArgs e)
        {
            form2.Top -= trackBarMove.Value;
        }

        // ----------「→」ボタン
        private void buttonRight_Click(object sender, EventArgs e)
        {
            form2.Left += trackBarMove.Value;
        }

        // ----------「↓」ボタン
        private void buttonDown_Click(object sender, EventArgs e)
        {
            form2.Top += trackBarMove.Value;
        }

        // ----------「←」ボタン
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            form2.Left -= trackBarMove.Value;
        }

        // ----------「〇」ボタン
        private void buttonCenter_Click(object sender, EventArgs e)
        {
            form2.Left  = (Screen.PrimaryScreen.Bounds.Width - form2.Width) / 2;
            form2.Top   = (Screen.PrimaryScreen.Bounds.Height - form2.Height) / 2;
        }
    }
}
