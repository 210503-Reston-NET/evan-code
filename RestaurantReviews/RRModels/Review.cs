namespace RRModels
{
    public class Review
    {  
        /// <summary>
        /// This describes the numeric rating of a restaraunt
        /// </summary>
        /// <value></value>
        public int Rating { get; set; }
        /// <summary>
        /// verbose description of the dining experience
        /// </summary>
        /// <value></value>
        public string Description { get; set; }

        public override string ToString()
        {
            return $"\t Rating: {Rating} \n\t Description: {Description}";
        }
    }
}