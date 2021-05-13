using MvvmCross.Forms.Views;
using NewsApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileNewsApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuView : MvxContentPage<AllNewsViewModel>
    {
        public MenuView()
        {
            InitializeComponent();
        }
    }
}