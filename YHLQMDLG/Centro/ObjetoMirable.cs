using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace YHLQMDLG.Centro
{
    class ObjetoMirable : INotifyPropertyChanged

    {
        public event PropertyChangedEventHandler PropertyChanged;
        


        protected void OnPropertyChanged([CallerMemberName] string name  = null)
        {

            try
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            }catch(Exception ex) { }
        }

       
     

    }
}
