using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace AlarmClockApp
{
    public partial class FrmAlarm : Form
    {
        private DateTime SetDay;
        private DateTime SetTime;
        private bool IsSetAlarm;
        WindowsMediaPlayer windowsMediaPlayer;

        public FrmAlarm()
        {
            InitializeComponent();
            //초기화 작업

        }

        private void FrmAlarm_Load(object sender, EventArgs e)
        {
            windowsMediaPlayer = new WindowsMediaPlayer();

            LblAlarm.ForeColor = Color.Gray;

            LblDate.Text = LblTime.Text="";

            DtpAlarmTime.Format = DateTimePickerFormat.Custom;
            DtpAlarmTime.CustomFormat = "hh:mm:ss";
            DtpAlarmTime.ShowUpDown = true;

            Mytimer.Interval = 1000;//1초
            Mytimer.Tick += Mytimer_Tick;
            Mytimer.Start();

            TabClock.SelectedTab = TapDigitalClock;
        }

        private void Mytimer_Tick(object sender, EventArgs e)
        {
            DateTime curDate = DateTime.Now;
            LblDate.Text = curDate.ToShortDateString();
            LblTime.Text = curDate.ToString("hh:mm:ss");

            if (IsSetAlarm == true)//알람 설정이 되었다면
            {
                //알람 시간하고 현재시간이 일치하면 알람이 울림
                if (SetDay == DateTime.Today && 
                    SetTime.Hour == curDate.Hour &&
                    SetTime.Minute == curDate.Minute &&
                    SetTime.Second == curDate.Second)
                {
                    //IsSetAlarm = false; //알람 설정 종료
                    BtnRelease_Click(sender, e);
                    windowsMediaPlayer.URL = @".\media\alarm.mp3";
                    windowsMediaPlayer.controls.play();

                    MessageBox.Show("알람!!!","알람",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

            }
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            SetDay = DateTime.Parse(DtpAlarmDate.Text);
            SetTime = DateTime.Parse(DtpAlarmTime.Text);

            LblAlarm.Text = $"Alarm : {SetDay.ToShortDateString()}, {SetTime:hh:mm:ss}";
            LblAlarm.ForeColor = Color.Red;

            TabClock.SelectedTab = TapDigitalClock;
            IsSetAlarm = true;
        }

        private void BtnRelease_Click(object sender, EventArgs e)
        {
            IsSetAlarm = false;
            LblAlarm.Text = "Alarm : ";
            LblAlarm.ForeColor = Color.Gray;
            TabClock.SelectedTab = TapDigitalClock;
                
        }
    }
}
