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
    
    public partial class eqWatch_Remind
    {
        public int Id { get; set; }
        public string Imei { get; set; }
        public int ElderlyId { get; set; }
        public int RemindType { get; set; }
        public string Contents { get; set; }
        public string Weeks { get; set; }
        public string RemindTimes { get; set; }
        public Nullable<bool> Repeat { get; set; }
        public Nullable<byte> State { get; set; }
        public string VoiceFile { get; set; }
        public int CreateById { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<int> UpdateById { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    }
}
