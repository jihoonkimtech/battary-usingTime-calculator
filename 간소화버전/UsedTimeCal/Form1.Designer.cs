namespace UsedTimeCal
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Batt = new System.Windows.Forms.TabPage();
            this.batWatt = new System.Windows.Forms.TextBox();
            this.batAmp = new System.Windows.Forms.TextBox();
            this.batVolt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CalculateBut = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.useTimeVal = new System.Windows.Forms.TextBox();
            this.useW = new System.Windows.Forms.TextBox();
            this.batW = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.useTimeBut = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bar = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.Batt.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Batt);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl1.Location = new System.Drawing.Point(7, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(480, 229);
            this.tabControl1.TabIndex = 0;
            // 
            // Batt
            // 
            this.Batt.Controls.Add(this.batWatt);
            this.Batt.Controls.Add(this.batAmp);
            this.Batt.Controls.Add(this.batVolt);
            this.Batt.Controls.Add(this.label5);
            this.Batt.Controls.Add(this.label4);
            this.Batt.Controls.Add(this.label3);
            this.Batt.Controls.Add(this.CalculateBut);
            this.Batt.Controls.Add(this.label11);
            this.Batt.Controls.Add(this.label10);
            this.Batt.Controls.Add(this.label2);
            this.Batt.Location = new System.Drawing.Point(4, 30);
            this.Batt.Name = "Batt";
            this.Batt.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Batt.Size = new System.Drawing.Size(472, 195);
            this.Batt.TabIndex = 0;
            this.Batt.Text = "배터리 전력";
            this.Batt.UseVisualStyleBackColor = true;
            // 
            // batWatt
            // 
            this.batWatt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.batWatt.ForeColor = System.Drawing.SystemColors.Window;
            this.batWatt.Location = new System.Drawing.Point(172, 149);
            this.batWatt.Name = "batWatt";
            this.batWatt.Size = new System.Drawing.Size(162, 29);
            this.batWatt.TabIndex = 3;
            // 
            // batAmp
            // 
            this.batAmp.Location = new System.Drawing.Point(138, 86);
            this.batAmp.Name = "batAmp";
            this.batAmp.Size = new System.Drawing.Size(188, 29);
            this.batAmp.TabIndex = 3;
            // 
            // batVolt
            // 
            this.batVolt.Location = new System.Drawing.Point(138, 31);
            this.batVolt.Name = "batVolt";
            this.batVolt.Size = new System.Drawing.Size(188, 29);
            this.batVolt.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(340, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Wh  입니다.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(32, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "배터리 전력량은 ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(19, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "배터리 전류 :";
            // 
            // CalculateBut
            // 
            this.CalculateBut.BackColor = System.Drawing.Color.Teal;
            this.CalculateBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateBut.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CalculateBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CalculateBut.Location = new System.Drawing.Point(395, 23);
            this.CalculateBut.Name = "CalculateBut";
            this.CalculateBut.Size = new System.Drawing.Size(65, 103);
            this.CalculateBut.TabIndex = 2;
            this.CalculateBut.Text = "계산";
            this.CalculateBut.UseVisualStyleBackColor = false;
            this.CalculateBut.Click += new System.EventHandler(this.CalculateBut_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(332, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 21);
            this.label11.TabIndex = 1;
            this.label11.Text = "A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(332, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "V";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(19, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "배터리 전압 :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.useTimeVal);
            this.tabPage2.Controls.Add(this.useW);
            this.tabPage2.Controls.Add(this.batW);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.useTimeBut);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(472, 195);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "사용 시간";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(322, 86);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(67, 29);
            this.comboBox1.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(322, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 21);
            this.label13.TabIndex = 13;
            this.label13.Text = "Wh";
            // 
            // useTimeVal
            // 
            this.useTimeVal.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.useTimeVal.ForeColor = System.Drawing.SystemColors.Window;
            this.useTimeVal.Location = new System.Drawing.Point(125, 148);
            this.useTimeVal.Name = "useTimeVal";
            this.useTimeVal.Size = new System.Drawing.Size(188, 29);
            this.useTimeVal.TabIndex = 9;
            // 
            // useW
            // 
            this.useW.Location = new System.Drawing.Point(129, 86);
            this.useW.Name = "useW";
            this.useW.Size = new System.Drawing.Size(188, 29);
            this.useW.TabIndex = 10;
            // 
            // batW
            // 
            this.batW.Location = new System.Drawing.Point(129, 31);
            this.batW.Name = "batW";
            this.batW.Size = new System.Drawing.Size(188, 29);
            this.batW.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(319, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "시간 입니다.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(24, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "사용 시간은";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(23, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "소비 전기 :";
            // 
            // useTimeBut
            // 
            this.useTimeBut.BackColor = System.Drawing.Color.Teal;
            this.useTimeBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.useTimeBut.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.useTimeBut.ForeColor = System.Drawing.Color.White;
            this.useTimeBut.Location = new System.Drawing.Point(395, 23);
            this.useTimeBut.Name = "useTimeBut";
            this.useTimeBut.Size = new System.Drawing.Size(65, 103);
            this.useTimeBut.TabIndex = 8;
            this.useTimeBut.Text = "계산";
            this.useTimeBut.UseVisualStyleBackColor = false;
            this.useTimeBut.Click += new System.EventHandler(this.useTimeBut_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(10, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "배터리 전력 :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Teal;
            this.label14.Location = new System.Drawing.Point(142, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 25);
            this.label14.TabIndex = 2;
            this.label14.Text = "Calculator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 17F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(3, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "USING TIME";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 273);
            this.panel1.TabIndex = 4;
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bar.Controls.Add(this.panel4);
            this.bar.Controls.Add(this.panel3);
            this.bar.Controls.Add(this.panel2);
            this.bar.Controls.Add(this.down);
            this.bar.Controls.Add(this.exit);
            this.bar.Controls.Add(this.label14);
            this.bar.Controls.Add(this.label1);
            this.bar.Location = new System.Drawing.Point(4, 4);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(496, 33);
            this.bar.TabIndex = 4;
            this.bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // exit
            // 
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.exit.Location = new System.Drawing.Point(452, -1);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(43, 33);
            this.exit.TabIndex = 4;
            this.exit.Text = "Χ";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // down
            // 
            this.down.FlatAppearance.BorderSize = 0;
            this.down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.down.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.down.Location = new System.Drawing.Point(411, -3);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(43, 33);
            this.down.TabIndex = 5;
            this.down.Text = "_";
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Location = new System.Drawing.Point(452, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(43, 10);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Location = new System.Drawing.Point(411, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(43, 10);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Location = new System.Drawing.Point(-1, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(412, 23);
            this.panel4.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(504, 283);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.tabControl1.ResumeLayout(false);
            this.Batt.ResumeLayout(false);
            this.Batt.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.bar.ResumeLayout(false);
            this.bar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Batt;
        private System.Windows.Forms.TextBox batWatt;
        private System.Windows.Forms.TextBox batAmp;
        private System.Windows.Forms.TextBox batVolt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CalculateBut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox useTimeVal;
        private System.Windows.Forms.TextBox useW;
        private System.Windows.Forms.TextBox batW;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button useTimeBut;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel bar;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
    }
}

