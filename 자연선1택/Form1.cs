using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace 자연선1택 {
    public partial class Form1 : Form {
        // 필요한 변수 및 배열 선언
        int k = 0, i2;
        int[] k2 = new int[1000];
        Random rand = new Random();

        Label[] food = new Label[1000];

        Label[] space = new Label[1000];
        int space0 = 0, spacecount = 0;
        int[] randspaceX = new int[1000];
        int[] randspaceY = new int[1000];

        byte[] red = new byte[1000];
        byte[] blue = new byte[1000];

        int[] randlocX = new int[1000];
        int[] randlocY = new int[1000];
        int[] randspaceX2 = new int[1000];
        int[] randspaceY2 = new int[1000];

        int[] score = new int[1000];
        int fscore = 0;

        int[] speed = new int[1000];
        int[] size = new int[1000];
        int[] still = new int[1000];

        Timer[] timers = new Timer[1000];
        int counttimer = 0;
        int[] cou = new int[100];

        public Form1() {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        // 음식 생성 메서드
        public void FOOD() {
            i2 = 0;
            while(i2 < k) {
                // 랜덤 위치에 음식 생성
                // 집에 가고 싶다
                Label label = food[i2];
                label.Location = new Point(rand.Next(10, 800 - 30), rand.Next(10, 600 - 20));
                label.Size = new Size(10, 10);
                label.BackColor = Color.LightGreen;
                panel1.Controls.Add(food[i2]);
                i2++;
            }
        }

        // 공간 생성 메서드
        public void SPACE(int number) {
            rand.NextBytes(red);
            rand.NextBytes(blue);

            while(k2[space0] < number) {
                if(k2[space0] < number / 4) {
                    randspaceX[spacecount] = 0; // 왼쪽
                    randspaceY[spacecount] = rand.Next(1, 600 - 20);
                } else if(k2[space0] >= number / 4 && k2[space0] < number / 4 * 2) {
                    randspaceX[spacecount] = 800 - 20; // 오른쪽
                    randspaceY[spacecount] = rand.Next(1, 600 - 20);
                } else if(k2[space0] >= number / 4 * 2 && k2[space0] < number / 4 * 3) {
                    randspaceX[spacecount] = rand.Next(1, 800 - 20); // 위
                    randspaceY[spacecount] = 0;
                } else {
                    randspaceX[spacecount] = rand.Next(1, 800 - 20); // 아래
                    randspaceY[spacecount] = 600 - 20;
                }

                speed[spacecount] = Convert.ToInt32(Fspeed.Text);
                size[spacecount] = Convert.ToInt32(Fsize.Text);
                still[spacecount] = Convert.ToInt32(Fstill.Text);

                space[spacecount] = new Label();
                space[spacecount].Location = new Point(randspaceX[spacecount], randspaceY[spacecount]);
                space[spacecount].Size = new Size(size[spacecount], size[spacecount]);
                space[spacecount].BackColor = Color.FromArgb(red[space0], 0, blue[space0]);
                panel1.Controls.Add(space[spacecount]);

                k2[space0]++;
                spacecount++;
            }
            space0++;
            spacex.Text = Convert.ToString(space0);
        }

        public void ChangeLocation(int i) {
            if(randspaceX[i] == 0 && randspaceY[i] != 0) {
                randlocX[i] = 10 * 1;
                randlocY[i] = 10 * rand.Next(-1, 2);
            } else if(randspaceX[i] == 800 - 20 && randspaceY[i] != 0) {
                randlocX[i] = 10 * -1;
                randlocY[i] = 10 * rand.Next(-1, 2);
            } else if(randspaceX[i] != 0 && randspaceY[i] == 0) {
                randlocX[i] = 10 * rand.Next(-1, 2);
                randlocY[i] = 10 * 1;
            } else if(randspaceX[i] != 0 && randspaceY[i] == 600 - 20) {
                randlocX[i] = 10 * rand.Next(-1, 2);
                randlocY[i] = 10 * -1;
            }
        }

        public void EAT(int still) {
            int counter = space.Length;
            for(int rou = 0; rou < counter; rou++) {
                if(space[rou] == null) continue;
                for(int rou2 = 0; rou2 < i2; rou2++) {
                    if(space[rou].Left + still >= food[rou2].Left && space[rou].Left < food[rou2].Left + 10 && space[rou].Bottom + still > food[rou2].Bottom && space[rou].Bottom < food[rou2].Bottom + 10) {
                        panel1.Controls.Remove(food[rou2]);
                        score[rou]++;
                    }
                }
            }
        }

        public void SPACEEAT(int still, int[] size) {
            int counter = space.Length;
            for(int rou = 0; rou < counter; rou++) {
                if(space[rou] == null) continue;
                for(int rou2 = 0; rou2 < counter; rou2++) {
                    if(space[rou].Left + still >= space[rou2].Left &&
                       space[rou].Left < space[rou2].Left + size[rou2] &&
                       space[rou].Bottom + still > space[rou2].Bottom &&
                       space[rou].Bottom < space[rou2].Bottom + size[rou2]) {
                        if(size[rou] > size[rou2]) {
                            panel1.Controls.Remove(space[rou2]);
                            score[rou]++;
                        }
                    }
                }
            }
        }

        public void SPACE2() {
            int counter = space.Length;
            for(int j = 0; j < counter; j++) {
                if(space[j] == null) continue;

                cou[j] = 0;
                timers[j] = new Timer();
                timers[j].Interval = 100; // 타이머 간격 설정 (단위: 밀리초)
                int index = j; // 클로저 문제 해결을 위해 j를 index 변수에 할당

                timers[j].Tick += (sender, e) => {
                    // 타이머 이벤트 핸들러에서 UI 업데이트를 수행할 때는 메인 UI 스레드에서 실행되어야 함
                    TickEvent(index);
                };

                timers[j].Start(); // 타이머 시작
                // 타이머가 멈추는 시점을 비동기적으로 처리
                awa(timers[j], 4000);
            }
        }

        private async void awa(Timer timer, int timerstop) {
            await Task.Delay(timerstop);
            timer.Stop();
            counttimer++;
        }

        private void TickEvent(int j) {
            if(space[j] != null) {
                this.ChangeLocation(j);
                if(cou[j] == 0) {
                    randspaceX2[j] = randspaceX[j] + randlocX[j];
                    randspaceY2[j] = randspaceY[j] + randlocY[j];
                } else {
                    randspaceX2[j] = randspaceX2[j] + randlocX[j];
                    randspaceY2[j] = randspaceY2[j] + randlocY[j];
                }
                space[j].Location = new Point(randspaceX2[j], randspaceY2[j]);
                this.EAT(Convert.ToInt32(Fstill.Text));
            }
            cou[j]++;
        }

        // 추가 공간 생성 메서드
        public void CSPACE(int count) {
            int counter = rand.Next(0, 4);
            if(counter == 0) {
                randspaceX[count] = 0; // 왼쪽
                randspaceY[count] = rand.Next(1, 600 - 20);
            } else if(counter == 1) {
                randspaceX[count] = 800 - 20; // 오른쪽
                randspaceY[count] = rand.Next(1, 600 - 20);
            } else if(counter == 2) {
                randspaceX[count] = rand.Next(1, 800 - 20); // 위
                randspaceY[count] = 0;
            } else {
                randspaceX[count] = rand.Next(1, 800 - 20); // 아래
                randspaceY[count] = 600 - 20;
            }
        }

        public void tape(int[] i, int j, int ic) {
            if(rand.Next(0, 2) == 0) i[spacecount + fscore] = i[j] + ic;
            else i[spacecount + fscore] = i[j] - ic;
        }

        public void SPACE3(int j, int i) {
            if(space[j] == null) return;
            if(score[j] >= 1000) {
                space[spacecount + fscore] = new Label();
                CSPACE(spacecount + fscore);
                space[spacecount + fscore].Location = new Point(randspaceX[spacecount + fscore], randspaceY[spacecount + fscore]);
                space[spacecount + fscore].Size = new Size(Convert.ToInt32(Fsize.Text), Convert.ToInt32(Fsize.Text));
                space[spacecount + fscore].BackColor = Color.FromArgb(red[space0 - 1], 0, blue[space0 - 1]);
                space[spacecount + fscore].Text = (i + 1).ToString();
                space[spacecount + fscore].Font = new Font("한컴 백제 B", 9);
                space[spacecount + fscore].ForeColor = Color.White;
                space[j].Location = new Point(randspaceX[j], randspaceY[j]);
                tape(speed, j, Convert.ToInt32(speedC.Text));
                tape(size, j, Convert.ToInt32(sizeC.Text));
                tape(still, j, Convert.ToInt32(stillC.Text));
                fscore++;
            } else if(score[j] == 0) {
                panel1.Controls.Remove(space[j]);
                space[j] = null;
            } else {
                space[j].Location = new Point(randspaceX[j], randspaceY[j]);
            }
        }

        // '생성' 버튼 클릭 시 호출되는 이벤트 핸들러
        private void button2_Click(object sender, EventArgs e) {
            SPACE(Convert.ToInt32(number.Text));
        }

        // '음식 추가' 버튼 클릭 시 호출되는 이벤트 핸들러
        private void button1_Click(object sender, EventArgs e) {
            for(int i = 0; i < i2; i++) {
                panel1.Controls.Remove(food[i]);
                food[i].Dispose();
            }
            k = Convert.ToInt32(textBox1.Text);
            for(int i = 0; i < k; i++) {
                food[i] = new Label();
            }
            FOOD();
        }

        // '시작' 버튼 클릭 시 호출되는 이벤트 핸들러
        private async void button4_Click(object sender, EventArgs e) {
            counttimer = 0;
            int counter2 = Convert.ToInt32(work.Text);
            for(int i = 0; i < counter2; i++) {
                food[i] = new Label();
                SPACE2();
                await Task.Run(async () => {
                    while(counttimer <= space.Length) {
                        await Task.Delay(100);
                    }
                    int counter = spacecount + fscore;
                    for(int j = 0; j < counter; j++) {
                        SPACE3(j, i);
                    }
                });
                FOOD();
                score = Enumerable.Repeat(0, 10000).ToArray();
                for(int j = 0; j < fscore; j++) panel1.Controls.Add(space[spacecount + j]);
                textBox2.Text = (i + 1).ToString();
            }
        }
    }
}