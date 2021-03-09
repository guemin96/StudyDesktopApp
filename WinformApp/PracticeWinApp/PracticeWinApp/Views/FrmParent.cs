using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeWinApp.Views// 여기만 바꿀 것이 아니라 designer쪽도 같이 바꿔줘야한다. 속성=명사, 이벤트=동사
{
    public partial class FrmParent : Form
    {
        public FrmParent()
        {
            InitializeComponent();
        }

        private void FrmParent_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(800, 600);

            FrmChild frm = new FrmChild();
            this.AddOwnedForm(frm);

            frm.Show();//모달리스
        }
    }
}
