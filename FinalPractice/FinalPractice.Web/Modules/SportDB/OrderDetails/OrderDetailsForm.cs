
namespace FinalPractice.SportDB.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("SportDB.OrderDetails")]
    [BasedOnRow(typeof(Entities.OrderDetailsRow), CheckNames = true)]
    public class OrderDetailsForm
    {
        public Int32 ProductId { get; set; }
        public Double UnitPrice { get; set; }
        public Int32 Quantity { get; set; }
    }
}