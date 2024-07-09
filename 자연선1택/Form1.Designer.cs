namespace 자연선1택
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.work = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.stillC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.sizeC = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.speedC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.spacex = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Fstill = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Fsize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Fspeed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("한컴 백제 B", 11F);
            this.button1.Location = new System.Drawing.Point(129, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("한컴 백제 B", 12F);
            this.textBox1.Location = new System.Drawing.Point(14, 68);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 49);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "50";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.work);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.stillC);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.sizeC);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.speedC);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.spacex);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.number);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Fstill);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Fsize);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Fspeed);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(37, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 898);
            this.panel2.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("한컴 백제 B", 10F);
            this.label14.Location = new System.Drawing.Point(208, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 27);
            this.label14.TabIndex = 37;
            this.label14.Text = "음식 증가량:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("한컴 백제 B", 10F);
            this.textBox3.Location = new System.Drawing.Point(315, 24);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 32);
            this.textBox3.TabIndex = 36;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("한컴 백제 B", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(352, 750);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(54, 34);
            this.textBox2.TabIndex = 31;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.IndianRed;
            this.button4.Font = new System.Drawing.Font("한컴 백제 B", 15F);
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(183, 790);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(223, 100);
            this.button4.TabIndex = 30;
            this.button4.Text = "실 행";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("한컴 백제 B", 12F);
            this.label16.Location = new System.Drawing.Point(130, 762);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 32);
            this.label16.TabIndex = 29;
            this.label16.Text = "번";
            // 
            // work
            // 
            this.work.Font = new System.Drawing.Font("한컴 백제 B", 12F);
            this.work.Location = new System.Drawing.Point(20, 758);
            this.work.Multiline = true;
            this.work.Name = "work";
            this.work.Size = new System.Drawing.Size(103, 49);
            this.work.TabIndex = 28;
            this.work.Text = "10";
            this.work.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("한컴 백제 B", 13F);
            this.label15.Location = new System.Drawing.Point(14, 710);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 35);
            this.label15.TabIndex = 28;
            this.label15.Text = "실행 횟수";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("한컴 백제 B", 12F);
            this.label10.Location = new System.Drawing.Point(9, 650);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 32);
            this.label10.TabIndex = 27;
            this.label10.Text = "민감도:";
            // 
            // stillC
            // 
            this.stillC.Font = new System.Drawing.Font("한컴 백제 B", 12F);
            this.stillC.Location = new System.Drawing.Point(89, 640);
            this.stillC.Multiline = true;
            this.stillC.Name = "stillC";
            this.stillC.Size = new System.Drawing.Size(103, 49);
            this.stillC.TabIndex = 26;
            this.stillC.Text = "0";
            this.stillC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("한컴 백제 B", 12F);
            this.label12.Location = new System.Drawing.Point(29, 584);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 32);
            this.label12.TabIndex = 25;
            this.label12.Text = "크기:";
            // 
            // sizeC
            // 
            this.sizeC.Font = new System.Drawing.Font("한컴 백제 B", 12F);
            this.sizeC.Location = new System.Drawing.Point(89, 574);
            this.sizeC.Multiline = true;
            this.sizeC.Name = "sizeC";
            this.sizeC.Size = new System.Drawing.Size(103, 49);
            this.sizeC.TabIndex = 24;
            this.sizeC.Text = "0";
            this.sizeC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("한컴 백제 B", 12F);
            this.label13.Location = new System.Drawing.Point(29, 516);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 32);
            this.label13.TabIndex = 23;
            this.label13.Text = "속도:";
            // 
            // speedC
            // 
            this.speedC.Font = new System.Drawing.Font("한컴 백제 B", 12F);
            this.speedC.Location = new System.Drawing.Point(89, 508);
            this.speedC.Multiline = true;
            this.speedC.Name = "speedC";
            this.speedC.Size = new System.Drawing.Size(103, 49);
            this.speedC.TabIndex = 22;
            this.speedC.Text = "1";
            this.speedC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("한컴 백제 B", 13F);
            this.label9.Location = new System.Drawing.Point(14, 454);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 35);
            this.label9.TabIndex = 21;
            this.label9.Text = "변화량 설정";
            // 
            // spacex
            // 
            this.spacex.AutoSize = true;
            this.spacex.Font = new System.Drawing.Font("한컴 백제 B", 12F);
            this.spacex.Location = new System.Drawing.Point(221, 146);
            this.spacex.Name = "spacex";
            this.spacex.Size = new System.Drawing.Size(29, 32);
            this.spacex.TabIndex = 20;
            this.spacex.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("한컴 백제 B", 12F);
            this.label11.Location = new System.Drawing.Point(197, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 32);
            this.label11.TabIndex = 19;
            this.label11.Text = "x";
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("한컴 백제 B", 12F);
            this.number.Location = new System.Drawing.Point(89, 386);
            this.number.Multiline = true;
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(103, 49);
            this.number.TabIndex = 16;
            this.number.Text = "7";
            this.number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("한컴 백제 B", 11F);
            this.button2.Location = new System.Drawing.Point(120, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 50);
            this.button2.TabIndex = 15;
            this.button2.Text = "확인";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("한컴 백제 B", 12F);
            this.label7.Location = new System.Drawing.Point(9, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "생성수:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("한컴 백제 B", 12F);
            this.label6.Location = new System.Drawing.Point(9, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "민감도:";
            // 
            // Fstill
            // 
            this.Fstill.Font = new System.Drawing.Font("한컴 백제 B", 12F);
            this.Fstill.Location = new System.Drawing.Point(89, 322);
            this.Fstill.Multiline = true;
            this.Fstill.Name = "Fstill";
            this.Fstill.Size = new System.Drawing.Size(103, 49);
            this.Fstill.TabIndex = 11;
            this.Fstill.Text = "15";
            this.Fstill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("한컴 백제 B", 12F);
            this.label5.Location = new System.Drawing.Point(29, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "크기:";
            // 
            // Fsize
            // 
            this.Fsize.Font = new System.Drawing.Font("한컴 백제 B", 12F);
            this.Fsize.Location = new System.Drawing.Point(89, 256);
            this.Fsize.Multiline = true;
            this.Fsize.Name = "Fsize";
            this.Fsize.Size = new System.Drawing.Size(103, 49);
            this.Fsize.TabIndex = 9;
            this.Fsize.Text = "15";
            this.Fsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("한컴 백제 B", 12F);
            this.label4.Location = new System.Drawing.Point(29, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "속도";
            // 
            // Fspeed
            // 
            this.Fspeed.Font = new System.Drawing.Font("한컴 백제 B", 12F);
            this.Fspeed.Location = new System.Drawing.Point(89, 190);
            this.Fspeed.Multiline = true;
            this.Fspeed.Name = "Fspeed";
            this.Fspeed.Size = new System.Drawing.Size(103, 49);
            this.Fspeed.TabIndex = 7;
            this.Fspeed.Text = "10";
            this.Fspeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("한컴 백제 B", 13F);
            this.label3.Location = new System.Drawing.Point(14, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "종 생성";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("한컴 백제 B", 12F);
            this.label2.Location = new System.Drawing.Point(121, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "개";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("한컴 백제 B", 13F);
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "음식 생성";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(480, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 898);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(-2, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1141, 898);
            this.panel3.TabIndex = 2;
            this.panel3.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9F);
            this.label8.Location = new System.Drawing.Point(90, 935);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1834, 1050);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "zi존주녕의 자연선택 시뮬레이션";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label spacex;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox work;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox stillC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox sizeC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox speedC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Fstill;
        private System.Windows.Forms.TextBox Fsize;
        private System.Windows.Forms.TextBox Fspeed;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox3;
    }
}

