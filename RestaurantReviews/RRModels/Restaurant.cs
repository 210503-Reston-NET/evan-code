using System.Collections.Generic;

namespace RRModels
{
    /// <summary>
    /// Data structure used to define a restaurant
    /// </summary>

    public class Restaurant
    {
        //Class Members
        //1. Constructor - use this to create an insance of the class
        //2. Fields - defines the characteristics of a class
        //3. Methods - defines the behavior of a class
        //4. Properties - also known as smart fields - are accessor methods used to access private backing fields
        //Note that properties are analagous to Java getter/setter
        //Property naming convention uses PascalCase (like methods)

        public Restaurant(string name, string city, string state)
        {
            this.Name = name;
            this.City = city;
            this.State = state;   
        }
        public Restaurant()
        {

        }
        /// <summary>
        /// this describes the name of a restaurant
        /// </summary>
        /// <value></value>
        public string Name { get; set; }

        /// <summary>
        /// this describes the Location of a restaurant
        /// </summary>
        /// <value></value>
        public string City { get; set; }

        /// <summary>
        /// this describes the Location of a restaurant
        /// </summary>
        /// <value></value>
        public string State { get; set; }

        /// <summary>
        /// this describes the review of a restaurant
        /// </summary>
        /// <value></value>
        public List<Review> Reviews { get; set; }
        public override string ToString()
        {
            return $" Name: {Name} \n Location: {City}, {State}";
        }
    }
}
