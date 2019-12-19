using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BeerSearch
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        { 
            //Nem találja a fájlt. Máshova kéne beilleszteni.
           

            InitializeComponent();

            NavigationPage navigationPage = new NavigationPage(new SearchPage());
            
            navigationPage.Title = "Search";

            Children.Add(new SearchPage());
            Children.Add(navigationPage);

            NavigationPage navigationPage2 = new NavigationPage(new TypesPage());

            navigationPage2.Title = "Types";

            Children.Add(new TypesPage());
            Children.Add(navigationPage2);

            NavigationPage navigationPage3 = new NavigationPage(new BeersPage());
            navigationPage3.Title = "Beers";

            Children.Add(new BeersPage());
            Children.Add(navigationPage3);

            




            //    var assembly = IntrospectionExtensions.GetTypeInfo(typeof(LoadResourceText)).Assembly;

            //  Stream stream = assembly.GetManifestResourceStream("BeerSearch.beers.xml");



        }
    }
}
