#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyFinance.Models;

public class Account
{
    // ================
    // Account ID
    // ================
    [Key]
    public int AccountId { get; set; }

    // ================
    // Account Name
    // ================
    [Required(ErrorMessage ="is required")]
    [Display(Name ="Account Name")]
    public string name { get; set; }
    
    // ================
    // Balance
    // ================
    public int Balance { get; set; } = 0;
    
    // ================
    // Interest increment (over amount of time)
    // ================
    public int InterestIncrement { get; set; } = 0;
    
    // ================
    // Interest amount (% increase)
    // ================
    public double InterestAmount { get; set; } = 0;


    // ================
    // CreatedAt
    // ================
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    // ================
    // UpdatedAt
    // ================
    public DateTime UpdatedAt { get; set; } = DateTime.Now;


    //! ===================================
    //! Relationships
    //! ===================================

    // ================
    // Assigning ParentAccount - ManyToMany
    // ================
    public List<ParentAccount> AccountsParents { get; set; } = new List<ParentAccount>();

    // ================
    // Account to Child - ManyToOne
    // ================
    public int ChildId { get; set; }
    public Child? AccountOwner { get; set; }
    
}