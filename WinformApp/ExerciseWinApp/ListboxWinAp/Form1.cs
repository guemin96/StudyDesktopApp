using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListboxWinAp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //살기좋은 도시 초기화, 가장 기본적인 리스트박스 추가
            LsbGoodCity.Items.Add("오스트리아, 빈");
            LsbGoodCity.Items.Add("호주, 멜버른");
            LsbGoodCity.Items.Add("일본, 오사카");
            LsbGoodCity.Items.Add("캐나다, 캘거리");
            LsbGoodCity.Items.Add("호주, 시드니");
            LsbGoodCity.Items.Add("캐나다,밴쿠버");
            LsbGoodCity.Items.Add("일본, 도쿄");
            LsbGoodCity.Items.Add("캐나다, 토론토");
            LsbGoodCity.Items.Add("덴마크, 코펜하겐");
            LsbGoodCity.Items.Add("호주, 애들레이드");
            /*List<string> lstCity = new List<string>() { 
            "오스트리아, 빈","호주, 멜버른","일본, 오사카","캐나다, 캘거리"
            
            };*/
            /*LsbGoodCity.DataSource = lstCity;*/
            //데이터 바인딩 방식중 하나
            /*List<string> lstCountry = new List<string>() { 
                "미국", "러시아", "중국", "영국", "독일", "프랑스", "일본", "이스라엘", "사우디아라비아", "UAE", "필리핀"
            };
            LsbHappyCountry.DataSource = lstCountry;*/
            LsbHappyCountry.Items.Add("오스트리아, 빈");
            LsbHappyCountry.Items.Add("호주, 멜버른");
            LsbHappyCountry.Items.Add("일본, 오사카");
            LsbHappyCountry.Items.Add("캐나다, 캘거리");
            LsbHappyCountry.Items.Add("호주, 시드니");
            LsbHappyCountry.Items.Add("캐나다,밴쿠버");
            LsbHappyCountry.Items.Add("일본, 도쿄");
            LsbHappyCountry.Items.Add("캐나다, 토론토");
            LsbHappyCountry.Items.Add("덴마크, 코펜하겐");
            LsbHappyCountry.Items.Add("호주, 애들레이드");


        }

        private void LsbGdpCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 선택된 값 확인
            //MessageBox.Show(sender.ToString());
            var selItem = sender as ListBox;
            //MessageBox.Show($"{selItem.SelectedIndex}/{selItem.SelectedItem}");
            TxtIndexGdp.Text = selItem.SelectedIndex.ToString();
            TxtItemGdp.Text = selItem.SelectedItem == null ? string.Empty : selItem.SelectedItem.ToString(); ;
        }

        private void LsbGoodCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selItem = sender as ListBox;
            TxtIndexGood.Text = selItem.SelectedIndex.ToString();
            TxtItemGood.Text = selItem.SelectedItem == null ? string.Empty : selItem.SelectedItem.ToString(); ;
        }

        private void LsbHappyCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selItem = sender as ListBox;
            TxtIndexHappy.Text = selItem.SelectedIndex.ToString();
            TxtItemHappy.Text = selItem.SelectedItem == null ? string.Empty : selItem.SelectedItem.ToString();
                
        }

        private void BtnFinish_Click(object sender, EventArgs e)
        {
            LsbGdpCountry.SelectedIndex = LsbGoodCity.SelectedIndex = LsbHappyCountry.SelectedIndex = -1;

        }
    }
}
