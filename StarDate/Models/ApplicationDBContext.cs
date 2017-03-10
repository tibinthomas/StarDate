using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using StarDate.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarDate.Models
{
    public class ApplicationDBContext : IdentityDbContext<ApplicationUser>
    {
        
    }
}
