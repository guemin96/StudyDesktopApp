using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IOTSenserMonApp
{
    public partial class FrmMain : Form
    {
        private double xCount = 200;//차트에 보이는 데이터 수
        Timer timerSimul = new Timer();
        Random randPhoto = new Random();
        bool IsSimulation = false;
        private List<SensorData> sensors = new List<SensorData>(); //차트, 리스트 박스에 계속 출력
        private string connString = "Data Source=127.0.0.1;" +
                                    "Initial Catalog=IOTData;" +
                                    "User ID=sa;"+
                                    "Password=mssql_p@ssw0rd!";

        public FrmMain()
        {
            InitializeComponent();
        }

        

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //ComboBox 초기화
            foreach (var ports in SerialPort.GetPortNames())
            {
                CboSerialPort.Items.Add(ports);

            }
            CboSerialPort.Text = "Select Port";
            //IOT장비에서 받을 값의 범위
            PrbPhotoresister.Minimum = 0;
            PrbPhotoresister.Maximum = 1023;

            //차트모양 초기화
            InitChartStyle();

            //BtnDisplay 초기화
            BtnDisplay.BackColor = Color.BlueViolet;
            BtnDisplay.ForeColor = Color.WhiteSmoke;
            BtnDisplay.Text = "NONE";
            BtnDisplay.Font = new Font("맑은 고딕", 14, FontStyle.Bold);

            //나머지 초기화
            LblConnectTime.Text = "Connection Time : ";
            TxtSensorNum.TextAlign = HorizontalAlignment.Right;
            TxtSensorNum.Text = "0";
            BtnConnect.Enabled = BtnDisconnect.Enabled = false;

        }
        /// <summary>
        /// 차트 초기설정
        /// </summary>
        private void InitChartStyle()
        {
            ChtPhotoResisters.ChartAreas[0].BackColor = Color.Blue;
            ChtPhotoResisters.ChartAreas[0].AxisX.Minimum = 0;
            ChtPhotoResisters.ChartAreas[0].AxisX.Maximum = xCount;
            ChtPhotoResisters.ChartAreas[0].AxisX.Interval = xCount / 4; //50으로 정함
            ChtPhotoResisters.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.WhiteSmoke;
            ChtPhotoResisters.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            
            ChtPhotoResisters.ChartAreas[0].AxisY.Minimum = 0;
            ChtPhotoResisters.ChartAreas[0].AxisY.Maximum = 1024;
            ChtPhotoResisters.ChartAreas[0].AxisY.Interval = xCount / 4; //50으로 정함
            ChtPhotoResisters.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.WhiteSmoke;
            ChtPhotoResisters.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            ChtPhotoResisters.ChartAreas[0].CursorX.AutoScroll = true;
            ChtPhotoResisters.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            ChtPhotoResisters.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
            ChtPhotoResisters.ChartAreas[0].AxisX.ScrollBar.ButtonColor = Color.LightSteelBlue;

            ChtPhotoResisters.Series.Clear();//Series1 값 지움
            ChtPhotoResisters.Series.Add("PhotoValue");
            ChtPhotoResisters.Series[0].ChartType = SeriesChartType.Line;
            ChtPhotoResisters.Series[0].Color = Color.LightCoral;
            ChtPhotoResisters.Series[0].BorderWidth = 3;

            //범례 삭제
            if (ChtPhotoResisters.Legends.Count>0)
            {
                for (int i = 0; i < ChtPhotoResisters.Legends.Count; i++)
                {
                    ChtPhotoResisters.Legends.RemoveAt(i);
                }
            }

            ChtPhotoResisters.Padding = new Padding();
                



        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            //TODO 나중에 실제 작업시 작성
        }
        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            //TODO 나중에 실제 작업시 작성
        }

        
        /// <summary>
        /// 시뮬레이션 시작
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MunBeginSimulation_Click(object sender, EventArgs e)
        {
            IsSimulation = true;
            timerSimul.Enabled = true;
            timerSimul.Interval = 1000;//1초
            timerSimul.Tick += Timersimul_Tick;
            timerSimul.Start();
        }
        private long timespan = 0;
        private int randMaxVal = 0;
        private void Timersimul_Tick(object sender, EventArgs e)
        
        {
            timespan += 1;
            var temp = timespan % 30;
            if (temp.ToString().Length==2)
            {
                randMaxVal = 980;
            }
            else
            {
                randMaxVal = 120;
            }
            int value = randPhoto.Next(10, 1023); //1~1023까지 사이의 값
            ShowSensorValue(value.ToString());

        }
        /// <summary>
        /// 센서값 화면 출력메서드
        /// </summary>
        private void ShowSensorValue(string value)
        {
            int.TryParse(value, out int v);

            var currentTime = DateTime.Now;
            SensorData data = new SensorData(currentTime, v, IsSimulation);
            sensors.Add(data);
            InsertTable(data);



            //센서값 갯수
            TxtSensorNum.Text =$"{ sensors.Count}";
            //프로그레스바 현재값 출력
            PrbPhotoresister.Value = v;
            //리스트박스에 데이터 출력
            var item = $"{currentTime.ToString("yyyy-MM-dd")}\t{v}";
            LsbPhotoResistors.Items.Add(item);
            LsbPhotoResistors.SelectedIndex = LsbPhotoResistors.Items.Count - 1;//스크롤 처리

            //차트에 데이터 출력
            ChtPhotoResisters.Series[0].Points.Add(v);

            //200개 넘으면
            ChtPhotoResisters.ChartAreas[0].AxisX.Minimum = 0;
            ChtPhotoResisters.ChartAreas[0].AxisX.Maximum = (sensors.Count >= xCount) ? sensors.Count : xCount;

            //Zoom처리
            if (sensors.Count > xCount)
                ChtPhotoResisters.ChartAreas[0].AxisX.ScaleView.Zoom(sensors.Count - xCount, sensors.Count);
            else
                ChtPhotoResisters.ChartAreas[0].AxisX.ScaleView.Zoom(0, xCount);

            //BtnDisplay 표시
            if (IsSimulation)
                BtnDisplay.Text = v.ToString();
            else
            {
                BtnDisplay.Text = "~" + "\n" + v.ToString();
            }
        }
        /// <summary>
        /// IOTData 데이터베이스 내 Tbl-PhotoResistor 테이블에 센서데이터 입력
        /// </summary>
        /// <param name="data"></param>
        private void InsertTable(SensorData data)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    var query = $"INSERT INTO Tbl_PhotoResistor " +
                        $" (CurrentDt,Value,SimulFlag) " +
                        $" values " +
                        $" ('{data.current.ToString("yyyy-MM-dd HH:mm:ss")}','{data.Value}','{(data.SimulFlag==true ? "1":"0")} ');";
                    
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"예외 발생 : {ex.Message}");
            }
        }


        /// <summary>
        /// 시뮬레이션 끝
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuEndSimulation_Click(object sender, EventArgs e)
        {
            IsSimulation = false;
            timerSimul.Stop();

        }
        /// <summary>
        /// 종료버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuExit_Click(object sender, EventArgs e)
        {
            if (IsSimulation)
            {
                MessageBox.Show("시뮬레이션 멈춘후 프로그램을 종료하세요.", "종료", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Environment.Exit(0);
        }

        private void BtnViewAll_Click(object sender, EventArgs e)
        {
            ChtPhotoResisters.ChartAreas[0].AxisX.Minimum = 0;
            ChtPhotoResisters.ChartAreas[0].AxisX.Maximum = sensors.Count;

            ChtPhotoResisters.ChartAreas[0].AxisX.ScaleView.Zoom(0,sensors.Count);
            ChtPhotoResisters.ChartAreas[0].AxisX.Interval = sensors.Count / 4;
        }

        private void BtnZoom_Click(object sender, EventArgs e)
        {
            ChtPhotoResisters.ChartAreas[0].AxisX.Minimum = 0;
            ChtPhotoResisters.ChartAreas[0].AxisX.Maximum = sensors.Count;

            ChtPhotoResisters.ChartAreas[0].AxisX.ScaleView.Zoom(sensors.Count - xCount, sensors.Count);
            ChtPhotoResisters.ChartAreas[0].AxisX.Interval = xCount / 4;
        }

        ///

    }
}
