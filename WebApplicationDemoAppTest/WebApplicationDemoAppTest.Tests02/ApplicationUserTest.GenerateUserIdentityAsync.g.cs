using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNet.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using WebApplicationDemoAppTest.Models;
using Microsoft.Pex.Framework.Generated;
// <copyright file="ApplicationUserTest.GenerateUserIdentityAsync.g.cs">Copyright ©  2015</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace WebApplicationDemoAppTest.Models.Tests
{
    public partial class ApplicationUserTest
    {

[TestMethod]
[PexGeneratedBy(typeof(ApplicationUserTest))]
public void GenerateUserIdentityAsync877()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ApplicationUser applicationUser;
      Task<ClaimsIdentity> task;
      applicationUser = ApplicationUserFactory.Create
                            ((string)null, false, (string)null, (string)null, (string)null, false, 
                             false, default(DateTime?), false, 0, (string)null, (string)null);
      task = this.GenerateUserIdentityAsync
                 (applicationUser, (UserManager<ApplicationUser>)null);
      disposables.Add((IDisposable)task);
      disposables.Dispose();
      Assert.IsNotNull((object)task);
      Assert.AreEqual<TaskStatus>(TaskStatus.Faulted, ((Task)task).Status);
      Assert.AreEqual<bool>(false, ((Task)task).IsCanceled);
      Assert.IsNull(((Task)task).AsyncState);
      Assert.AreEqual<bool>(true, ((Task)task).IsFaulted);
      Assert.IsNotNull((object)applicationUser);
      Assert.AreEqual<string>((string)null, ((IdentityUser
                                                  <string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>)
                                               applicationUser).Email);
      Assert.AreEqual<bool>(false, ((IdentityUser
                                         <string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>)
                                      applicationUser).EmailConfirmed);
      Assert.AreEqual<string>((string)null, ((IdentityUser
                                                  <string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>)
                                               applicationUser).PasswordHash);
      Assert.AreEqual<string>((string)null, ((IdentityUser
                                                  <string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>)
                                               applicationUser).SecurityStamp);
      Assert.AreEqual<string>((string)null, ((IdentityUser
                                                  <string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>)
                                               applicationUser).PhoneNumber);
      Assert.AreEqual<bool>(false, ((IdentityUser
                                         <string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>)
                                      applicationUser).PhoneNumberConfirmed);
      Assert.AreEqual<bool>(false, ((IdentityUser
                                         <string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>)
                                      applicationUser).TwoFactorEnabled);
      Assert.IsNull((object)(((IdentityUser
                                   <string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>)
                                applicationUser).LockoutEndDateUtc));
      Assert.AreEqual<bool>(false, ((IdentityUser
                                         <string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>)
                                      applicationUser).LockoutEnabled);
      Assert.AreEqual<int>(0, ((IdentityUser
                                    <string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>)
                                 applicationUser).AccessFailedCount);
      Assert.IsNotNull(((IdentityUser
                             <string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>)
                          applicationUser).Roles);
      Assert.IsNotNull(((IdentityUser
                             <string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>)
                          applicationUser).Claims);
      Assert.IsNotNull(((IdentityUser
                             <string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>)
                          applicationUser).Logins);
      Assert.AreEqual<string>((string)null, ((IdentityUser
                                                  <string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>)
                                               applicationUser).Id);
      Assert.AreEqual<string>((string)null, ((IdentityUser
                                                  <string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>)
                                               applicationUser).UserName);
    }
}
    }
}
