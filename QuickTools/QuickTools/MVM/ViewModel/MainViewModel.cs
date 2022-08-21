using QuickTools.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickTools.MVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand GenerateGuidViewCommand { get; set; }
        private GenerateGuidViewModel GuidVM;
        private object currentView;
        public object CurrentView
        {
            get { return currentView; }
            set 
            { 
                currentView = value; 
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            GuidVM = new GenerateGuidViewModel();
            CurrentView = GuidVM;

            GenerateGuidViewCommand = new RelayCommand(o =>
            {
                CurrentView = GuidVM;
            });
        }
    }
}
