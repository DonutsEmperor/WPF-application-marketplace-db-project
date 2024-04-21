﻿using System.Windows.Input;
using MyWpfAppForDb.WPF.Models;
using MyWpfAppForDb.WPF.ViewModels;

namespace MyWpfAppForDb.WPF.ViewModels
{
    public class ProfileVM : ViewModelBase
    {
        private ProfileModel _profileModel;
        private ViewModelStore _viewModelStore;

        public string Login
        {
            get => _profileModel.Login;
            set
            {
                _profileModel.Login = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get => _profileModel.Email;
            set
            {
                _profileModel.Email = value;
                OnPropertyChanged();
            }
        }

        public string Phone
        {
            get => _profileModel.Phone;
            set
            {
                _profileModel.Phone = value;
                OnPropertyChanged();
            }
        }

        public string Password1
        {
            get => _profileModel.Password1;
            set
            {
                _profileModel.Password1 = value;
                OnPropertyChanged();
            }
        }

        public string Password2
        {
            get => _profileModel.Password2;
            set
            {
                _profileModel.Password2 = value;
                OnPropertyChanged();
            }
        }

        public ICommand ApplyChanges { get; set; }


        public ProfileVM(ViewModelStore viewModelStore)
        {
            _viewModelStore = viewModelStore;
            _profileModel = new ProfileModel();
        }
    }
}
