
namespace FinalPractice.SportDB.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("SportDB.Product")]
    [BasedOnRow(typeof(Entities.ProductRow), CheckNames = true)]
    public class ProductForm
    {
        public String Title { get; set; }
        public Double Price { get; set; }
    }
}