using MvvmCross.Forms.Views;
using NewsApp.Core;
using Xamarin.Forms.Xaml;

namespace Newsapp.Forms.UI.Pages
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllNewsView : MvxContentPage<AllNewsViewModel>
    {
        public AllNewsView()
        {
            InitializeComponent();
        }

        private void ListView_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var vm = (AllNewsViewModel)this.DataContext;
            vm.ShowBrowser();
        }
    }
}