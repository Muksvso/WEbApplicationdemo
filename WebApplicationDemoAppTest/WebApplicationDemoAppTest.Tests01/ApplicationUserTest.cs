// <copyright file="ApplicationUserTest.cs">Copyright ©  2015</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplicationDemoAppTest.Models;

namespace WebApplicationDemoAppTest.Models.Tests
{
    [TestClass]
    [PexClass(typeof(ApplicationUser))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ApplicationUserTest
    {
    }
}
