using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WinChartApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnRegen_Click(object sender, EventArgs e)
        {
            GenNewChart();

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Text = "중간고사 성적";
            ChtScore.Titles.Add("중간고사 성적");
            GenNewChart();

        }

        private void GenNewChart()
        {
            
            Random rand = new Random();
            // ChtScore.Series.Clear();//데이터 자체를 다 지워버리기 때문에 밑에서 Score의 값 자체가 존재하지 않게 된다.

            ChtScore.Series["Score"].Points.Clear();
            
            for (int i = 0; i < 10; i++)
            {
                ChtScore.Series["Score"].Points.Add(rand.Next(10, 100));
                
            }
            ChtScore.Series["Score"].LegendText = "수학";//Legend:범례,series:데이터
            
            ChtScore.Series["Score"].ChartType = SeriesChartType.Line;
        }
    }
}
