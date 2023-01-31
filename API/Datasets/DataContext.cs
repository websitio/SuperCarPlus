using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API.Models.Entities;

namespace API.Datasets
{
    public class DataContext : DbContext
    {
     
       public DbSet<Make> Makes {get; set;}
       public DbSet<Feature> Features { get; set; }
       public DbSet<Vehicle> Vehicles    {get; set;}
         public DbSet<Model> Models {get;set;}


       public DataContext(DbContextOptions<DataContext>options) : base(options) {}
  



        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {

                        modelbuilder.Entity<VehicleFeature>()
                        .HasKey(vf => new { vf.VehicleId, vf.FeatureId });

        //     modelbuilder.SharedTypeEntity<Dictionary<string, object>>("VehicleFeature");
        // modelbuilder
        // .Entity<Vehicle>()
        // .HasMany(e=>e.Features)
        // .HasMany(e=>e.Vehicles)
        // .UsingEntity<Dictionary<string, object>>("VehicleFeature",
        // b=>b.HasOne<Feature>().WithMany().HasForeignKey("FeatureId"),
        // b=>b.HasOne<Vehicle>().WithMany().HasForeignKey("VehicleId"));
       
        
        }

    }
}

