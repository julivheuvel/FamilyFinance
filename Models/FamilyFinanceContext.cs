#pragma warning disable CS8618

using Microsoft.EntityFrameworkCore;
namespace FamilyFinance.Models;

public class FamilyFinanceContext : DbContext 
{
    // This line will always be here. It is what constructs our context upon initialization  
    public FamilyFinanceContext(DbContextOptions options) : base(options) { }    
    // We need to create a new DbSet<Model> for every model in our project that is making a table
    // The name of our table in our database will be based on the name we provide here
    // This is where we provide a plural version of our model to fit table naming standards    
    // public DbSet<Monster> Monsters { get; set; } 

    public DbSet<Parent> Parents { get; set; }
    public DbSet<Child> Children { get; set; }
    public DbSet<ParentChild> ParentChildren { get; set; }
    public DbSet<ParentAccount> ParentAccounts { get; set; }
    
    
    
}