using Microsoft.EntityFrameworkCore;

namespace FormSample.Data
{
    public class FormContactContext : DbContext
    {
        public FormContactContext()
            : base()
        { }

        public FormContactContext(DbContextOptions<FormContactContext> options)
            : base(options)
        { }

        public DbSet<FormContact> FormContacts { get; set; }
    }
}
