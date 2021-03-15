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
    public partial class Frmsub : Form
    {
        public Frmsub()
        {
            InitializeComponent();
        }

        private void Frmsub_Load(object sender, EventArgs e)
        {
            this.Text = "중간고사 성적2";

            ChtScore.Titles.Add("중간고사 성적");
            ChtScore.Series.Add("Series2"); //데이터 시리즈 추가
            ChtScore.Series["Series1"].LegendText = "수학";
            ChtScore.Series["Series2"].LegendText = "영어";

            ChtScore.ChartAreas.Add("ChartAreas2");
            ChtScore.Series["Series2"].ChartArea = "ChartAreas2";

            Random random = new Random();

            for (int i = 1; i < 10; i++)
            {
                ChtScore.Series[0].Points.Add(i, random.Next(10, 100));
                ChtScore.Series[1].Points.Add(i, random.Next(10, 100));

            }

            ChtScore.Series[0].ChartType = SeriesChartType.Column;
            ChtScore.Series[1].ChartType = SeriesChartType.Line;


            Btnsplit.Enabled = false;
        }

        private void BtnMerge_Click(object sender, EventArgs e)
        {
            ChtScore.ChartAreas.RemoveAt(ChtScore.ChartAreas.IndexOf("ChartAreas2"));
            ChtScore.Series["Series2"].ChartArea = "ChartArea1";

            Btnsplit.Enabled = true;
            BtnMerge.Enabled = false;
        }

        private void Btnsplit_Click(object sender, EventArgs e)
        {
            ChtScore.ChartAreas.Add("ChartAreas2");
            ChtScore.Series["Series2"].ChartArea = "ChartAreas2";

            Btnsplit.Enabled = false;
            BtnMerge.Enabled = true;
        }
    }
}
