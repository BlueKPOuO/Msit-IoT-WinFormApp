﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityLibrary
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Buliding_ManagementEntities : DbContext
    {
        public Buliding_ManagementEntities()
            : base("name=Buliding_ManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BulletinBoard> BulletinBoard { get; set; }
        public virtual DbSet<EquipFix> EquipFix { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<EquipReservation> EquipReservation { get; set; }
        public virtual DbSet<History> History { get; set; }
        public virtual DbSet<HolderDataTable> HolderDataTable { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<PackageCompany> PackageCompany { get; set; }
        public virtual DbSet<PackageTable> PackageTable { get; set; }
        public virtual DbSet<ParkingManagement> ParkingManagement { get; set; }
        public virtual DbSet<PublicSpace> PublicSpace { get; set; }
        public virtual DbSet<ResidentDataTable> ResidentDataTable { get; set; }
        public virtual DbSet<ReturnPackage> ReturnPackage { get; set; }
        public virtual DbSet<ShiftTable> ShiftTable { get; set; }
        public virtual DbSet<StaffDataTable> StaffDataTable { get; set; }
        public virtual DbSet<UserAccount> UserAccount { get; set; }
        public virtual DbSet<StaffDataWorkTime> StaffDataWorkTime { get; set; }
        public virtual DbSet<HTDataTable> HTDataTable { get; set; }
        public virtual DbSet<HumiTemperSenser> HumiTemperSenser { get; set; }
        public virtual DbSet<SensorTable> SensorTable { get; set; }
        public virtual DbSet<SmokeSenser> SmokeSenser { get; set; }
        public virtual DbSet<SmokeSenserData> SmokeSenserData { get; set; }
    
        public virtual int CreateUser(ObjectParameter iD, string staffID, string userName, byte[] password, string salted, string email)
        {
            var staffIDParameter = staffID != null ?
                new ObjectParameter("StaffID", staffID) :
                new ObjectParameter("StaffID", typeof(string));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(byte[]));
    
            var saltedParameter = salted != null ?
                new ObjectParameter("salted", salted) :
                new ObjectParameter("salted", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateUser", iD, staffIDParameter, userNameParameter, passwordParameter, saltedParameter, emailParameter);
        }
    
        public virtual int GetSalted(string userName, ObjectParameter salted)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetSalted", userNameParameter, salted);
        }
    
        public virtual int IsNameExists(string userName)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("IsNameExists", userNameParameter);
        }
    
        public virtual int Login(string userName, byte[] password)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Login", userNameParameter, passwordParameter);
        }
    
        public virtual int CreatEquipment(string equipmentName, string place, string vendor, string status, Nullable<System.DateTime> buydate, Nullable<int> useYear)
        {
            var equipmentNameParameter = equipmentName != null ?
                new ObjectParameter("EquipmentName", equipmentName) :
                new ObjectParameter("EquipmentName", typeof(string));
    
            var placeParameter = place != null ?
                new ObjectParameter("Place", place) :
                new ObjectParameter("Place", typeof(string));
    
            var vendorParameter = vendor != null ?
                new ObjectParameter("Vendor", vendor) :
                new ObjectParameter("Vendor", typeof(string));
    
            var statusParameter = status != null ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(string));
    
            var buydateParameter = buydate.HasValue ?
                new ObjectParameter("Buydate", buydate) :
                new ObjectParameter("Buydate", typeof(System.DateTime));
    
            var useYearParameter = useYear.HasValue ?
                new ObjectParameter("UseYear", useYear) :
                new ObjectParameter("UseYear", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreatEquipment", equipmentNameParameter, placeParameter, vendorParameter, statusParameter, buydateParameter, useYearParameter);
        }
    
        public virtual int EquipmentFix(Nullable<int> equipmentID, Nullable<System.DateTime> reportDate, string reason, Nullable<bool> repaired)
        {
            var equipmentIDParameter = equipmentID.HasValue ?
                new ObjectParameter("EquipmentID", equipmentID) :
                new ObjectParameter("EquipmentID", typeof(int));
    
            var reportDateParameter = reportDate.HasValue ?
                new ObjectParameter("ReportDate", reportDate) :
                new ObjectParameter("ReportDate", typeof(System.DateTime));
    
            var reasonParameter = reason != null ?
                new ObjectParameter("Reason", reason) :
                new ObjectParameter("Reason", typeof(string));
    
            var repairedParameter = repaired.HasValue ?
                new ObjectParameter("Repaired", repaired) :
                new ObjectParameter("Repaired", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EquipmentFix", equipmentIDParameter, reportDateParameter, reasonParameter, repairedParameter);
        }
    
        public virtual int ReservationNumber(Nullable<int> equipmentID, Nullable<System.DateTime> reservationDate, Nullable<int> residentID, Nullable<System.DateTime> returnDate)
        {
            var equipmentIDParameter = equipmentID.HasValue ?
                new ObjectParameter("EquipmentID", equipmentID) :
                new ObjectParameter("EquipmentID", typeof(int));
    
            var reservationDateParameter = reservationDate.HasValue ?
                new ObjectParameter("ReservationDate", reservationDate) :
                new ObjectParameter("ReservationDate", typeof(System.DateTime));
    
            var residentIDParameter = residentID.HasValue ?
                new ObjectParameter("ResidentID", residentID) :
                new ObjectParameter("ResidentID", typeof(int));
    
            var returnDateParameter = returnDate.HasValue ?
                new ObjectParameter("ReturnDate", returnDate) :
                new ObjectParameter("ReturnDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ReservationNumber", equipmentIDParameter, reservationDateParameter, residentIDParameter, returnDateParameter);
        }
    }
}
