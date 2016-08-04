using Com.HSJF.HATS.FrameWork.DAL.SystemSetting.Users;
using Microsoft.AspNet.Identity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Com.HSJF.HATS.Web.Tests.Controllers
{
    [TestClass]
    public class userTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            PermissionDAL Permission = new PermissionDAL();
            UserDAL user = new UserDAL();
            user.ResetPassword("as", "asd");
        }
    }
}