//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Active_Rule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Active_Rule()
        {
            this.Active_Record = new HashSet<Active_Record>();
        }
    
        public int ActiveID { get; set; }
        public int Active_Type_ID { get; set; }
        public string Active_Name { get; set; }
        public string Active_Description { get; set; }
        public string Active_Condition { get; set; }
        public int Amount { get; set; }
        public string Gift { get; set; }
        public int Quantity { get; set; }
        public int Quantity_Total { get; set; }
        public int Quantity_Remaining { get; set; }
        public System.DateTime Start_Date { get; set; }
        public System.DateTime End_Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Active_Record> Active_Record { get; set; }
        public virtual Active_Type Active_Type { get; set; }
    }
}
