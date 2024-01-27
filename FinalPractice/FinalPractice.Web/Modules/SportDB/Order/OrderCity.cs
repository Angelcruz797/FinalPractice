using Serenity.ComponentModel;
using System.ComponentModel;
namespace FinalPractice.SportDB
{
    // enum of various City

    [EnumKey("SportDB.City")]
    public enum OrderCity
    {
        [Description("none")]
        none = 1,
        [Description("Santo Domingo")]
        SantoDomingo = 2,
        [Description("Santiago")]
        Santiago = 3,
        [Description("Azua")]
        Azua = 4,
        [Description("Samana")]
        Samana = 5,
        [Description("Higuey")]
        Higuey = 6
    }
}