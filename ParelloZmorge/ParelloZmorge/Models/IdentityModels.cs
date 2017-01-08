using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using ParelloZmorge.BusinessEntities;

namespace ParelloZmorge.Models
{
    // Sie können Profildaten für den Benutzer durch Hinzufügen weiterer Eigenschaften zur ApplicationUser-Klasse hinzufügen. Weitere Informationen finden Sie unter "http://go.microsoft.com/fwlink/?LinkID=317594".
    public class ApplicationUser : IdentityUser
    {
        public virtual List<Order> Orders { get; set; }

        [Required]
        public string Prename { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string WorkPlaceHint { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Beachten Sie, dass der "authenticationType" mit dem in "CookieAuthenticationOptions.AuthenticationType" definierten Typ übereinstimmen muss.
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Benutzerdefinierte Benutzeransprüche hier hinzufügen
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

		public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
		public DbSet<ProductOrderLinkification> ProductOrderLinkifications { get; set; }

		public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
	}
}