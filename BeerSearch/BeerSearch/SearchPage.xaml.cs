using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BeerSearch
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();



        }

        private void keres_Clicked(object sender, EventArgs e)
        {
            String[] sörbeírt = beerentry.Text.Split(','); //new List<string>();

             List<Beers> Sörs =  Beers.Feltölt(sörbeírt);


            ////Beers.Searching(Sörs);
            if (Sörs.Count == 0)
            {
                displaybeer.Text = "Nincs ilyen sör az adatbázisban. Próbálja újra egy másik sörrel!";
            }
            else
            {
                for (int i = 0; i < Sörs.Count; i++)
                {


                    displaybeer.Text +=i+1+". sör:" + "\n" + "Név: " + Sörs[i].Neve + "\n" + "Alkohol: " + Sörs[i].Alkoholfok + "\n" + 
                        "Íz: " + Sörs[i].Íz + "\n" +"Minőség: " + Sörs[i].Minőség + "\n" + "\n";
                    
                }
            }

           // displaybeer.Text = "Neve:" + Sörs[0].Sörnév + " Típusa: " + Sörs[0].Típus + " Alkoholfoka: " + Sörs[0].Alkoholfok;


    }

        private void clear_Clicked(object sender, EventArgs e)
        {

            beerentry.Text = string.Empty;

            displaybeer.Text = string.Empty;

        }
    }
}