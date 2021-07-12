using Microsoft.EntityFrameworkCore;
using Catalog.DAL.Entities;
using Catalog.DAL.DataContext.EntitiesConfigure;


namespace Catalog.DAL.DataContext
{
    public class DatabaseContext : DbContext
    {
        public class OptionsBuild
        {
            //Constructor
            public OptionsBuild()
            {
                // Создание объекта класса AppConfiguration к нашему connection string
                Settings = new AppConfiguration();

                // Инициализация класса который позволяет нам настроить связь с БД для DB Context
                // В нашем случае передает данные о месте расположения connection string для использования в DatabaseContext
                OptionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();

                // Передача расположения connection string для связи с MC SQL DB
                OptionsBuilder.UseSqlServer(Settings.SqlConnectionString);

                // Передача настроек для DbContext 
                DatabaseOptions = OptionsBuilder.Options;
            }

            public DbContextOptionsBuilder<DatabaseContext> OptionsBuilder { get; set; }
            public DbContextOptions<DatabaseContext> DatabaseOptions { get; set; }
            private AppConfiguration Settings { get; set; }
        }

        public static OptionsBuild Options = new OptionsBuild();

        //DatabaseContext Constructor
        // Инициализирует новый экземпляр класса DbContext с определенными опциями
        // В нашем случае мы всегда будем использовать static OptionsBuild Options так как они всегда доступны и готовы к использованию
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        // Наши DdSets [данные]
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }       
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Genre> Genres{ get;set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorConfigure())
                .ApplyConfiguration(new GenreConfigure())
                .ApplyConfiguration(new StatusConfigure())
                .ApplyConfiguration(new BookConfigure());
        }
    }
}
