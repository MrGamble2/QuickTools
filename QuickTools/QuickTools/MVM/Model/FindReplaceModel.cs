using QuickTools.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace QuickTools.MVM.Model
{
    class FindReplaceModel : ObservableObject
    {
        private string inputString;
        private string outputString;
        private string replaceMatch;
        private string replaceTo;
        private bool matchWholeWord;
        public string InputString
        {
            get => inputString;
            set => inputString = value;
        }
        public string OutputString
        {
            get => outputString;
            set => outputString = value;
        }
        public string ReplaceMatch
        {
            get => replaceMatch;
            set => replaceMatch = value;
        }
        public string ReplaceTo
        {
            get => replaceTo;
            set => replaceTo = value;
        }
        public bool MatchWholeWord
        {
            get => matchWholeWord;
            set => matchWholeWord = value;
        }
        public FindReplaceModel()
        {
            inputString = "";
            outputString = "";
            replaceMatch = "";
            replaceTo = "";
            matchWholeWord = false;
        }
    }
}
