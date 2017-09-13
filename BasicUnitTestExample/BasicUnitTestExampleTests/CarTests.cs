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
    public class CarTests
    {

        public Car _Car;




        [TestInitialize]

        public void Initialize()
        {
            _Car = new Car("toyota", "5546246", 3);


        }



        [TestMethod()]
        public void testModel()
        {


            Assert.AreEqual("toyota", _Car.Model);




            try
            {
                _Car.Model = null;
                //Assert.Fail();

            }
            catch (ArgumentNullException)
            {


            }
        }



        [TestMethod()]

        public void testDoors()
        {



            //Assert.AreEqual(3, _Car.Doors);


            _Car.Doors = 4;
            Assert.AreEqual(4, _Car.Doors);


            //_Car.Doors = 5;
            //Assert.AreEqual(5, _Car.Doors);



            try
            {
                _Car.Doors = 6;
                Assert.Fail();



            }

            catch (ArgumentOutOfRangeException)
            {





            }

        }



        [TestMethod()]

        public void registrationNumber()
        {


            Assert.AreEqual("5546246", _Car.RegistrationNumber);

            try
            {
                _Car.RegistrationNumber = "qgrt";
                Assert.Fail();


            }
            catch (ArgumentOutOfRangeException)
            {


            }
        }

        [TestMethod]

        public void ColorTest()
        {




        }

    }
}