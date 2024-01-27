
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

    //Order Form

    [FormScript("SportDB.Order")]
    [BasedOnRow(typeof(Entities.OrderRow), CheckNames = true)]
    public class OrderForm
    {
        [Category("Order")]
        public Int32 CutormerId { get; set; }
        public OrderStatus Status { get; set; }
        public OrderCity ShipCity { get; set; }

        // current date

        [DefaultValue("now")]
        public DateTime ReleaseDate { get; set; }

        [Category("Order Details")]

        //Product List Form

        [OrderrDetailsEditor, NotMapped]
        public List<Entities.OrderDetailsRow> ProductList { get; set; }
    }
}