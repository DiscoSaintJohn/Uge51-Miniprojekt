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
        public string[] nr1 = new string[] { "1", "Margerita", "75", "tomatsovs", "ost", "oregano" };
        public string[] nr2 = new string[] { "2", "Classic", "80", "tomatsovs", "ost", "oregano", "skinke" };
        public string[] nr3 = new string[] { "3", "Pepperoni", "80", "tomatsovs", "ost", "oregano", "pepperoni" };

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 

        }

        public void Cart(int quantity, string[] details)
        {
            int orderCount = 0;
            orderCount++;
            string stringCount = Convert.ToString(orderCount);
            string[] order = new string[] {details[0]};     //Første string kommer ind i order[] nummeret på pizzaen

            for (int i = 0; i < 3; i++) //Udfylder de 3 næste fælter i details[]: nummer, navn og pris
            {
                order[i+1] = details[i];
            }

            string[] ingredients = new string[] { };
            
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void alm1_Click(object sender, EventArgs e)
        {

        }

        private void alm2_Click(object sender, EventArgs e)
        {

        }

        private void alm3_Click(object sender, EventArgs e)
        {

        }

        private void ordre_Click(object sender, EventArgs e)
        {

        }
    }
}
