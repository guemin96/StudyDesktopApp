using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelTestApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LblAutosize.Text = LblManualSize.Text = string.Empty;
        }

        private void BtnPushText_Click(object sender, EventArgs e)
        {
            string sample1 = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ratione perferendis doloribus cumque fuga amet eius. Delectus voluptate numquam veritatis, est perspiciatis similique ipsum fuga adipisci. Reiciendis ipsa aliquam mollitia delectus.";
            string sample2 = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Error ratione corporis sit nemo sequi dignissimos perferendis atque hic reiciendis dolor recusandae inventore ea ipsum, quos quidem unde quo ut id.";

            LblAutosize.Text = sample1;
            LblManualSize.Text = sample2;
        }
    }
}
