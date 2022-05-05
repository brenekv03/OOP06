using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SportovecAmater sportovec = new SportovecAmater("Bohdan", 80, 180);
            sportovec.Trenuj(5);
            MessageBox.Show( sportovec.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SportovecProfesional sportovec = new SportovecProfesional("Bodnar", 80, 180,100);
            sportovec.Trenuj(5);
            MessageBox.Show( sportovec.ToString());
        }
    }
}
