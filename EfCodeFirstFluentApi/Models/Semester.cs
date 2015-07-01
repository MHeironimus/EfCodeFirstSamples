namespace EfCodeFirstFluentApi.Models
{
    public enum Season
    {
        Fall,
        Winter,
        Spring,
        Summer
    }

    public class Semester
    {
        public int Year { get; set; }
        public Season Season { get; set; }
    }
}
