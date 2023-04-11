using System;
using YHLQMDLG.Centro;
using YHLQMDLG.MVVM.VistaModelo;

namespace YHLQMDLG.MVVM.VistaModelo
{
     class MainVistaM : ObjetoMirable

    {
        public RelayCommand HomeVistaCommand { get; set; }

        public RelayCommand JuegosVistaCommand { get; set; }

        public RelayCommand BibliotecaVistaCommand { get; set; }

       



        public HomeVistaModelo HomeVM { get; set; }

        public JuegosVistaModelo JuegosVM { get; set; }

        public BibliotecaVistaModelo BibliotecaVM { get; set; }

        private object _comoseve;
        public object Comoseve { get { return _comoseve; } 
        set { 
                _comoseve = value;
                OnPropertyChanged();
            }
            
        
        }

        public MainVistaM()
        {

            


            HomeVM = new HomeVistaModelo();
            JuegosVM = new JuegosVistaModelo();
            BibliotecaVM = new BibliotecaVistaModelo();

            Comoseve = HomeVM;


            HomeVistaCommand = new RelayCommand(o =>
            {
                Comoseve= HomeVM;

            });


            JuegosVistaCommand = new RelayCommand(o => { 
            
             Comoseve = JuegosVM;
            
            });

            BibliotecaVistaCommand = new RelayCommand(o => { 
            
            Comoseve = BibliotecaVM;
            
            });

        }





    }
}
