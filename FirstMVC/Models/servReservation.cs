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
    
    public partial class servReservation
    {
        public int Id { get; set; }
        public int Uid { get; set; }
        public string ReservationDate { get; set; }
        public string StarTime { get; set; }
        public string EndTime { get; set; }
        public byte State { get; set; }
        public int ReservationNum { get; set; }
        public int RemainNum { get; set; }
        public int CreateById { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<int> UpdateById { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public int BelongId { get; set; }
        public string BelongIds { get; set; }
    }
}