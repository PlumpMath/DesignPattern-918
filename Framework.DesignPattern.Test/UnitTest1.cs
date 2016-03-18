using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Framework.DesignPattern.Strategy;

namespace Framework.DesignPattern.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Product product = new Product();

            product.Price = 10;

            product.SetDiscount(new StudentDiscount());

            decimal p = product.Price;

            Assert.IsTrue(product.Price == 8);
        }
    }

    class User
    {
        public int id { get; set; }

        public string name { get; set; }

        public User()
        {
        }

        public User(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
