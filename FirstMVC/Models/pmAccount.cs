//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FirstMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class pmAccount
    {
        public pmAccount()
        {
            this.pmRelation = new HashSet<pmRelation>();
        }
    
        public int Id { get; set; }
        public byte AccountType { get; set; }
        public string AccountName { get; set; }
        public string AccountPassword { get; set; }
        public byte State { get; set; }
        public string Token { get; set; }
        public Nullable<System.DateTime> TokenTime { get; set; }
        public Nullable<System.DateTime> TokenOutTime { get; set; }
        public int CreateById { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<int> UpdateById { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public int BelongId { get; set; }
        public string BelongIds { get; set; }
    
        public virtual ICollection<pmRelation> pmRelation { get; set; }
    }
}