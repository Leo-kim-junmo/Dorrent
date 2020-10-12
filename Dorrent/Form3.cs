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
    public partial class Form_join : Form
    {
        public Form_join()
        {
            InitializeComponent();
        }

        private void bt_join_Click(object sender, EventArgs e)
        {
            // 회원가입 버튼
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            // 나가기 버튼
            this.Close();
        }
    }
}
