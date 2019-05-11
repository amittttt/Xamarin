using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SecondPage
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private  void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new GradientColorPage());
        }
    }
}
