using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class MForm : Form
    {
        public MForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbNam.Checked)
                MessageBox.Show("Bạn đã chọn giới tính Nam", "Thông báo");
        }

        private void rdbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNu.Checked)
                MessageBox.Show("Bạn đã chọn giới tính Nữ", "Thông báo");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnToMau_Click(object sender, EventArgs e)
        {
            if (rdbDo.Checked)
                txtHopMau.BackColor = Color.Red;
            else
                txtHopMau.BackColor = Color.Green;
        }
    }
}
