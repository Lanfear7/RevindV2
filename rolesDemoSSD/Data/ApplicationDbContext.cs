using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using rolesDemoSSD.ViewModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace rolesDemoSSD.Data
{
    // Instant Payment Notification
    public class IPN
    {
        // This lets you link the request to paypal with the response.
        public string custom { get; set; }

        [Display(Name = "ID")]
        [Key] // Define primary key.
        public string paymentID { get; set; }
        public string cart { get; set; }
        public string create_time { get; set; }

        // Payer data.
        public string payerID { get; set; }
        public string payerFirstName { get; set; }
        public string payerLastName { get; set; }
        public string payerMiddleName { get; set; }
        public string payerEmail { get; set; }
        public string payerCountryCode { get; set; }
        public string payerStatus { get; set; }

        // Payment data.
        public string amount { get; set; }
        public string currency { get; set; }
        public string intent { get; set; }
        public string paymentMethod { get; set; }
        public string paymentState { get; set; }
    }

    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        public MovieVM MovieID { get; set; }
        public UserVM Email { get; set; }
        public string ReviewContent { get; set; }
        public string ReviewDate { get; set; }
        public int Rating { get; set; }
        public string RatingDate { get; set; }
        public int Flag { get; set; }

        /*     // Navigation properties.
             // Child.        
             public virtual ICollection<ProduceSupplier>
                 ProduceSuppliers
             { get; set; }*/
    }

    public class Movie
    {
        [Key]
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public string PosterSource { get; set; }
        public string Genre { get; set; }
        public string Duration { get; set; }
        public string ReleaseDate { get; set; }
        public string Distributor { get; set; }
   /*     // Navigation properties.
        // Child.
        public virtual ICollection<ProduceSupplier>
            ProduceSuppliers
        { get; set; }*/
    }



    public class MyRegisteredUser
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Email")]
        [Required]
        public string Email { get; set; }
        [Display(Name = "Address")]
        [Required]
        public string Address { get; set; }



    }

    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<IPN> IPNs { get; set; }

        public DbSet<MyRegisteredUser> MyRegisteredUsers { get; set; }

        public DbSet<rolesDemoSSD.ViewModels.RoleVM> RoleVM { get; set; }

        public DbSet<rolesDemoSSD.ViewModels.UserVM> UserVM { get; set; }

        public DbSet<rolesDemoSSD.ViewModels.UserRoleVM> UserRoleVM { get; set; }


        // Define entity collections.
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // When adding OnModelCreating() in .NET Core a reference 
            // to the base class is also needed at the start of the method.
            base.OnModelCreating(modelBuilder);

     /*       // Define composite primary keys.
            modelBuilder.Entity<ProduceSupplier>()
                .HasKey(ps => new { ps.ProduceID, ps.SupplierID });

            // Define foreign keys here. Do not use foreign key annotations.
            modelBuilder.Entity<ProduceSupplier>()
                .HasOne(p => p.Produce)
                .WithMany(p => p.ProduceSuppliers)
                .HasForeignKey(fk => new { fk.ProduceID })
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

            modelBuilder.Entity<ProduceSupplier>()
                .HasOne(p => p.Supplier)
                .WithMany(p => p.ProduceSuppliers)
                .HasForeignKey(fk => new { fk.SupplierID })
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete*/


            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {   MovieID = 1,
                    MovieName = "Deadpool", PosterSource = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQdFU5DLFLwDFTzE_85beWRTBRmKUuVCzUcnxjgDE_YWqMwncEx",
                    Genre = "Action/Adventure", Duration = "190 Minutes",
                    ReleaseDate = "02/21/2016", Distributor = "20th Century Fox"
                });

            modelBuilder.Entity<Review>().HasData(
                new Review
                {
                    ReviewID = 1,
                    ReviewContent = "Amazing movie. I loved it.",
                    ReviewDate = "09/03/2020",
                    Rating = 4,
                    RatingDate = "09/03/2020",
                    Flag = 1
                });
               
/*
            modelBuilder.Entity<ProduceSupplier>().HasData(
                new ProduceSupplier { SupplierID = 1, ProduceID = 1, Qty = 25 });*/
        }

        public DbSet<rolesDemoSSD.ViewModels.MovieVM> MovieVM { get; set; }
    }
}
