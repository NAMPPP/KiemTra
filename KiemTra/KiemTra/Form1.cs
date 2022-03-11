using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = textboxusername.Text;
            String password = textboxmatkhau.Text;
            if (username == "admin" && password == "admin")
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
        }
    }
}
