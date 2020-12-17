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
        public string[] nr1 = new string[] { "normal", "1", "Margerita", "40", "75", "115", "Pizzabund", "tomatsovs", "ost", "oregano" };   //liste med pizzaer og informationer {str, nr, navn, priser, ingredienser...}
        public string[] nr2 = new string[] { "normal", "2", "Classic",  "45", "80", "120", "Pizzabund", "tomatsovs", "ost", "oregano", "skinke" };
        public string[] nr3 = new string[] { "normal", "3", "Pepperoni", "45", "80", "120", "Pizzabund", "tomatsovs", "ost", "oregano", "pepperoni" };

        public string[] order = new string[] { };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string pizza1 = nr1[1] + " - " + nr1[2];
            string pizza2 = nr2[1] + " - " + nr2[2];
            string pizza3 = nr3[1] + " - " + nr3[2];

            string ingredients1 = "";
            string ingredients2 = "";
            string ingredients3 = "";

            for (int i = 6; i < nr1.Length; i++)
            {
                ingredients1 += nr1[i] + ", ";
            }
            for (int i = 6;i < nr2.Length; i++)
            {
                ingredients2 += nr2[i] + ", ";
            }
            for (int i = 6; i < nr3.Length; i++)
            {
                ingredients3 += nr3[i] + ", ";
            }

            nameList.Items.Add(pizza1);
            nameList.Items.Add("");
            nameList.Items.Add("");
            nameList.Items.Add("");
            nameList.Items.Add(pizza2);
            nameList.Items.Add("");
            nameList.Items.Add("");
            nameList.Items.Add("");
            nameList.Items.Add(pizza3);

            ingredientList.Items.Add("- " + ingredients1);
            ingredientList.Items.Add("");
            ingredientList.Items.Add("");
            ingredientList.Items.Add("");
            ingredientList.Items.Add("-----------------------------------------------------------------------------------------------------");
            ingredientList.Items.Add("- " + ingredients2);
            ingredientList.Items.Add("");
            ingredientList.Items.Add("");
            ingredientList.Items.Add("");
            ingredientList.Items.Add("-----------------------------------------------------------------------------------------------------");
            ingredientList.Items.Add("- " + ingredients3);

            //this.Controls.Add(nameList);
        }

        public void AddToCart(int quantity, string[] details)
        { 
            if (details[0] == "lille")          //Udfylder de første 4 fælter i details[]:str, nummer, navn og pris på lille pizza
            {
                for (int i = 0; i <= 3; i++)     
                {
                    order[i] = details[i];
                }
            }
            
            if (details[0] == "normal")          //... normal pizza
            {
                for ( int i = 0; i < 2; i++)
                {
                    order[i] = details[i];
                }
                order[3] = details[5];
            }

            if (details[0] == "familie")        // ... familie pizza
            {
                for ( int i = 0; i < 2; i++)
                {
                    order[i] = details[i];
                }
                order[3] = details[5];
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
            // var cartList = new Form();
            // cartList.Show(this);
        }

        private void displayMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lille1_Click(object sender, EventArgs e)   // lillex ændrer str og sneder tio AddToCart
        {
            nr1[0] = "lille";
            AddToCart(1, nr1);
            nr1[0] = "normal";
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

        private void lille2_Click(object sender, EventArgs e)
        {
            nr2[0] = "lille";
            AddToCart(1, nr2);
            nr2[0] = "normal";
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

        private void lille3_Click(object sender, EventArgs e)
        {
            nr3[0] = "lille";
            AddToCart(1, nr3);
            nr3[0] = "normal";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void displayMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)       // check boksen ændre normalbund til fuldkorn o gomvendt
        {
            if (fuldkorn1.Checked)
                nr1[6] = "Fuldkornsbund";
            if (!fuldkorn1.Checked)
                nr2[6] = "Pizzabund";
        }

        private void fuldkorn2_CheckedChanged(object sender, EventArgs e)
        {
            if (fuldkorn2.Checked)
                nr2[6] = "Fuldkornsbund";
            if (!fuldkorn2.Checked)
                nr2[6] = "Pizzabund";
        }

        private void fuldkorn3_CheckedChanged(object sender, EventArgs e)
        {
            if (fuldkorn3.Checked)
                nr3[6] = "Fuldkornsbund";
            if (!fuldkorn3.Checked)
                nr3[6] = "Pizzabund";
        }
    }
}
