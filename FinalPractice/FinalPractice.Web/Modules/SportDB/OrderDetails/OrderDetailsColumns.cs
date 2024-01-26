
namespace FinalPractice.SportDB.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("SportDB.OrderDetails")]
    [BasedOnRow(typeof(Entities.OrderDetailsRow), CheckNames = true)]
    public class OrderDetailsColumns
    {   
        [EditLink, AlignRight]
        public Int32 OrderDetailsId { get; set; }
        [EditLink,Width(100)]
        public Int32 ProductTitle { get; set; }
        public Double UnitPrice { get; set; }
        public Int32 Quantity { get; set; }
        public Double LineTotal { get; set; }
    }
}