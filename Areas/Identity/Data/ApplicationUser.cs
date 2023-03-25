using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;

namespace AspnetCoreWebApp.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    [PersonalData]
    [Column(TypeName = "nvarchar(256)")]
    public string adress { get; set; }

    [PersonalData]
    [Column(TypeName = "nvarchar(256)")]
    public string managerName { get; set; }

    [PersonalData]
    [Column(TypeName = "nvarchar(256)")]
    public string UserAdress { get; set; }

    [PersonalData]
    [Column(TypeName = "nvarchar(256)")]
    public string UserManagerName { get; set; }

}



