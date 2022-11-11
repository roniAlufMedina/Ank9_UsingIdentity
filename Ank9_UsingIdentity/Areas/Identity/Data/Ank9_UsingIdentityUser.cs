using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Ank9_UsingIdentity.Areas.Identity.Data;

// Add profile data for application users by adding properties to the Ank9_UsingIdentityUser class
public class Ank9_UsingIdentityUser : IdentityUser
{
    [PersonalData]
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    [PersonalData]
    [Required]
    [StringLength(50,MinimumLength =5)]
    public string LastName { get; set;}

    [PersonalData]
    [Required]
    public int IdNumber { get; set;}
}

