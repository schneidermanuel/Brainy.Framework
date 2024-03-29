﻿using System.Windows.Input;
using Brainy.Framework.Commands;
using Brainy.Framework.Contract;
using Brainy.Framework.Testtool.TestPage2;

namespace Brainy.Framework.Testtool.TestPage
{
    public class MainViewModel : ViewModelBase
    {
        public ICommand NextPageCommand { get; }

        public MainViewModel()
        {
            NextPageCommand = new RelayCommand(Execute);
        }

        private void Execute()
        {
            Navigation.NavigateToAsync<OtherViewModel>();
        }
    }
}