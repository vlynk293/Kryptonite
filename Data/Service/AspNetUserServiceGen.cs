//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data.Service
{
    using System;
    using System.Collections.Generic;
    using Data.Model.Entities;
    
    
    public partial interface IAspNetUserService : Data.Service.IBaseService<AspNetUser>
    {
    }
    
    public partial class AspNetUserService : Data.Service.BaseService<AspNetUser>, IAspNetUserService
    {
        public AspNetUserService(Data.Infrastructure.IUnitOfWork unitOfWork, Data.Repository.IAspNetUserRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}
