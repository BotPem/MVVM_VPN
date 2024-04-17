using MVVM_VPN.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM_VPN.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
		//Commands
		public RelayCommand ShowProtectionView {  get; set; }
		public RelayCommand ShowSettingsView {  get; set; }

		private object _currentView;

		public object CurrentView
		{
			get { return _currentView; }
			set 
			{ 
				_currentView = value;
				OnPropertyChanged();
			}
		}

		public ProtectionViewModel ProtectionVM {  get; set; }
		public SettingsViewModel SettingsVM { get; set; }

		public MainViewModel()
		{
			ProtectionVM = new ProtectionViewModel();
			SettingsVM = new SettingsViewModel();
			CurrentView = ProtectionVM;

			ShowProtectionView = new RelayCommand(o => { CurrentView = ProtectionVM; });
            ShowSettingsView = new RelayCommand(o => { CurrentView = SettingsVM; });
		}
	}
}
