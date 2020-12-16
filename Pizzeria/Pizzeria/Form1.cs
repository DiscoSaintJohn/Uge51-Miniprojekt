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
        public string[] nr1 = new string[] { "normal", "1", "Margerita", "75", "Pizzabund", "tomatsovs", "ost", "oregano" };   //liste med pizzaer og informationer {str, nr, navn, pris, ingredienser...}
        public string[] nr2 = new string[] { "normal", "2", "Classic",   "80", "Pizzabund", "tomatsovs", "ost", "oregano", "skinke" };
        public string[] nr3 = new string[] { "normal", "3", "Pepperoni", "80", "Pizzabund", "tomatsovs", "ost", "oregano", "pepperoni" };

        public string[] order = new string[] { };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < nr1.Length - 1; i++)
            {
                tableLayoutPanel1.Text = nr1[i];
            }
        }

        public void AddToCart(int quantity, string[] details)
        {
            for (int i = 0; i < 3; i++)     //Udfylder de første 4 fælter i details[]: nummer, navn og pris
            {
                order[i] = details[i];
            }

            string[] ingredients = new string[] { };
            
            for (int i = 4; i <= details.Length; i++)   //loopet udfylder alle ingredienser fra details[] til ingredients[]
            {
                ingredients[i-4] = details[i];
            }

            Cart(quantity, details, ingredients);       // sender til Cart
        }

        public void Cart(int quantity, string[] details, string[] ingredients)
        {
            string[] inCart = new string[] { };             // Ny string[] til at holde den sidste ordre
            string[] inCartIngredients = new string[] { };  // ... Til ingredienser 
            
            for (int i = 0; i <= details.Length; i++)
            {
                inCart[i] = details[i];
            }

            for (int i = 0; i <= ingredients.Length; i++)
            {
                inCartIngredients[i] = ingredients[i];
            }

        }

        public void ShowCart()
        {

        }

        private void displayMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void alm1_Click(object sender, EventArgs e)     // almx_Click sender 1 pizza til AddToCart
        {
            AddToCart(1, nr1);
        }

        private void addFam1_Click(object sender, EventArgs e)  // famx_Click ændre "normal" til "familie" og sender til AddToCart
        {
            nr1[0] = "familie";
            AddToCart(1, nr1);
            nr1[0] = "normal";
        }

        private void alm2_Click(object sender, EventArgs e)
        {
            AddToCart(1, nr2);
        }

        private void addFam2_Click(object sender, EventArgs e)
        {
            nr2[0] = "familie";
            AddToCart(1, nr2);
            nr2[0] = "normal";
        }

        private void alm3_Click(object sender, EventArgs e)
        {
            AddToCart(1, nr3);
        }

        private void addFam3_Click(object sender, EventArgs e)
        {
            nr3[0] = "familie";
            AddToCart(1, nr3);
            nr3[0] = "normal";
        }

        private void ordre_Click(object sender, EventArgs e)
        {
            ShowCart();
        }

        private void menuList_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.Write("nr. " + nr1[0] + "  -  " + nr1[1]);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void displayMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
