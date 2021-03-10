
namespace ListViewApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RbbDetail = new System.Windows.Forms.RadioButton();
            this.RbbList = new System.Windows.Forms.RadioButton();
            this.RbbSmallIcon = new System.Windows.Forms.RadioButton();
            this.RbbLargeIcon = new System.Windows.Forms.RadioButton();
            this.LsvProducts = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSelected = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImgSmallIcon = new System.Windows.Forms.ImageList(this.components);
            this.ImgLargeIcon = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // RbbDetail
            // 
            this.RbbDetail.AutoSize = true;
            this.RbbDetail.Location = new System.Drawing.Point(33, 12);
            this.RbbDetail.Name = "RbbDetail";
            this.RbbDetail.Size = new System.Drawing.Size(59, 16);
            this.RbbDetail.TabIndex = 0;
            this.RbbDetail.TabStop = true;
            this.RbbDetail.Text = "자세히";
            this.RbbDetail.UseVisualStyleBackColor = true;
            this.RbbDetail.CheckedChanged += new System.EventHandler(this.RbbDetail_CheckedChanged);
            // 
            // RbbList
            // 
            this.RbbList.AutoSize = true;
            this.RbbList.Location = new System.Drawing.Point(149, 12);
            this.RbbList.Name = "RbbList";
            this.RbbList.Size = new System.Drawing.Size(59, 16);
            this.RbbList.TabIndex = 1;
            this.RbbList.TabStop = true;
            this.RbbList.Text = "리스트";
            this.RbbList.UseVisualStyleBackColor = true;
            this.RbbList.CheckedChanged += new System.EventHandler(this.RbbList_CheckedChanged);
            // 
            // RbbSmallIcon
            // 
            this.RbbSmallIcon.AutoSize = true;
            this.RbbSmallIcon.Location = new System.Drawing.Point(265, 12);
            this.RbbSmallIcon.Name = "RbbSmallIcon";
            this.RbbSmallIcon.Size = new System.Drawing.Size(87, 16);
            this.RbbSmallIcon.TabIndex = 2;
            this.RbbSmallIcon.TabStop = true;
            this.RbbSmallIcon.Text = "작은 아이콘";
            this.RbbSmallIcon.UseVisualStyleBackColor = true;
            this.RbbSmallIcon.CheckedChanged += new System.EventHandler(this.RbbSmallIcon_CheckedChanged);
            // 
            // RbbLargeIcon
            // 
            this.RbbLargeIcon.AutoSize = true;
            this.RbbLargeIcon.Location = new System.Drawing.Point(409, 12);
            this.RbbLargeIcon.Name = "RbbLargeIcon";
            this.RbbLargeIcon.Size = new System.Drawing.Size(75, 16);
            this.RbbLargeIcon.TabIndex = 3;
            this.RbbLargeIcon.TabStop = true;
            this.RbbLargeIcon.Text = "큰 아이콘";
            this.RbbLargeIcon.UseVisualStyleBackColor = true;
            this.RbbLargeIcon.CheckedChanged += new System.EventHandler(this.RbbLargeIcon_CheckedChanged);
            // 
            // LsvProducts
            // 
            this.LsvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LsvProducts.FullRowSelect = true;
            this.LsvProducts.GridLines = true;
            this.LsvProducts.HideSelection = false;
            this.LsvProducts.LargeImageList = this.ImgLargeIcon;
            this.LsvProducts.Location = new System.Drawing.Point(12, 34);
            this.LsvProducts.Name = "LsvProducts";
            this.LsvProducts.Size = new System.Drawing.Size(530, 250);
            this.LsvProducts.SmallImageList = this.ImgSmallIcon;
            this.LsvProducts.TabIndex = 4;
            this.LsvProducts.UseCompatibleStateImageBehavior = false;
            this.LsvProducts.View = System.Windows.Forms.View.Details;
            this.LsvProducts.SelectedIndexChanged += new System.EventHandler(this.LsvProducts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selected : ";
            // 
            // TxtSelected
            // 
            this.TxtSelected.Location = new System.Drawing.Point(229, 303);
            this.TxtSelected.Name = "TxtSelected";
            this.TxtSelected.Size = new System.Drawing.Size(310, 21);
            this.TxtSelected.TabIndex = 6;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "제품명";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "단가";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "수량";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "금액";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 100;
            // 
            // ImgSmallIcon
            // 
            this.ImgSmallIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgSmallIcon.ImageStream")));
            this.ImgSmallIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgSmallIcon.Images.SetKeyName(0, "controller.png");
            this.ImgSmallIcon.Images.SetKeyName(1, "ds.png");
            this.ImgSmallIcon.Images.SetKeyName(2, "ps4.png");
            this.ImgSmallIcon.Images.SetKeyName(3, "remote.png");
            this.ImgSmallIcon.Images.SetKeyName(4, "xbox.png");
            // 
            // ImgLargeIcon
            // 
            this.ImgLargeIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgLargeIcon.ImageStream")));
            this.ImgLargeIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgLargeIcon.Images.SetKeyName(0, "controller.png");
            this.ImgLargeIcon.Images.SetKeyName(1, "ds.png");
            this.ImgLargeIcon.Images.SetKeyName(2, "ps4.png");
            this.ImgLargeIcon.Images.SetKeyName(3, "remote.png");
            this.ImgLargeIcon.Images.SetKeyName(4, "xbox.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 340);
            this.Controls.Add(this.TxtSelected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LsvProducts);
            this.Controls.Add(this.RbbLargeIcon);
            this.Controls.Add(this.RbbSmallIcon);
            this.Controls.Add(this.RbbList);
            this.Controls.Add(this.RbbDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "상품리스트";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RbbDetail;
        private System.Windows.Forms.RadioButton RbbList;
        private System.Windows.Forms.RadioButton RbbSmallIcon;
        private System.Windows.Forms.RadioButton RbbLargeIcon;
        private System.Windows.Forms.ListView LsvProducts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSelected;
        private System.Windows.Forms.ImageList ImgSmallIcon;
        private System.Windows.Forms.ImageList ImgLargeIcon;
    }
}

