using System.ComponentModel.DataAnnotations;

namespace My_Scripture_Journal.Models
{
    public class Scripture
    {
        public int Id { get; set; }
        public string Book { get; set; }
        public int Chapter { get; set; }
        public int Verse { get; set; }
        public string Notes { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; } = DateTime.Now;
    }
}
