//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace shop123.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class member
    {
        public int id { get; set; }
        public string memberAccount { get; set; }
        public string memberPassword { get; set; }
        public string memberName { get; set; }
        public string memberPhone { get; set; }
        public string memberEmail { get; set; }
        public string memberImg { get; set; }
        public Nullable<bool> memberBanned { get; set; }
        public int memberAccess { get; set; }
        public System.DateTime memberCreateTime { get; set; }
    }
}
