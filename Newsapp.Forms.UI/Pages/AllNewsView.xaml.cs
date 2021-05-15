using MvvmCross.Forms.Views;
using NewsApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
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
    }
}