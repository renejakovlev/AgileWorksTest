namespace AgileWorksTest.Models
{
    public class Entry
    {
        public int id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public DateTime date { get; set; } = DateTime.Now;
        public DateTime deadline { get; set; }
        public bool resolved { get; set; } = false;

        public Entry()
        {

        }
    }
}
