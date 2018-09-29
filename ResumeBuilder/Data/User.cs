using System;
using SQLite;

namespace ResumeBuilder.Data
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        public int AboutId { get; set; }
        public string AboutMe { get; set; }
        public string S1 { get; set; }
        public string S2 { get; set; }
        public string S3 { get; set; }
        public string S4 { get; set; }
        public string S5 { get; set; }
        public string CN1 { get; set; }
        public string CN2 { get; set; }
        public string FY1 { get; set; }
        public string FY2 { get; set; }
        public string TY1 { get; set; }
        public string TY2 { get; set; }
        public string P1 { get; set; }
        public string P2 { get; set; }
        public string inst { get; set; }
        public string Com { get; set; }
        public string Pers { get; set; }
        public string Comp { get; set; }
        public string Pho { get; set; }


        public static string CurrentUser = null;
    }
}
