﻿using QuickTools.Core;
using QuickTools.MVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickTools.MVM.ViewModel
{
    class GenerateGuidViewModel : ObservableObject
    {
        private List<ObservableString> generatedGuids;
        private string numberOfGuids;
        public RelayCommand OnClickGenerate { get; set; }
        public List<ObservableString> GeneratedGuids
        {
            get { return generatedGuids; }
            set { generatedGuids = value; OnPropertyChanged(); }
        }
        public string NumberOfGuids
        {
            get { return numberOfGuids; }
            set { numberOfGuids = value; OnPropertyChanged(); }
        }
        public GenerateGuidViewModel()
        {
            numberOfGuids = "10";

            OnClickGenerate = new RelayCommand(o =>
            {
                //could also parse in setter?
                var temp = new List<ObservableString>();
                var numberG = Int32.Parse(NumberOfGuids);
                for(int i =0; i< numberG; i++)
                {
                    temp.Add(new ObservableString(Guid.NewGuid().ToString()));
                }
                GeneratedGuids = temp;
            });
        }
        public bool CanExecute
        {
            get
            {
                // check if executing is allowed, i.e., validate, check if a process is running, etc. 
                return true;
            }
        }
    }
}
