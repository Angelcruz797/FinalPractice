
namespace FinalPractice.SportDB.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("SportDB.Product")]
    [BasedOnRow(typeof(Entities.ProductRow), CheckNames = true)]
    public class ProductColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 ProductId { get; set; }
        [EditLink]
        public String Title { get; set; }
        public Int32 Price { get; set; }
    }
}