using SmartSaver_Mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SmartSaver_Mobile.Views
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