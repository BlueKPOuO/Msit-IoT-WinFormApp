﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PackageSys
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ShiEntities : DbContext
    {
        public ShiEntities()
            : base("name=ShiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PackageCompany> PackageCompany { get; set; }
        public virtual DbSet<PackageTable> PackageTable { get; set; }
        public virtual DbSet<ResidentDataTable> ResidentDataTable { get; set; }
        public virtual DbSet<ReturnPackage> ReturnPackage { get; set; }
        public virtual DbSet<ShiftTable> ShiftTable { get; set; }
        public virtual DbSet<StaffDataTable> StaffDataTable { get; set; }
    }
}
