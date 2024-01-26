using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace FinalPractice.SportDB
{
    public partial class OrderrDetailsEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "FinalPractice.SportDB.OrderrDetailsEditor";

        public OrderrDetailsEditorAttribute()
            : base(Key)
        {
        }
    }
}

