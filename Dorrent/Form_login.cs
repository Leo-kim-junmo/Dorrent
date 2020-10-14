using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dorrent
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            // 로그인 버튼

            this.Hide();
            //Form_main Form_main = new Form_main();
            //Form_main.Show();
            //Form_main.FormClosed += Form_login_open;

            Form_main2 Form_main2 = new Form_main2();
            Form_main2.Show();
            Form_main2.FormClosed += Form_login_open;
        }

        private void bt_join_Click(object sender, EventArgs e)
        {
            // 회원가입 버튼

            this.Hide();
            Form_join Form_join = new Form_join();
            Form_join.Show();
            Form_join.FormClosed += Form_login_open;
        }

        private void bt_find_Click(object sender, EventArgs e)
        {
            // 찾기 버튼

            this.Hide();
            Form_find Form_find = new Form_find();
            Form_find.Show();
            Form_find.FormClosed += Form_login_open;
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            // 나가기 버튼
            Application.Exit();
        }

        public void Form_login_open(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
