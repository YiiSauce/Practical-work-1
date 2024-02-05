using System.ComponentModel.DataAnnotations;

namespace Practical_work_1.Entities
{
    public class Trainee
    {
        [Key]
        public long Id { get; set; }
        public string? TaineeName { get; set; }
        public int Age { get; set; }
        public bool? IsWorking { get; set; }
    }
}
