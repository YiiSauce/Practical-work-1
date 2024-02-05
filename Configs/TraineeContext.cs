using Microsoft.EntityFrameworkCore;
using Practical_work_1.Entities;
using System.Data.Common;

namespace Practical_work_1.Configs
{
    public class TraineeContext : DbContext
    {
        public TraineeContext(DbContextOptions options): base(options)
        {
        }
        public DbSet<Trainee> Trainees { get; set; }
    }
}
