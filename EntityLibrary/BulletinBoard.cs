//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class BulletinBoard
    {
        public string StaffID { get; set; }
        public int annID { get; set; }
        public string annGrade { get; set; }
        public string annClass { get; set; }
        public Nullable<System.DateTime> annDate { get; set; }
        public string annTitle { get; set; }
        public string annContent { get; set; }
        public byte[] annAnnex { get; set; }
    
        public virtual StaffDataTable StaffDataTable { get; set; }
    }
}