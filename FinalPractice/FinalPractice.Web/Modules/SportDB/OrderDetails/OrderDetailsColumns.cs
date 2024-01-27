
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
        //Column product list in the order
        [EditLink,Width(100)]
        public Int32 ProductName { get; set; }
        public Double UnitPrice { get; set; }
        public Int32 Quantity { get; set; }
        public Double LineTotal { get; set; }
    }
}