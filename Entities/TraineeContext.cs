using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Practical_work_1.Entities
{
    public class TraineeContext : DbContext
    {
        public TraineeContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Trainee> Trainees { get; set; }
    }
}
