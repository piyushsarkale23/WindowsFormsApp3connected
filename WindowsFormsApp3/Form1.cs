using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Employeeid.Text
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnwrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"A\DotNet20DecBatch\dept.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(txtEmployeeid.Text));
                bw.Write(txtEmployeename.Text);
                bw.Write(txtEmployeesal.Text);
                bw.Close();
                fs.Close();
                MessageBox.Show("Data added to file");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
}
