﻿using AppWPF.Database;
using System.Collections.Generic;
using System.Windows.Input;
using AppWPF.ViewModels.Additional;
using AppWPF.ViewModels.Models;

namespace AppWPF.ViewModels.Pages
{
    public class StatisticsVM : ViewModelBase
	{
		private StatisticsModel _statisticsModel;
		private ViewModelStore _viewModelStore;

		public string Search
		{
			get
			{
				return _statisticsModel.Search;
			}
			set
			{
				_statisticsModel.Search = value;
				OnPropertyChanged(nameof(Search));
			}
		}

		public List<DeliveryPoint> DeliveryPoints
		{
			get
			{
				return _statisticsModel.DeliveryPoints;
			}
			set
			{
				_statisticsModel.DeliveryPoints = value;
				OnPropertyChanged(nameof(DeliveryPoints));
			}
		}

		public ICommand SearchBtn { get; set; }
		public ICommand SelectDeliveryPoint { get; set; }
		//public ICommand DrawTheGraph { get; set; }

		public StatisticsVM(ViewModelStore viewModelStore)
		{
			_viewModelStore = viewModelStore;
			_statisticsModel = new StatisticsModel();
		}
	}
}