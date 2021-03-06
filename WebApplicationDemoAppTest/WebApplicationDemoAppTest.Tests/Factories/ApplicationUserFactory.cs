using Microsoft.AspNet.Identity.EntityFramework;
using WebApplicationDemoAppTest.Models;
// <copyright file="ApplicationUserFactory.cs">Copyright ©  2015</copyright>

using System;
using Microsoft.Pex.Framework;

namespace WebApplicationDemoAppTest.Models
{
    /// <summary>A factory for WebApplicationDemoAppTest.Models.ApplicationUser instances</summary>
    public static partial class ApplicationUserFactory
    {
        /// <summary>A factory for WebApplicationDemoAppTest.Models.ApplicationUser instances</summary>
        [PexFactoryMethod(typeof(ApplicationUser))]
        public static ApplicationUser Create(
            string value_s,
            bool value_b,
            string value_s1,
            string value_s2,
            string value_s3,
            bool value_b1,
            bool value_b2,
            DateTime? value_null,
            bool value_b3,
            int value_i,
            string value_s4,
            string value_s5
        )
        {
            ApplicationUser applicationUser = new ApplicationUser();
            ((IdentityUser<string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>)
               applicationUser).Email = value_s;
            ((IdentityUser<string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>)
               applicationUser).EmailConfirmed = value_b;
            ((IdentityUser<string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>)
               applicationUser).PasswordHash = value_s1;
            ((IdentityUser<string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>)
               applicationUser).SecurityStamp = value_s2;
            ((IdentityUser<string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>)
               applicationUser).PhoneNumber = value_s3;
            ((IdentityUser<string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>)
               applicationUser).PhoneNumberConfirmed = value_b1;
            ((IdentityUser<string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>)
               applicationUser).TwoFactorEnabled = value_b2;
            ((IdentityUser<string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>)
               applicationUser).LockoutEndDateUtc = value_null;
            ((IdentityUser<string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>)
               applicationUser).LockoutEnabled = value_b3;
            ((IdentityUser<string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>)
               applicationUser).AccessFailedCount = value_i;
            ((IdentityUser<string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>)
               applicationUser).Id = value_s4;
            ((IdentityUser<string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>)
               applicationUser).UserName = value_s5;
            return applicationUser;

            // TODO: Edit factory method of ApplicationUser
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
