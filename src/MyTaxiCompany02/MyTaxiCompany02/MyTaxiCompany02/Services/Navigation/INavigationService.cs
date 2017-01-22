﻿using MyTaxiCompany02.ViewModels.Base;
using System;
using System.Threading.Tasks;

namespace MyTaxiCompany02.Services.Navigation
{
    public interface INavigationService
    {
        Task InitializeAsync();

        Task NavigateToAsync<TViewModel>() where TViewModel : ViewModelBase;

        Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : ViewModelBase;

        Task NavigateToAsync(Type viewModelType);

        Task NavigateToAsync(Type viewModelType, object parameter);

        Task NavigateBackAsync();
    }
}
