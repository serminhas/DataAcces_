using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp5.Models;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();
        private void Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Categories.ToList();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
