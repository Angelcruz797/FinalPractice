
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
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        [EmailEditor]
        public String Email { get; set; }
        public Gender Gender { get; set; }
    }
}