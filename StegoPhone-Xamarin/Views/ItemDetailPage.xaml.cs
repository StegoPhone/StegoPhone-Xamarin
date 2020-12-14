using StegoPhone_Xamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace StegoPhone_Xamarin.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}