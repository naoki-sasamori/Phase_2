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
    public partial class FormMain : Form
    {
        FormChild formChild = new FormChild();

        public FormMain()
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
            labelWidth.Text         = formChild.Width.ToString();
            labelHeight.Text        = formChild.Height.ToString();
            labelRed.Text           = trackBarRed.Value.ToString();
            labelGreen.Text         = trackBarGreen.Value.ToString();
            labelBlue.Text          = trackBarBlue.Value.ToString();
        }

        

        // ----------「子ウィンドウ表示」チェックボックス
        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            // オン／オフにより子ウィンドウの表示／非表示を切り替え
            if (checkBoxShow.Checked)
            {
                formChild.Show();
            }
            else
            {
                formChild.Hide();
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
            formChild.Width = trackBarWidth.Value;
        }

        // ----------「高」トラックバー
        private void trackBarHeight_Scroll(object sender, EventArgs e)
        {
            // 値表示
            labelHeight.Text = trackBarHeight.Value.ToString();

            // 子フォームの高変更
            formChild.Height = trackBarHeight.Value;
        }

        // ----------「R」／「G」／「B」トラックバー
        private void trackBarCommon_Scroll(object sender, EventArgs e)
        {
            // 値表示
            labelRed.Text = trackBarRed.Value.ToString();
            labelGreen.Text = trackBarGreen.Value.ToString();
            labelBlue.Text = trackBarBlue.Value.ToString();

            // 子フォームの背景色変更
            formChild.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        // ----------「↑」ボタン
        private void buttonUp_Click(object sender, EventArgs e)
        {
            formChild.Top -= trackBarMove.Value;
        }

        // ----------「→」ボタン
        private void buttonRight_Click(object sender, EventArgs e)
        {
            formChild.Left += trackBarMove.Value;
        }

        // ----------「↓」ボタン
        private void buttonDown_Click(object sender, EventArgs e)
        {
            formChild.Top += trackBarMove.Value;
        }

        // ----------「←」ボタン
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            formChild.Left -= trackBarMove.Value;
        }

        // ----------「〇」ボタン
        private void buttonCenter_Click(object sender, EventArgs e)
        {
            formChild.Left  = (Screen.PrimaryScreen.Bounds.Width - formChild.Width) / 2;
            formChild.Top   = (Screen.PrimaryScreen.Bounds.Height - formChild.Height) / 2;
        }
    }
}
