
namespace FinalPractice.SportDB.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using Serenity.Data.Mapping;

    [FormScript("SportDB.Order")]
    [BasedOnRow(typeof(Entities.OrderRow), CheckNames = true)]
    public class OrderForm
    {
        [Tab("General")]
        [Category("Order")]
        public Int32 CutormerId { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime ReleaseDate { get; set; }
        [Tab("Order Details")]
        [Category("Lists")]
        [OrderrDetailsEditor, NotMapped]
        public List<Entities.OrderDetailsRow> ProductList { get; set; }
    }
}