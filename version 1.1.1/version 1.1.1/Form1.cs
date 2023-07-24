using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using version_1._1._1.Forms;

namespace version_1._1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login a = new Login();  
            a . Visible = true;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddPoolTable a =  new AddPoolTable();
            a. Visible = true;
            this.Close();
        }
    }
}
