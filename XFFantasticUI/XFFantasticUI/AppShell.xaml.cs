using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XFFantasticUI.ViewModels;
using XFFantasticUI.Views;

namespace XFFantasticUI
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
