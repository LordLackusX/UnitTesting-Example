using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicUnitTestExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicUnitTestExample.Tests
{

    [TestClass()]
    public class OwnerTests
    {

        public Owner _owner;


        [TestInitialize]

        public void Initialize()
        {

            _owner = new Owner("Alexander ST", "freddy", "59145615");

        }




        [TestMethod()]
        public void AdressTest()
        {






            Assert.AreEqual("Alexander ST", _owner.Adress);



            try
            {

                _owner.Adress = "elm Street";
                Assert.Fail();

            }

            catch (Exception)
            {




            }

        }


        [TestMethod()]
        public void NameTest()
        {


            Assert.AreEqual("freddy", _owner.Name);


            try
            {


                _owner.Name = "bob";
                Assert.Fail();

            }

            catch (ArgumentOutOfRangeException)
            {



            }



        }



        [TestMethod]

        public void PhoneTest()
        {

            Assert.AreEqual("59145615", _owner.Phone);



            try
            {
                _owner.Phone = "151545";
                Assert.Fail();



            }
            catch (ArgumentOutOfRangeException)
            {



            }
        }

    }
}