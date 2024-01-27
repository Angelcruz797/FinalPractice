
namespace FinalPractice.SportDB.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("SportDB.Customer")]
    [BasedOnRow(typeof(Entities.CustomerRow), CheckNames = true)]
    public class CustomerForm
    {
        [Category("Customer")]
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        //select gender in the form
        public Gender Gender { get; set; }
        [Category("Other details")]
        public String Address { get; set; }
    }
}