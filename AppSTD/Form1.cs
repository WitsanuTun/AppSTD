using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSTD
{
    public partial class Form1 : Form
    {
        int affective;
        int collection;
        int test;
        int total;
        double grade;
        public Form1()
        {
         
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tEffective_KeyUp(object sender, KeyEventArgs e)
        {
           // MessageBox.Show(tEffective.Text);
        }

        private void tEffective_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) ;
            {
                affective = Convert.ToInt32(tEffective.Text);
            } 
        }

        private void tCollect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                collection = Convert.ToInt32(tCollect.Text);
            }
        }

        private void tTest_TextChanged(object sender, EventArgs e)
        {
           
            {
            
            }
        }

        private void tCollect_TextChanged(object sender, EventArgs e)
        {

        }

        private void tEffective_TextChanged(object sender, EventArgs e)
        {

        }

        private void tTest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                collection = Convert.ToInt32(tTest.Text);
            }
        }

        private void tTotle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                collection = Convert.ToInt32(tTotle.Text);
            }
        }
    }
    private void gradeProcess()
    { totai = affective + CollectionChangeAction + testc; 
    


}
