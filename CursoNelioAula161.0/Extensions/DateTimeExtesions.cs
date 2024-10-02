
namespace CursoNelioAula1610.Extensions
{
    static class DateTimeExtesions
    {
        public static string ElapedTime(this DateTime thisObj) 
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);
        }

    }
}
