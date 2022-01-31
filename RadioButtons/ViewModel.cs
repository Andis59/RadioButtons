using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RadioButtons
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ViewModel()
        {
            WorkMode = WorkModeEnum.Manual;
        }

        private WorkModeEnum _WorkMode;

        public WorkModeEnum WorkMode
        {
            get { return _WorkMode; }
            set
            {
                _WorkMode = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}