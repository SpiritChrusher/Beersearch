using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BeerSearch
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BeersPage : ContentPage
    {
        public ObservableCollection<string> pivo { get; set; }

        public BeersPage()
        {
            InitializeComponent();

            int dynamicTestValue = 5;

            //This is the "dynamic" value 

            Beers mObject; 
            List<Beers > mObjectList = new List<Beers >();

            for (int i = 0; i < dynamicTestValue; i++)
            {
                mObject= new Beers ("FullNameOfSomething"+ i);
              
                mObjectList.Add(mObject); 
            } 

            MyListView.ItemsSource = mObjectList; 
            var template = new DataTemplate(typeof(TextCell)); 
            template.SetBinding(TextCell.TextProperty, "FullName"); 
            template.SetBinding(TextCell.DetailProperty, "Number"); 
                MyListView.ItemTemplate = template;





            /*  pivo = new ObservableCollection<string>() { "Staropramen", "Soproni APA" };
              Color blue = new Color(204, 125, 221);
              MyListView.BackgroundColor = blue;*/
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
