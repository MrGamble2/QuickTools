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
    internal class FindReplaceViewModel : ObservableObject
    {
        public FindReplaceModel FRModel;
        public string InputString
        {
            get => FRModel.InputString;
            set
            {
                FRModel.InputString = value;
                OnPropertyChanged();
                CalculateOutput();
            }
        }
        public string OutputString
        {
            get => FRModel.OutputString;
            set
            {
                FRModel.OutputString = value;
                OnPropertyChanged();
            }
        }
        public string ReplaceMatch
        {
            get => FRModel.ReplaceMatch;
            set
            {
                FRModel.ReplaceMatch = value;
                OnPropertyChanged();
                CalculateOutput();
            }
        }
        public string ReplaceTo
        {
            get => FRModel.ReplaceTo;
            set
            {
                FRModel.ReplaceTo = value;
                OnPropertyChanged();
                CalculateOutput();
            }
        }
        public bool MatchWholeWord
        {
            get => FRModel.MatchWholeWord;
            set
            {
                FRModel.MatchWholeWord = value;
                OnPropertyChanged();
                CalculateOutput();
            }
        }

        public FindReplaceViewModel()
        {
            FRModel = new FindReplaceModel();
        }
        public void CalculateOutput()
        {
            if(ReplaceMatch.Length == 0)
            {
                return;
            }
            //~ means we are doing a regex
            if (FRModel.ReplaceMatch[0] == '~')
            {
                var rex= new Regex(ReplaceMatch.Substring(1), RegexOptions.ExplicitCapture);
                OutputString = rex.Replace(FRModel.InputString, s => FRModel.ReplaceTo);
            }
            else if(!MatchWholeWord)
            {
                OutputString = FRModel.InputString.Replace(FRModel.ReplaceMatch, FRModel.ReplaceTo);
            }
            else
            {
                string pattern = @"\b"+ ReplaceMatch +@"\b";
                OutputString = Regex.Replace(InputString, pattern, ReplaceTo);
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
