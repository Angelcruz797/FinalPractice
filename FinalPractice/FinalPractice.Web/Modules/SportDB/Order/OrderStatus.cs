using Serenity.ComponentModel;
using System.ComponentModel;
namespace FinalPractice.SportDB
{
    // enum of various status

    [EnumKey("SportDB.Order")]
    public enum OrderStatus
    {
        [Description("In Progress")]
        InProgress = 1,
        [Description("In To Deliver")]
        InToDeliver = 2,
        [Description("Delivered")]
        delivered = 3
    }
}