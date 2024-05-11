using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KevinAldana_FinalLab
{
    public partial class frmMain : Form
    {
        // Setting prices of menu items.

        // Main Dishes
        Food alfredoFettucine = new Food("Alfredo Fettucine", 15.99M);
        Food caponata = new Food("Caponata", 13.99M);
        Food lasagna = new Food("Lasagna", 15.99M);
        Food margaritaPizza = new Food("Margarita Reale Pizza", 17.99M);
        Food melanzane = new Food("Melanzane alla Parmigiana", 16.99M);
        Food fagioliSoup = new Food("Pasta Fagioli Soup", 16.99M);
        Food ravioliCrab = new Food("Ravioli with Crab", 17.99M);
        Food ribolettaSoup = new Food("Riboletta Soup", 14.99M);
        Food spaghettiBolognese = new Food("Spaghetti Bolognese", 13.99M);
        Food spicyChicken = new Food("Spicy Chicken Scarpariello", 15.99M);

        // Salads & side dishes

        Food caesarSalad = new Food("Caesar Salad", 9.99M);
        Food farroSalad = new Food("Farro Salad with Pomegranate & Goat Cheese", 11.99M);
        Food giardnieraSalad = new Food("Giardniera Salad with Ham & White Beans", 14.99M);
        Food italianSalad = new Food("Italian Sub Salad", 10.99M);
        Food mediterranean = new Food("Mediterranean Salad", 12.99M);
        Food chickpeaSalad = new Food("Tuna Chickpea Salad", 14.99M);

        // Beverages

        Food aperol = new Food("Aperol Spritz", 7.99M);
        Food bellini = new Food("Bellini Mango", 8.99M);
        Food soda = new Food("Campari Soda", 6.99M);
        Food lemonade = new Food("Lemonade", 6.99M);

        //Desserts

        Food cannoli = new Food("Cannoli", 7.99M);
        Food tiramisu = new Food("Tiramisu", 7.99M);
        Food panna = new Food("Panna Cotta", 7.99M);
        Food semiFreddo = new Food("Citrus Semifreddo", 8.99M);
        Food sfogliatella = new Food("Sfogliatella", 7.99M);

        public frmMain()
        {
            InitializeComponent();
        }

        private void setCount()
        {
            //Stores the counter of the numboxes in each menu item.

            // Main dishes
            alfredoFettucine.Count = (int)numBoxAlfredo.Value;
            caponata.Count = (int)numBoxCaponata.Value;
            lasagna.Count = (int)numBoxLasagna.Value;
            margaritaPizza.Count = (int)numBoxPizza.Value;
            melanzane.Count = (int)numBoxMelanzane.Value;
            fagioliSoup.Count = (int)numBoxPasta.Value;
            ravioliCrab.Count = (int)numBoxCrab.Value;
            ribolettaSoup.Count = (int)numBoxRiboletta.Value;
            spaghettiBolognese.Count = (int)numBoxSpaghetti.Value;
            spicyChicken.Count = (int)numBoxChicken.Value;
            //Salads and side dishes
            caesarSalad.Count = (int)numBoxCaesar.Value;
            farroSalad.Count = (int)numBoxFarro.Value;
            giardnieraSalad.Count = (int)numBoxGiardniera.Value;
            italianSalad.Count = (int)numBoxSubSalad.Value;
            mediterranean.Count = (int)numBoxMediterranean.Value;
            chickpeaSalad.Count = (int)numBoxMediterranean.Value;

            aperol.Count = (int) numBoxAperol.Value;
            bellini.Count = (int)numBoxBellini.Value;
            soda.Count = (int)numBoxSoda.Value;
            lemonade.Count = (int)numBoxLemonade.Value;
            //Desserts
            cannoli.Count = (int)numBoxCannoli.Value;
            tiramisu.Count = (int)numBoxTiramisu.Value;
            panna.Count = (int)numBoxPanna.Value;
            semiFreddo.Count = (int)numBoxCitrus.Value;
            sfogliatella.Count =(int)numBoxSfogliatella.Value;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            frmSplash frmSplash = new frmSplash();
            frmSplash.ShowDialog();
        }

        private void setMinimum()
        {
            // Main Dishes
            numBoxAlfredo.Minimum = alfredoFettucine.Count;
            numBoxCaponata.Minimum = caponata.Count;
            numBoxLasagna.Minimum = lasagna.Count;
            numBoxPizza.Minimum = margaritaPizza.Count;
            numBoxMelanzane.Minimum = melanzane.Count;
            numBoxPasta.Minimum = fagioliSoup.Count;
            numBoxCrab.Minimum = ravioliCrab.Count;
            numBoxRiboletta.Minimum = ribolettaSoup.Count;
            numBoxSpaghetti.Minimum = spaghettiBolognese.Count;
            numBoxChicken.Minimum = spicyChicken.Count;
            // Salads and Side Dishes
            numBoxCaesar.Minimum = caesarSalad.Count;
            numBoxFarro.Minimum = farroSalad.Count;
            numBoxGiardniera.Minimum = giardnieraSalad.Count;
            numBoxSubSalad.Minimum = italianSalad.Count;
            numBoxMediterranean.Minimum = mediterranean.Count;
            numBoxChickpea.Minimum = chickpeaSalad.Count;
            // Beverages
            numBoxAperol.Minimum = aperol.Count;
            numBoxBellini.Minimum = bellini.Count;
            numBoxSoda.Minimum = soda.Count;
            numBoxLemonade.Minimum = lemonade.Count;
            //Desserts
            numBoxCannoli.Minimum = cannoli.Count;
            numBoxTiramisu.Minimum = tiramisu.Count;
            numBoxPanna.Minimum = panna.Count;
            numBoxCitrus.Minimum = semiFreddo.Count;
            numBoxSfogliatella.Minimum = sfogliatella.Count;
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            frmOrder frmOrder = new frmOrder();
            frmOrder.ShowDialog();
                

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            frmOrder order = new frmOrder();
            order.lstbxOrder.Text = ViewOrder();
            order.lblOrderSubtotal.Text = getSubTotal().ToString();
            order.ShowDialog();
        }

        private object getSubTotal()
        {
            throw new NotImplementedException();
        }

        private object ViewOrder()
        {
            throw new NotImplementedException();
        }
    }
}
