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

        int orderCount = 0;
        public int x = 0;
        string[] order = new string[] { };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 

        }

        public void AddToCart(int quantity, string[] details)
        {
            orderCount++;
            string stringCount = Convert.ToString(orderCount);
            string[] newOrder = new string[] {details[0]};     //Første string kommer ind i order[] nummeret på pizzaenb

            for (int i = 0; i < 3; i++) //Udfylder de 3 næste fælter i details[]: nummer, navn og pris
            {
                newOrder[i+1] = details[i];
            }

            string[] ingredients = new string[] { };
            
            for (int i = 3; i <= details.Length; i++)   //loopet udfylder alle ingredientser fra details[] til ingredients[]
            {
                ingredients[i-3] = details[i];
            }

            Cart(details, ingredients);
        }

        public void Cart(string[] details, string[] ingredients)
        {
            x++;
            
            for (int i = 0; i <= details.Length; i++)
            {
                order[i] = details[i];
            }            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void alm1_Click(object sender, EventArgs e)
        {
            AddToCart(1, nr1);
        }

        private void alm2_Click(object sender, EventArgs e)
        {
            AddToCart(1, nr2);
        }

        private void alm3_Click(object sender, EventArgs e)
        {
            AddToCart(1, nr3);
        }

        private void ordre_Click(object sender, EventArgs e)
        {

        }
    }
}
