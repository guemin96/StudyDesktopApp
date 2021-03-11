using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextViewerApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DlgSelectText.FileName = "Select a text file";//파일 선택하기는 빈칸에 파일 선택하기 전까지 들어가는 문구
            DlgSelectText.Filter = "Text files (*.txt)|*.txt";// 파일 선택 확장자
            DlgSelectText.Title = "Open text file";//파일 선택창 제일 위 이름
        }

        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            if (DlgSelectText.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    var filePath = DlgSelectText.FileName;
                    using (FileStream fs = File.Open(filePath, FileMode.Open))
                    {
                        Process.Start(@"C:\DEV\Notepad++\notepad++.exe", filePath);
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"{ ex.Message}");
                }
            }
        }
    }
}
