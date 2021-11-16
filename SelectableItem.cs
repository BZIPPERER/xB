using System;
using System.ComponentModel;
 using System.Runtime.CompilerServices;

namespace xBalsat
{
    public class SelectableItem : INotifyPropertyChanged
    {   
        // Addint (this) 2 times
        public event PropertyChangedEventHandler  IsEnabledChanged;
        public event PropertyChangedEventHandler  IsSelectedChanged;
        public event PropertyChangedEventHandler  PropertyChanged;
        private string data;

        public string Data
        {
            get { return data; }
            set { data = value; 
            OnPropertyChanged();
            }
        }

        private bool isEnabled = true;

        public bool IsEnabled
        {
            get { return isEnabled; }
            set 
            {
                if(isEnabled == value)
                {
                    return;
                }
                isEnabled = true;
                OnPropertyChanged();
                

            }
        }

         // Create the OnPropertyChanged method to raise the event
      // The calling member's name will be used as the parameter.
      protected void OnPropertyChanged([CallerMemberName] string data = null)
      {
          PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(data));
      }
    }

}