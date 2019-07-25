using System;
using PetRegister.Models;
using Microsoft.EntityFrameworkCore;
namespace PetRegister
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<PetOwner> PetOwnerList { get; set; }
         
        //public string ConnectionString { get; set; }    
    
        //public ApplicationDbContext(string connectionString)    
        //{    
        //    this.ConnectionString = connectionString;    
        //}    
    
        //private MySqlConnection GetConnection()    
        //{    
        //    return new MySqlConnection(ConnectionString);    
        //}  
}
}