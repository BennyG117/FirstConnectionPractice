//TODO: UPDATE MIGRATIONS IF YOU UPDATE YOUR MODEL (this includes if you update validations, etc)

#pragma warning disable CS8618


using System.ComponentModel.DataAnnotations;
namespace FirstConnectionPractice.Models;

public class Pet
{
    [Key]
    //! PetId =========================
    public int PetId {get; set;}


    //! Name ========================= 
    [Required]
    // [MinLength(2, ErrorMessage = "Must be 2 characters long")]
    // [MaxLength(40, ErrorMessage = "No longer than 40 characters long")]
    public string Name {get; set;}
    

    //! PetType ======================== 
    [Required]
    // [MinLength(2, ErrorMessage = "Must be 2 characters long")]
    public string PetType {get; set;}


    //! Age ======================== 
    [Required]
    // [Display(Name = "Enter URL here: ")]
    public int Age {get; set;}


    //! HasFur ======================== 
    [Required]
    // [Display(Name = "Enter URL here: ")]
    public bool HasFur {get; set;}


    //! CreatedAt ======================== 
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    


    //! UpdatedAt ======================== 
    public DateTime UpdatedAt { get; set; } = DateTime.Now;



}
