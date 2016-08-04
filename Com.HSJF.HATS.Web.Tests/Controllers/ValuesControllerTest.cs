using Com.HSJF.HATS.Web;
using Com.HSJF.HATS.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace Com.HSJF.HATS.Web.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // 排列
            ValuesController controller = new ValuesController();

            // 操作
            //   var result = controller.Get("test");

            // 断言
            //Assert.IsNotNull(result);
        }
    }
}