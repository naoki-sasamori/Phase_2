namespace Phase_2
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonCenter = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.checkBoxShow = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelMove = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.trackBarHeight = new System.Windows.Forms.TrackBar();
            this.trackBarWidth = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBarMove = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labelBlue = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelRed = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMove)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonLeft);
            this.groupBox4.Controls.Add(this.buttonRight);
            this.groupBox4.Controls.Add(this.buttonDown);
            this.groupBox4.Controls.Add(this.buttonCenter);
            this.groupBox4.Controls.Add(this.buttonUp);
            this.groupBox4.Location = new System.Drawing.Point(12, 123);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(143, 158);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "子ウィンドウ位置制御";
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(6, 66);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(40, 40);
            this.buttonLeft.TabIndex = 5;
            this.buttonLeft.Text = "←";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(97, 66);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(40, 40);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.Text = "→";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(51, 111);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(40, 40);
            this.buttonDown.TabIndex = 3;
            this.buttonDown.Text = "↓";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonCenter
            // 
            this.buttonCenter.Location = new System.Drawing.Point(51, 65);
            this.buttonCenter.Name = "buttonCenter";
            this.buttonCenter.Size = new System.Drawing.Size(40, 40);
            this.buttonCenter.TabIndex = 2;
            this.buttonCenter.Text = "〇";
            this.buttonCenter.UseVisualStyleBackColor = true;
            this.buttonCenter.Click += new System.EventHandler(this.buttonCenter_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(51, 19);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(40, 40);
            this.buttonUp.TabIndex = 1;
            this.buttonUp.Text = "↑";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // checkBoxShow
            // 
            this.checkBoxShow.AutoSize = true;
            this.checkBoxShow.Location = new System.Drawing.Point(175, 12);
            this.checkBoxShow.Name = "checkBoxShow";
            this.checkBoxShow.Size = new System.Drawing.Size(103, 16);
            this.checkBoxShow.TabIndex = 1;
            this.checkBoxShow.Text = "子ウィンドウ表示";
            this.checkBoxShow.UseVisualStyleBackColor = true;
            this.checkBoxShow.CheckedChanged += new System.EventHandler(this.checkBoxShow_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelHeight);
            this.groupBox5.Controls.Add(this.labelWidth);
            this.groupBox5.Controls.Add(this.labelMove);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.trackBarHeight);
            this.groupBox5.Controls.Add(this.trackBarWidth);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.trackBarMove);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(175, 47);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(387, 182);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "子ウィンドウ座標制御";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(59, 117);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(41, 12);
            this.labelHeight.TabIndex = 14;
            this.labelHeight.Text = "label13";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(59, 66);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(41, 12);
            this.labelWidth.TabIndex = 13;
            this.labelWidth.Text = "label13";
            // 
            // labelMove
            // 
            this.labelMove.AutoSize = true;
            this.labelMove.Location = new System.Drawing.Point(59, 20);
            this.labelMove.Name = "labelMove";
            this.labelMove.Size = new System.Drawing.Size(41, 12);
            this.labelMove.TabIndex = 12;
            this.labelMove.Text = "label13";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "高：";
            // 
            // trackBarHeight
            // 
            this.trackBarHeight.Location = new System.Drawing.Point(136, 117);
            this.trackBarHeight.Minimum = 1;
            this.trackBarHeight.Name = "trackBarHeight";
            this.trackBarHeight.Size = new System.Drawing.Size(245, 45);
            this.trackBarHeight.TabIndex = 8;
            this.trackBarHeight.Value = 1;
            this.trackBarHeight.Scroll += new System.EventHandler(this.trackBarHeight_Scroll);
            // 
            // trackBarWidth
            // 
            this.trackBarWidth.Location = new System.Drawing.Point(136, 66);
            this.trackBarWidth.Minimum = 1;
            this.trackBarWidth.Name = "trackBarWidth";
            this.trackBarWidth.Size = new System.Drawing.Size(245, 45);
            this.trackBarWidth.TabIndex = 7;
            this.trackBarWidth.Value = 1;
            this.trackBarWidth.Scroll += new System.EventHandler(this.trackBarWidth_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "幅：";
            // 
            // trackBarMove
            // 
            this.trackBarMove.Location = new System.Drawing.Point(136, 20);
            this.trackBarMove.Maximum = 100;
            this.trackBarMove.Minimum = 1;
            this.trackBarMove.Name = "trackBarMove";
            this.trackBarMove.Size = new System.Drawing.Size(245, 45);
            this.trackBarMove.TabIndex = 5;
            this.trackBarMove.Value = 1;
            this.trackBarMove.Scroll += new System.EventHandler(this.trackBarMove_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "移動量：";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.labelBlue);
            this.groupBox6.Controls.Add(this.labelGreen);
            this.groupBox6.Controls.Add(this.labelRed);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.trackBarBlue);
            this.groupBox6.Controls.Add(this.trackBarGreen);
            this.groupBox6.Controls.Add(this.trackBarRed);
            this.groupBox6.Location = new System.Drawing.Point(175, 255);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(387, 220);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "子ウィンドウ背景色制御";
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Location = new System.Drawing.Point(59, 120);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(41, 12);
            this.labelBlue.TabIndex = 17;
            this.labelBlue.Text = "label13";
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.Location = new System.Drawing.Point(59, 69);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(41, 12);
            this.labelGreen.TabIndex = 16;
            this.labelGreen.Text = "label13";
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Location = new System.Drawing.Point(59, 18);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(41, 12);
            this.labelRed.TabIndex = 15;
            this.labelRed.Text = "label13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 12);
            this.label12.TabIndex = 11;
            this.label12.Text = "B：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 12);
            this.label11.TabIndex = 10;
            this.label11.Text = "G：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "R：";
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(136, 120);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(245, 45);
            this.trackBarBlue.TabIndex = 8;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarCommon_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(136, 69);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(245, 45);
            this.trackBarGreen.TabIndex = 7;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarCommon_Scroll);
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(136, 18);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(245, 45);
            this.trackBarRed.TabIndex = 6;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarCommon_Scroll);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(576, 489);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.checkBoxShow);
            this.Controls.Add(this.groupBox4);
            this.Name = "Form1";
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMove)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonCenter;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.CheckBox checkBoxShow;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trackBarHeight;
        private System.Windows.Forms.TrackBar trackBarWidth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBarMove;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelMove;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelRed;
    }
}

