using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeWEB.Models;
using Microsoft.AspNetCore.Identity;

namespace CodeWEB.Areas.Identity.Data;

// Add profile data for application users by adding properties to the CodeWEBUser class
public class CodeWEBUser : IdentityUser
{
    public DateTime? DoB { get; set; }
    public string? FullName { get; set; }
    public string? Address { get; set; }
    public string? Gender { get; set; }
    public Store? Store { get; set; }
    public virtual ICollection<Order>? Orders { get; set; }

}

