using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicUnitTestExample
{

    /// <summary>
    /// this is our  car class , holds all the attributes and operations.
    /// </summary>

    public class Car
    {
        public int _doors;
        public string _model;
        public string _RegistrationNO;
        public enum color { red, blue, green, white, grey, black }

        public color Carcolor { get; set; }


        public Owner owner { get; set; }


        /// <summary>
        /// override To string method 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            return Model + Doors + RegistrationNumber;


        }

        /// <summary>
        ///  Car constructor with parameters 
        /// </summary>
        /// <param name="Model"></param>
        /// <param name="RegistrationNO"></param>
        /// <param name="Doors"></param>
        public Car(string Model, string RegistrationNO, int Doors)
        {

            _doors = Doors;
            _model = Model;
            _RegistrationNO = RegistrationNO;




        }



        /// <summary>
        /// Initializing Doors Property 
        /// </summary>
        public int Doors
        {
            get { return _doors; }




            set
            {

                if (value < 2 || value > 5)
                    throw new ArgumentOutOfRangeException(" door must be in a range of 2 to 5 ");


                _doors = value;
            }



        }


        /// <summary>
        /// Initializing  Model Property 
        /// </summary>
        public string Model
        {
            get { return _model; }



            set
            {

                if (!string.IsNullOrEmpty(_model = ""))

                    throw new ArgumentNullException();

                _model = value;
            }





        }
        /// <summary>
        /// 
        /// Initializing RegistrationNumber Property 
        /// 
        /// </summary>
        public string RegistrationNumber
        {

            get { return _RegistrationNO; }

            set
            {
                if (value.Length != 7)

                    throw new ArgumentOutOfRangeException("reistration number must have exactly 7 characters !! ");

                _RegistrationNO = value;
            }
        }


    }


}
