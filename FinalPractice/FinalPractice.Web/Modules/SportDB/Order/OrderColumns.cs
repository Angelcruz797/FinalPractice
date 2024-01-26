
namespace FinalPractice.SportDB.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("SportDB.Order")]
    [BasedOnRow(typeof(Entities.OrderRow), CheckNames = true)]
    public class OrderColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 OrderId { get; set; }
        [EditLink, DisplayName("Full Name")]
        public String CustomerFullname { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}