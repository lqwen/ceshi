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
    
    public partial class servCard_Project
    {
        public int Id { get; set; }
        public int CardId { get; set; }
        public int ProjectId { get; set; }
        public int TimesFree { get; set; }
        public byte TimesUnit { get; set; }
        public int Sort { get; set; }
        public string Remark { get; set; }
        public byte State { get; set; }
        public int CreateById { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<int> UpdateById { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public int BelongId { get; set; }
        public string BelongIds { get; set; }
    
        public virtual servProject servProject { get; set; }
    }
}
