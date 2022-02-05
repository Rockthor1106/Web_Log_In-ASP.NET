namespace Web_Log_In_ASP.NET.Models
{
    public class User
    {
        public int ID { get; set; }
        public string username { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string password  { get; set; }
        public DateTime birthday { get; set; }

    }
}
