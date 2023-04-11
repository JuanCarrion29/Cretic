using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using YHLQMDLG.Centro;
using YHLQMDLG.MVVM.Rep;
using YHLQMDLG.MVVM.Modelo;

namespace YHLQMDLG.MVVM.VistaModelo
{
    public class LoginVistaModelo : VistaModeloB
    {
        private string _userName;
        private SecureString _password;
        private string _errorMessage;
        private bool _isViewVisible = true;

        private IUsuarioRep UsuarioRep;


        public string UserName
        {
            get { return _userName; }

            set
            {
                _userName = value;

                OnProperyChange(nameof(UserName));
            }



        }

        public SecureString Password
        {

            get { return _password; }

            set
            {
                _password = value;

                OnProperyChange(nameof(Password));
            }


        }

        public string ErrorMessage
        {
            get { return _errorMessage; }

            set
            {
                _errorMessage = value;


                OnProperyChange(nameof(ErrorMessage));
            }

        }

        public bool IsViewVisible
        {

            get { return _isViewVisible; }
            set
            {
                _isViewVisible = value;


                OnProperyChange(nameof(IsViewVisible));
            }



        }


        public ICommand LoginCommand { get; }

        public ICommand RecoverPasswordCommand { get; }

        public ICommand ShowPasswordCommand { get; }


        public LoginVistaModelo()
        {
            UsuarioRep = new UsuarioR();
            LoginCommand = new RRelayCommand(ExecuteLoginCommand, CanExecuteLoginCommand);

            RecoverPasswordCommand = new RRelayCommand(p => ExecuteRecoverPassCommand("", ""));

        }


        private bool CanExecuteLoginCommand(object obj)
        {
            bool validData;
            if (string.IsNullOrWhiteSpace(UserName) || UserName.Length < 3 ||
                Password == null || Password.Length < 3)
                validData = false;
            else
                validData = true;
            return validData;
        }

        private void ExecuteLoginCommand(object obj)
        {
            var isValidUser = UsuarioRep.AuthenticateUser(new NetworkCredential(UserName, Password));
            if (isValidUser)
            {
                Thread.CurrentPrincipal = new GenericPrincipal(
                    new GenericIdentity(UserName), null);
                IsViewVisible = false;
            }
            else
            {
                ErrorMessage = "* Invalid username or password";
            }
        }



        private void ExecuteRecoverPassCommand(string username, string email)
        {
            throw new NotImplementedException();
        }
    }




}

