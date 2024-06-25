using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHub.DataAccess.Data;
using BookHub.Models;
using BookHub.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BookHub.DataAccess.DbInitializer
{
	public class DbInitializer : IDbInitializer
	{
		private readonly UserManager<IdentityUser> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;
		private readonly ApplicationDbContext _db;

        public DbInitializer(UserManager<IdentityUser> userManager,
			RoleManager<IdentityRole> roleManager,
			ApplicationDbContext db)
        {
            _roleManager = roleManager;
			_userManager = userManager;
			_db = db;
        }
        public void Initialize()
		{

			// Migrations if they are not applied
			try {
				if (_db.Database.GetPendingMigrations().Count() > 0)
				{
					_db.Database.Migrate();
				}
			}
			catch(Exception e) {
				// Create roles if they are not created
				if (!_roleManager.RoleExistsAsync(SD.Role_Customer).GetAwaiter().GetResult())
				{
					_roleManager.CreateAsync(new IdentityRole(SD.Role_Customer)).GetAwaiter().GetResult();
					_roleManager.CreateAsync(new IdentityRole(SD.Role_Employee)).GetAwaiter().GetResult();
					_roleManager.CreateAsync(new IdentityRole(SD.Role_Admin)).GetAwaiter().GetResult();
					_roleManager.CreateAsync(new IdentityRole(SD.Role_Company)).GetAwaiter().GetResult();

					// if roles are not created then we will create admin user as well
					_userManager.CreateAsync(new ApplicationUser
					{
						UserName = "admin@bookhub.com",
						Email = "admin@bookhub.com",
						Name = "Krishna Pandey",
						PhoneNumber = "9727843032",
						StreetAddress = "Munich 123",
						State = "Bavaria",
						PostalCode = "44600",
						City = "Munich"
					}, "Admin@143").GetAwaiter().GetResult();

					ApplicationUser user = _db.ApplicationUsers.FirstOrDefault(u => u.Email == "admin@bookhub.com");
					_userManager.AddToRoleAsync(user, SD.Role_Admin).GetAwaiter().GetResult();

				}

				return;
				
			}
		}
	}
}
