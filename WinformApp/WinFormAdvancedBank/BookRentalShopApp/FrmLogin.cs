﻿using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRentalShopApp
{
    public partial class FrmLogin : MetroForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {

            var strUserId = "";

            if (string.IsNullOrEmpty(TxtUserId.Text)||string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show(this, "아이디/패스워드를 입력하세요.", "오류", 
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    //SqlCommand 생성
                    SqlCommand cmd = new SqlCommand();
                    //SqlInjection 해킹을 막기위해
                    SqlParameter param;
                    //sqlDataReader 실행(1)
                    SqlDataReader reader = cmd.ExecuteReader();

                    // reader로 처리
                    reader.Read();
                    strUserId = reader["userID"] != null ? reader["userID"].ToString() : "";
                    reader.Close();
                    //확인 MessageBox.show(strUserID);
                    if (string.IsNullOrEmpty(strUserId))
                    {
                        MetroMessageBox.Show(this,"접속실패","로그인실패", MessageBoxButtons.OK,MessageBoxIcon.Error)
                            return;
                    }
                    else
                    {
                        var updateQuery = $@"UPDATE "
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Error : {ex.Message}", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //완전 종료
        }

        private void TxtUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
                TxtPassword.Focus();
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
                BtnLogin_Click(sender, e);   
        }
    }
}
