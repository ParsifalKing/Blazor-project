namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}

        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<MentorPosition> MentorPositions { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<StudentGroup> StudentGroups { get; set; }
        public DbSet<Student> Students { get; set; }
   


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<StudentGroup>().HasKey(x => new { x.StudentId, x.GroupId });
            modelBuilder.Entity<MentorPosition>().HasKey(x => new { x.MentorId, x.PositionId });
            
            base.OnModelCreating(modelBuilder);
        }
    }
}







