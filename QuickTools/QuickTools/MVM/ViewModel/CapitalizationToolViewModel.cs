using QuickTools.Core;
using QuickTools.MVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace QuickTools.MVM.ViewModel
{
    internal class CapitalizationToolViewModel : ObservableObject
    {
        public CapitalizationToolModel CapModel;
        public string InputString
        {
            get => CapModel.InputString;
            set
            {
                CapModel.InputString = value;
                CalculateOutput();
                OnPropertyChanged();
            }
        }
        public string OutputString
        {
            get => CapModel.OutputString;
            set
            {
                CapModel.OutputString = value;
                OnPropertyChanged();
            }
        }
        public ComboBoxItem SelectedToolOption
        {
            get => CapModel.ToolOption;
            set
            {
               CapModel.ToolOption = value;
                CalculateOutput();
                OnPropertyChanged();
            } 
        }

        public CapitalizationToolViewModel()
        {
            CapModel = new CapitalizationToolModel();
        }
        public void CalculateOutput()
        {
            switch ((string)CapModel.ToolOption.Content)
            {
                case "UPPERCASE":
                    OutputString = CapModel.InputString.ToUpper();
                    break;
                case "lowercase":
                    OutputString = CapModel.InputString.ToLower();
                    break;
                case "Sentence case":
                    var rexSent = new Regex(@"(^[a-z])|\.\s+(.)", RegexOptions.ExplicitCapture);
                    OutputString = rexSent.Replace(CapModel.InputString, s => s.Value.ToUpper());
                    break;
                case "Capitalized Case":
                    var rexCap = new Regex(@"\s+(.)", RegexOptions.ExplicitCapture);
                    var tempString = rexCap.Replace(CapModel.InputString, s => s.Value.ToUpper());
                    OutputString= tempString[0].ToString().ToUpper() + tempString.Substring(1);
                    break;

            }
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
