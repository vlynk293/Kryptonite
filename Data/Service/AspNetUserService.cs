using Data.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Service
{
    public partial interface IAspNetUserService
    {
        AspNetUser GetUserByEmail(string email);
    }

    public partial class AspNetUserService
    {
        public  AspNetUser GetUserByEmail(string email)
        {
            var data = this.GetAll().Where(q => q.Email.Equals(email)).SingleOrDefault() ;
            return data;
        }

    }
}
