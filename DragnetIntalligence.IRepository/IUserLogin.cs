using Dragnet.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dragnet.IRepository
{
   public interface IUserLogin
    {
      public  List<UserLogin> GetAllUSers();

       public List<UserLogin> Login(string UserId, string Password);
    }
}
