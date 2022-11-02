using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;
using System.Web.Mvc;
using customer_supports.Controllers;
using customer_supports.Models;

namespace customer_supports
{
    [TestFixture]
    public class customer_support_class
    {
        [TestCase]
       public void userinfo_test()       
        {
           phase4Entities db=new phase4Entities();

            var found = db.userinfoes.ToList();
            
            Assert.AreEqual(1,found[0].userid);
            Assert.AreEqual("kannan@123", found[2].passwords);
        }
        
    }
}