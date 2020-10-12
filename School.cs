using System;

namespace SchoolLibrary
{
    class School
    {
        public string Name { get; set; }
        public string Adddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        private string _twitterAddress;
        public string TwitterAddress
        {
            // make sure twitter address starts with @
            get { return _twitterAddress; }
            set 
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                } else 
                {
                    throw new Exception("The Twitter addres must being with @");
                }
            }
        }
    }
}