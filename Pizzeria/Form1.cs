using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public void Pizzas()
        {
            string[] nr1 = new string[] { "75,-", "tomatsovs", "ost", "oregano" };
            string[] nr2 = new string[] { "80,-", "tomatsovs", "ost", "oregano", "skinke" };
            string[] nr3 = new string[] { "80,-", "tomatsovs", "ost", "oregano", "pepperoni" };
        }

        private void Form1_Load(object sender, EventArgs e)
        { 

        }

        public void Cart()
        {

        }
    }
}
