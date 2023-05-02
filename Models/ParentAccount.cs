#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace FamilyFinance.Models;

public class ParentAccount
{

    // ================
    // ParentAccount ID
    // ================
    [Key]
    public int ParentAccountId { get; set; }
    
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
    public int ParentId { get; set; }
    public Parent? Parent { get; set; }
    public int AccountId { get; set; }
    public Account? Account { get; set; }
    
}
