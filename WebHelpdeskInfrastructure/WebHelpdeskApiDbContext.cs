using Microsoft.EntityFrameworkCore;
using WebHelpdesk.Domain.Encje.Models.Helpdesk;
using WebHelpdeskApi.Models.Clients;
using WebHelpdeskApi.Models.Helpdesk;
using WebHelpdeskApi.Models.RegisterAndLoginModels;


namespace WebHelpdeskInfrastructure
{
    public class WebHelpdeskApiDbContext : DbContext
    {
        public WebHelpdeskApiDbContext(DbContextOptions<WebHelpdeskApiDbContext> options) : base(options)
        {

        }
        public DbSet<ClientModel> clients { get; set; }
        public DbSet<TicketListModel> ticekLists { get; set; }
        public DbSet<TicketCreateModel> ticketCreates { get; set; }
        public DbSet<UserHelpdeskModel> userHelpdesks { get; set; }
        public DbSet<UserRegisterModel> userRegisters { get; set; }

      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserHelpdeskModel>(entity =>
            {
                entity.OwnsOne(c => c.DepartmentUser);
                entity.OwnsOne(c => c.DepartmentName);
            });

            modelBuilder.Entity<TicketListModel>(entity =>
            {
                entity.OwnsOne(c => c.Title);
                entity.OwnsOne(c => c.Description);
                entity.OwnsOne(c => c.TicketType);
                entity.OwnsOne(c => c.Status);
                entity.OwnsOne(c => c.Priority);
            });
            modelBuilder.Entity<TicketCreateModel>(entity =>
            {
                entity.OwnsOne(c => c.TicketType);
                entity.OwnsOne(c => c.Status);
            });


        }


    }
}
