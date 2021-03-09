
namespace RadioWinApp
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnResult = new System.Windows.Forms.Button();
            this.RdbKorea = new System.Windows.Forms.RadioButton();
            this.RdbChina = new System.Windows.Forms.RadioButton();
            this.RdbJapan = new System.Windows.Forms.RadioButton();
            this.RdbEtc = new System.Windows.Forms.RadioButton();
            this.RdbMan = new System.Windows.Forms.RadioButton();
            this.RdbWoman = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnResult
            // 
            this.BtnResult.Location = new System.Drawing.Point(250, 152);
            this.BtnResult.Name = "BtnResult";
            this.BtnResult.Size = new System.Drawing.Size(98, 49);
            this.BtnResult.TabIndex = 0;
            this.BtnResult.Text = "결과";
            this.BtnResult.UseVisualStyleBackColor = true;
            this.BtnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // RdbKorea
            // 
            this.RdbKorea.AutoSize = true;
            this.RdbKorea.Location = new System.Drawing.Point(20, 28);
            this.RdbKorea.Name = "RdbKorea";
            this.RdbKorea.Size = new System.Drawing.Size(71, 16);
            this.RdbKorea.TabIndex = 1;
            this.RdbKorea.TabStop = true;
            this.RdbKorea.Text = "대한민국";
            this.RdbKorea.UseVisualStyleBackColor = true;
            // 
            // RdbChina
            // 
            this.RdbChina.AutoSize = true;
            this.RdbChina.Location = new System.Drawing.Point(20, 65);
            this.RdbChina.Name = "RdbChina";
            this.RdbChina.Size = new System.Drawing.Size(47, 16);
            this.RdbChina.TabIndex = 1;
            this.RdbChina.TabStop = true;
            this.RdbChina.Text = "중국";
            this.RdbChina.UseVisualStyleBackColor = true;
            // 
            // RdbJapan
            // 
            this.RdbJapan.AutoSize = true;
            this.RdbJapan.Location = new System.Drawing.Point(20, 102);
            this.RdbJapan.Name = "RdbJapan";
            this.RdbJapan.Size = new System.Drawing.Size(47, 16);
            this.RdbJapan.TabIndex = 1;
            this.RdbJapan.TabStop = true;
            this.RdbJapan.Text = "일본";
            this.RdbJapan.UseVisualStyleBackColor = true;
            // 
            // RdbEtc
            // 
            this.RdbEtc.AutoSize = true;
            this.RdbEtc.Location = new System.Drawing.Point(20, 139);
            this.RdbEtc.Name = "RdbEtc";
            this.RdbEtc.Size = new System.Drawing.Size(51, 16);
            this.RdbEtc.TabIndex = 1;
            this.RdbEtc.TabStop = true;
            this.RdbEtc.Text = "그 외";
            this.RdbEtc.UseVisualStyleBackColor = true;
            // 
            // RdbMan
            // 
            this.RdbMan.AutoSize = true;
            this.RdbMan.Location = new System.Drawing.Point(35, 28);
            this.RdbMan.Name = "RdbMan";
            this.RdbMan.Size = new System.Drawing.Size(35, 16);
            this.RdbMan.TabIndex = 1;
            this.RdbMan.TabStop = true;
            this.RdbMan.Text = "남";
            this.RdbMan.UseVisualStyleBackColor = true;
            // 
            // RdbWoman
            // 
            this.RdbWoman.AutoSize = true;
            this.RdbWoman.Location = new System.Drawing.Point(90, 28);
            this.RdbWoman.Name = "RdbWoman";
            this.RdbWoman.Size = new System.Drawing.Size(35, 16);
            this.RdbWoman.TabIndex = 1;
            this.RdbWoman.TabStop = true;
            this.RdbWoman.Text = "여";
            this.RdbWoman.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdbEtc);
            this.groupBox1.Controls.Add(this.RdbJapan);
            this.groupBox1.Controls.Add(this.RdbChina);
            this.groupBox1.Controls.Add(this.RdbKorea);
            this.groupBox1.Location = new System.Drawing.Point(27, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 175);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "국적";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RdbWoman);
            this.groupBox2.Controls.Add(this.RdbMan);
            this.groupBox2.Location = new System.Drawing.Point(196, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 64);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "성별";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 214);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnResult;
        private System.Windows.Forms.RadioButton RdbKorea;
        private System.Windows.Forms.RadioButton RdbChina;
        private System.Windows.Forms.RadioButton RdbJapan;
        private System.Windows.Forms.RadioButton RdbEtc;
        private System.Windows.Forms.RadioButton RdbMan;
        private System.Windows.Forms.RadioButton RdbWoman;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

