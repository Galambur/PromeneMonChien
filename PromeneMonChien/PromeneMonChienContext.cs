namespace PromeneMonChien
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PromeneMonChienContext : DbContext
    {
        public PromeneMonChienContext()
            : base("name=PromeneMonChienContext")
        {
        }

        public virtual DbSet<chien> chiens { get; set; }
        public virtual DbSet<promenade> promenades { get; set; }
        public virtual DbSet<type> types { get; set; }
        public virtual DbSet<utilisateur> utilisateurs { get; set; }
        public virtual DbSet<ville> villes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<chien>()
                .Property(e => e.nomChien)
                .IsUnicode(false);

            modelBuilder.Entity<chien>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<type>()
                .Property(e => e.nomType)
                .IsUnicode(false);

            modelBuilder.Entity<type>()
                .HasMany(e => e.chiens)
                .WithRequired(e => e.type)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<utilisateur>()
                .Property(e => e.nomUtilisateur)
                .IsUnicode(false);

            modelBuilder.Entity<utilisateur>()
                .Property(e => e.prenomUtilisateur)
                .IsUnicode(false);

            modelBuilder.Entity<utilisateur>()
                .Property(e => e.telephone)
                .IsUnicode(false);

            modelBuilder.Entity<utilisateur>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<utilisateur>()
                .Property(e => e.mdp)
                .IsUnicode(false);

            modelBuilder.Entity<utilisateur>()
                .HasMany(e => e.chiens)
                .WithRequired(e => e.utilisateur)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ville>()
                .Property(e => e.nomVille)
                .IsUnicode(false);

            modelBuilder.Entity<ville>()
                .Property(e => e.codePostal)
                .IsUnicode(false);
        }
    }
}
