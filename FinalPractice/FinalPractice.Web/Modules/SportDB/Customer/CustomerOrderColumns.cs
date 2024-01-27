
namespace FinalPractice.SportDB.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    // form for order tab in CustomerForm
    [ColumnsScript("SportDB.CustomerOrder")]
    [BasedOnRow(typeof(Entities.OrderRow))]
    public class CustomerOrderColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 OrderId { get; set; }
        [EditLink, DisplayName("Full Name")]
        public String CustomerFullname { get; set; }
        public OrderStatus Status { get; set; }
        [Width(120)]
        public OrderCity ShipCity { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}