using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using YHLQMDLG.MVVM.Modelo;

namespace YHLQMDLG.MVVM.Rep
{
    public class UsuarioR : BaseR, IUsuarioRep


    {
        public bool AuthenticateUser(NetworkCredential credential)
        {
            bool validUser;
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select *from [User] where username=@username and [password]=@password";
                command.Parameters.Add("@username", SqlDbType.NVarChar).Value = credential.UserName;
                command.Parameters.Add("@password", SqlDbType.NVarChar).Value = credential.Password;
                validUser = command.ExecuteScalar() == null ? false : true;
            }
            return validUser;
        }



        void IUsuarioRep.Add(UserModelo userModelo)
        {
            throw new NotImplementedException();
        }

        void IUsuarioRep.Edit(UserModelo userModelo)
        {
            throw new NotImplementedException();
        }

        IEnumerable<UserModelo> IUsuarioRep.GetByAll()
        {
            throw new NotImplementedException();
        }

        UserModelo IUsuarioRep.GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(UserModelo userModelo)
        {
            throw new NotImplementedException();
        }

        public UserModelo GetUserByName(string username)
        {
            UserModelo user = null;
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select *from [User] where username=@username";
                command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new UserModelo()
                        {
                            Id = reader[0].ToString(),
                            UserName = reader[1].ToString(),
                            Password = string.Empty,
                            Name = reader[3].ToString(),
                            LastName = reader[4].ToString(),
                            Email = reader[5].ToString(),
                        };
                    }
                }
            }
            return user;
        }


    }
}
