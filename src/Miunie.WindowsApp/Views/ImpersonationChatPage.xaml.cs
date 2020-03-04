﻿using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Miunie.WindowsApp.ViewModels;
using Miunie.Core;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Miunie.WindowsApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ImpersonationChatPage : Page
    {
        private readonly ImpersonationChatPageViewModel _vm;

        public ImpersonationChatPage()
        {
            InitializeComponent();
            _vm = DataContext as ImpersonationChatPageViewModel;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _vm.FetchInfo((ulong)e.Parameter);
            _vm.ConfigureMessagesSubscription();
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
            => _vm.Dispose();
    }
}
