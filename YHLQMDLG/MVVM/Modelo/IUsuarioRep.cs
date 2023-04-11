using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace YHLQMDLG.MVVM.Modelo
{
    public interface IUsuarioRep
    {
        bool AuthenticateUser(NetworkCredential credential);
        void Add(UserModelo userModelo);
        void Edit(UserModelo userModelo);
        void Remove(UserModelo userModelo);
        UserModelo GetById(int id);

        UserModelo GetUserByName(string username);


        IEnumerable<UserModelo> GetByAll();




    }
}
