using QuickTools.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuickTools.MVM.Model
{
    class CapitalizationToolModel : ObservableObject
    {
        private string inputString;
        private string outputString;
        private string toolOption;
        public string InputString
        {
            get => inputString;
            set
            {
                inputString = value;
                OnPropertyChanged();
            }
        }
        public string OutputString
        {
            get => outputString;
            set
            {
                outputString = value;
                OnPropertyChanged();
            }
        }
        public string ToolOption
        {
            get => toolOption;
            set
            {
                toolOption = value;
                OnPropertyChanged();
            }
        }

        public CapitalizationToolModel()
        {
            inputString = "";
            outputString = "";
            toolOption = "UPPERCASE";
        }
    }
}
