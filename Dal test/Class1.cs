using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Dal_test
{
    public class Class1
    {
        [TestFixture]
        public class customer_support_class
        {
            [TestCase]
            void userinfo_test(userinfo log)
            {
                phase4Entities db = new phase4Entities();

                var found = db.userinfoes.ToList();

                Assert.AreEqual(1, found[0].userid);
                Assert.AreEqual("kannan@123", found[2].passwords);
            }

        }
    }
}
