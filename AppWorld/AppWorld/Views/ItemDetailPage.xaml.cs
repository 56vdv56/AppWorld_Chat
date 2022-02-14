using AppWorld.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppWorld.Views
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