//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data.Repository
{
    using System;
    using System.Collections.Generic;
    using Model.Entities;
    
    
    public partial interface IAspNetUserClaimRepository : Data.Repository.IBaseRepository<AspNetUserClaim>
    {
    }
    
    public partial class AspNetUserClaimRepository : Data.Repository.BaseRepository<AspNetUserClaim>, IAspNetUserClaimRepository
    {
    	public AspNetUserClaimRepository(Entities dbContext) : base(dbContext)
        {
        }
    }
}
