using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicUnitTestExample
{

    /// <summary>
    /// 
    /// this is our owner Class, which holds all the atributes and operations 
    /// </summary>

    public class Owner
    {
        public string _adress;
        public string _name;
        public string _phone;

        /// <summary>
        /// toString Method 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Adress + Name + Phone;
        }

        /// <summary>
        /// Owner constructor with Parameters 
        /// </summary>
        /// <param name="Adress"></param>
        /// <param name="Name"></param>
        /// <param name="Phone"></param>
        public Owner(string Adress, string Name, string Phone)
        {


            _adress = Adress;
            _name = Name;
            _phone = Phone;



        }

        /// <summary>
        /// initialization of property : Adress
        /// </summary>
        public string Adress
        {

            get { return _adress; }


            set
            {

                if (value.Length < 6)

                    throw new ArgumentOutOfRangeException("The Adress must have more than 6 characters ");
                {
                    _adress = value;
                }
            }


        }

        /// <summary>
        /// Initialization of property : Name 
        /// </summary>
        public string Name
        {

            get { return _name; }




            set
            {
                if (value.Length < 4)

                    throw new ArgumentOutOfRangeException("the name must have more han 4 characters  ");

                _name = value;
            }


        }

        /// <summary>
        ///  Initialization of Property :  phone
        /// </summary>
        public string Phone
        {

            get { return _phone; }



            set
            {

                if (value.Length != 8)

                    throw new ArgumentOutOfRangeException("phone number not valid...");

                _phone = value;
            }


        }

    }




}
