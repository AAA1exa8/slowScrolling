using collectionTest.Models;
using collectionTest.ViewModels;

namespace collectionTest
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new FilesModel();
        }
    }

}
