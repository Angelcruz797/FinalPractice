using Serenity.ComponentModel;
using System.ComponentModel;
namespace FinalPractice.SportDB
{
    //enum of various Gender

    [EnumKey("SportDB.Gender")]
    public enum Gender
    {
        [Description("Male")]
        Male = 1,
        [Description("Female")]
        Female = 2
    }
}