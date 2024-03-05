using collectionTest.Models;
using collectionTest.ViewModels;

namespace collectionTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new FilesModel();
        }
    }

}
