﻿using MyWpfAppForDb.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWpfAppForDb.WPF.State.Navigators
{
	internal class Navigator : INavigator
	{
		private ViewModelBase _currentViewModel;

		public ViewModelBase CurrentViewModel
		{
			get => _currentViewModel;
			set 
			{ 
				_currentViewModel?.Dispose();

				_currentViewModel = value;
				StateChanged?.Invoke();
			}
		}

		public event Action StateChanged;
	}
}
