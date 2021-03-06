using Microsoft.AspNet.Identity;
using WebApplicationDemoAppTest.Models;
// <copyright file="UserManagerFactory.cs">Copyright ©  2015</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Microsoft.AspNet.Identity
{
    /// <summary>A factory for Microsoft.AspNet.Identity.UserManager`1[WebApplicationDemoAppTest.Models.ApplicationUser] instances</summary>
    public static partial class UserManagerFactory
    {
        /// <summary>A factory for Microsoft.AspNet.Identity.UserManager`1[WebApplicationDemoAppTest.Models.ApplicationUser] instances</summary>
        [PexFactoryMethod(typeof(UserManager<ApplicationUser>))]
        public static UserManager<ApplicationUser> Create(
            IUserStore<ApplicationUser> store_iUserStore,
            IIdentityMessageService value_iIdentityMessageService,
            IIdentityMessageService value_iIdentityMessageService1,
            IUserTokenProvider<ApplicationUser, string> value_iUserTokenProvider,
            bool value_b,
            int value_i
        )
        {
            UserManager<ApplicationUser> userManager
               = new UserManager<ApplicationUser>(store_iUserStore);
            ((UserManager<ApplicationUser, string>)userManager).EmailService =
              value_iIdentityMessageService;
            ((UserManager<ApplicationUser, string>)userManager).SmsService =
              value_iIdentityMessageService1;
            ((UserManager<ApplicationUser, string>)userManager).UserTokenProvider =
              value_iUserTokenProvider;
            ((UserManager<ApplicationUser, string>)userManager).UserLockoutEnabledByDefault
              = value_b;
            ((UserManager<ApplicationUser, string>)userManager)
              .MaxFailedAccessAttemptsBeforeLockout = value_i;
            return userManager;

            // TODO: Edit factory method of UserManager`1<ApplicationUser>
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
