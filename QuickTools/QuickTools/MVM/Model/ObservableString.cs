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
    class ObservableString : ObservableObject
    {
        private string? stringValue;
        public string? StringValue
        {
            get => stringValue;
            set
            {
                stringValue = value;
                OnPropertyChanged();
            }
        }
        public ObservableString(string? instringValue)
        {
            stringValue = instringValue;
        }
    }
}
