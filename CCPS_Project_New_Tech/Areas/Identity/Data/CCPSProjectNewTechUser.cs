using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CCPS_Project_New_Tech.Areas.Identity.Data;

// Add profile data for application users by adding properties to the CCPS_Project_New_TechUser class
public class CCPSProjectNewTechUser : IdentityUser
{
    [PersonalData]
    [Column(TypeName="nvarchar(100)")]
    public string? Firstname { get; set; }
    [PersonalData]
    [Column(TypeName = "nvarchar(100)")]
    public string? Lastname { get; set; }
}

