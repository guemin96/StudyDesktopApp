using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagWinApp
{
    public partial class FrmMain : Form
    {
        private bool isHello = false; // flag 상태를 저장하는 값. 최초값은 false

        public FrmMain()
        {
            InitializeComponent();//윈폼에서 가장 중요한 메소드, 창자체를 실행해줌

            isHello = true;//아침,초기화
        }

        private void BtnGreeting_Click(object sender, EventArgs e)
        {
            if (isHello==true)
            {
                LblGreeting.Text = "Good Morning!!";
                isHello = false;
                BtnGreeting.Text = "저녁인사";

            }
            else if (isHello==false)
            {
                LblGreeting.Text = "GoodBye~";
                isHello = true;
                BtnGreeting.Text = "아침인사";
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LblGreeting.Text = string.Empty;
        }
    }
}
