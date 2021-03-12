using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotePadApp
{
    public partial class FrmMain : Form
    {
        public bool IsModify { get; set; }

        private const string firstFileName = "noname.txt";

        private string currfileName = "noname.txt";
        public FrmMain()
        {
            InitializeComponent();
        }

        private void MnuNewFile_Click(object sender, EventArgs e)
        {
            //TODO : 만약 작업중인 파일이 있으면 저장처리
            ProcessSaveFileBeforeClose();

            TxtMain.Text = "";
            IsModify = false;
            currfileName = "noname.txt";
        }
        private void ProcessSaveFileBeforeClose()
        {
            if (IsModify)
            {
                DialogResult answer = MessageBox.Show("변경사항이 있습니다. 저장하시겠습니까?", "저장",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer==DialogResult.Yes)
                {
                    if (currfileName == firstFileName)
                    {
                        if (DlgSaveText.ShowDialog() == DialogResult.OK)
                        {
                            StreamWriter sw = File.CreateText(DlgSaveText.FileName);
                            sw.WriteLine(TxtMain.Text);
                            sw.Close();
                        }
                        else
                        {
                            StreamWriter sw = File.CreateText(currfileName);
                            sw.WriteLine(TxtMain.Text);
                            sw.Close();
                        }
                    }
                }
                
            }
        }


        private void MunOpenfile_Click(object sender, EventArgs e)
        {
            ProcessSaveFileBeforeClose();

            DlgOpenText.ShowDialog();
            currfileName = DlgOpenText.FileName;
            this.Text = $"{currfileName}-내 메모장";

            try
            {
                StreamReader sr = File.OpenText(currfileName);
                TxtMain.Text = sr.ReadToEnd();

                IsModify = false;
                sr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void MnuSavefile_Click(object sender, EventArgs e)
        {
            if (currfileName == firstFileName)
            {
                
                if (DlgSaveText.ShowDialog() == DialogResult.OK)
                {
                    currfileName = DlgSaveText.FileName;
                }
                StreamWriter sw = File.CreateText(currfileName);
                sw.WriteLine(TxtMain.Text);

                IsModify = false;
                sw.Close();

                this.Text = $"{currfileName} - 내 메모장";
            }
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            ProcessSaveFileBeforeClose();
            Environment.Exit(0);
        }

        private void MnuCopy_Click(object sender, EventArgs e)
        {
            var contents = ActiveControl as RichTextBox;
            if (contents != null)
            {
                Clipboard.SetDataObject(contents.SelectedText);
                MessageBox.Show(contents.SelectedText);
            }
        }

        private void MnuEdit_Click(object sender, EventArgs e)
        {
            var contents = ActiveControl as RichTextBox;
            if (contents != null)
            {

                IDataObject data = Clipboard.GetDataObject();
                contents.SelectedText = data.GetData(DataFormats.Text).ToString();
                IsModify = true;
            }
        }

        private void MnuAbout_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("메모장 v1.0입니다.");
            var form = new AboutThis();
            form.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DlgSaveText.Filter =DlgOpenText.Filter = "Text file (*.txt)|*.txt|Log file (*.log)|*.log";
            this.Text = $"{currfileName} - 내 메모장";
            IsModify = false;
        }

        private void TxtMain_TextChanged(object sender, EventArgs e)
        {
            IsModify = true;
            this.Text = $"{currfileName}* - 내 메모장";
        }
    }
}
