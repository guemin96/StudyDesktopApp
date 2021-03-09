
namespace CheckBoxWinApp
{
    partial class Frmmain
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
            this.label1 = new System.Windows.Forms.Label();
            this.ChkApple = new System.Windows.Forms.CheckBox();
            this.ChkPear = new System.Windows.Forms.CheckBox();
            this.ChkStrawberry = new System.Windows.Forms.CheckBox();
            this.ChkBanana = new System.Windows.Forms.CheckBox();
            this.ChkOrange = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ChkDorian = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 16F);
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "질문 :  좋아하는 과일을 모두 선택하시오";
            // 
            // ChkApple
            // 
            this.ChkApple.AutoSize = true;
            this.ChkApple.Font = new System.Drawing.Font("굴림", 14F);
            this.ChkApple.Location = new System.Drawing.Point(16, 104);
            this.ChkApple.Name = "ChkApple";
            this.ChkApple.Size = new System.Drawing.Size(66, 23);
            this.ChkApple.TabIndex = 1;
            this.ChkApple.Text = "사과";
            this.ChkApple.UseVisualStyleBackColor = true;
            // 
            // ChkPear
            // 
            this.ChkPear.AutoSize = true;
            this.ChkPear.Font = new System.Drawing.Font("굴림", 14F);
            this.ChkPear.Location = new System.Drawing.Point(16, 147);
            this.ChkPear.Name = "ChkPear";
            this.ChkPear.Size = new System.Drawing.Size(47, 23);
            this.ChkPear.TabIndex = 2;
            this.ChkPear.Text = "배";
            this.ChkPear.UseVisualStyleBackColor = true;
            // 
            // ChkStrawberry
            // 
            this.ChkStrawberry.AutoSize = true;
            this.ChkStrawberry.Font = new System.Drawing.Font("굴림", 14F);
            this.ChkStrawberry.Location = new System.Drawing.Point(16, 190);
            this.ChkStrawberry.Name = "ChkStrawberry";
            this.ChkStrawberry.Size = new System.Drawing.Size(66, 23);
            this.ChkStrawberry.TabIndex = 3;
            this.ChkStrawberry.Text = "딸기";
            this.ChkStrawberry.UseVisualStyleBackColor = true;
            // 
            // ChkBanana
            // 
            this.ChkBanana.AutoSize = true;
            this.ChkBanana.Font = new System.Drawing.Font("굴림", 14F);
            this.ChkBanana.Location = new System.Drawing.Point(16, 233);
            this.ChkBanana.Name = "ChkBanana";
            this.ChkBanana.Size = new System.Drawing.Size(85, 23);
            this.ChkBanana.TabIndex = 4;
            this.ChkBanana.Text = "바나나";
            this.ChkBanana.UseVisualStyleBackColor = true;
            // 
            // ChkOrange
            // 
            this.ChkOrange.AutoSize = true;
            this.ChkOrange.Font = new System.Drawing.Font("굴림", 14F);
            this.ChkOrange.Location = new System.Drawing.Point(16, 276);
            this.ChkOrange.Name = "ChkOrange";
            this.ChkOrange.Size = new System.Drawing.Size(85, 23);
            this.ChkOrange.TabIndex = 5;
            this.ChkOrange.Text = "오렌지";
            this.ChkOrange.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 348);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(132, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "결과";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChkDorian
            // 
            this.ChkDorian.AutoSize = true;
            this.ChkDorian.Font = new System.Drawing.Font("굴림", 14F);
            this.ChkDorian.Location = new System.Drawing.Point(16, 319);
            this.ChkDorian.Name = "ChkDorian";
            this.ChkDorian.Size = new System.Drawing.Size(85, 23);
            this.ChkDorian.TabIndex = 7;
            this.ChkDorian.Text = "두리안";
            this.ChkDorian.UseVisualStyleBackColor = true;
            // 
            // Frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 405);
            this.Controls.Add(this.ChkDorian);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChkOrange);
            this.Controls.Add(this.ChkBanana);
            this.Controls.Add(this.ChkStrawberry);
            this.Controls.Add(this.ChkPear);
            this.Controls.Add(this.ChkApple);
            this.Controls.Add(this.label1);
            this.Name = "Frmmain";
            this.Text = "Favorite Fruit App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChkApple;
        private System.Windows.Forms.CheckBox ChkPear;
        private System.Windows.Forms.CheckBox ChkStrawberry;
        private System.Windows.Forms.CheckBox ChkBanana;
        private System.Windows.Forms.CheckBox ChkOrange;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ChkDorian;
    }
}

