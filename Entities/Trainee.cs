using System.ComponentModel.DataAnnotations;

namespace Practical_work_1.Entities
{
    public class Trainee
    {
        public Trainee(long id, string traineeName, int age, bool isWorking)
        {
            Id = id;
            TraineeName = traineeName;
            Age = age;
            IsWorking = isWorking;
        }

        [Key]
        public long Id { get; set; }
        public string TraineeName { get; set; }
        public int Age { get; set; }
        public bool IsWorking { get; set; }
    }
}
