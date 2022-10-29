using Service.Services.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
   public  class AccountService:IAccountService
    {
       public  string Login(string email, string password, int role)
        {
            if (email== AccountConstants.Email && password == AccountConstants.Password)
            {
                if (CheckRole(role)) 
                {
                    return AccountConstants.Success;
                }
               else
                {
                    return AccountConstants.NoAuthorize;
                }
            }
            return AccountConstants.Failed;
                
        }

        public bool CheckRole(int role)
        {
            switch (role)
            {
                case (int)Roles.SuperAdmin:
                    return true;

                default:
                    return false;
            }
        }


    }
}
