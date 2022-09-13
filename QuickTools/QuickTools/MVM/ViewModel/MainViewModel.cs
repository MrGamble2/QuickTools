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
        public RelayCommand CapitalizationToolViewCommand { get; set; }
        public RelayCommand FindReplaceViewCommand { get; set; }
        private GenerateGuidViewModel GuidVM;
        private CapitalizationToolViewModel CapitalizationVM;
        private FindReplaceViewModel FindReplaceVM;
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
            CapitalizationVM = new CapitalizationToolViewModel();
            FindReplaceVM = new FindReplaceViewModel();
            currentView = GuidVM;

            GenerateGuidViewCommand = new RelayCommand(o =>
            {
                CurrentView = GuidVM;
            });
            CapitalizationToolViewCommand = new RelayCommand(o =>
            {
                CurrentView = CapitalizationVM;
            });
            FindReplaceViewCommand = new RelayCommand(o =>
            {
                CurrentView = FindReplaceVM;
            });
        }
    }
}
