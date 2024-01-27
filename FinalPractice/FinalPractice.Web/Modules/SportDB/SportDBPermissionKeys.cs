
using Serenity.Extensibility;
using System.ComponentModel;

namespace FinalPractice.SportDB
{
    // permissions to be able to manipulate in Sport Shop
    [NestedPermissionKeys]
    [DisplayName("Default")]
    public class PermissionKeys
    {
        [DisplayName("Customer")]
        public class Customer
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Default:Customer:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Default:Customer:Modify";
            public const string View = "Default:Customer:View";
        }

        // permission general in Sport Shop
        [Description("[General]")]
        public const string General = "Default:General";
    }
}
