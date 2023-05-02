#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace FamilyFinance.Models;

public class ParentChild
{

    // ================
    // ParentChild ID
    // ================
    [Key]
    public int ParentChildId { get; set; }
    
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
    public int ChildId { get; set; }
    public Child? Child { get; set; }
    

}
