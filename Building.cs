using System;

namespace Planner
{
    public class Building 
    {
        private string _designer;
        private  DateTime _dateConstructed;
        private string _address;
        private string _owner;

        public int Stories {get; set;}
        public double Width {get; set;}
        public double Depth {get; set;}
        public string Volume {
            get 
            {
                return $"{Width * Depth * (3 * Stories)}";
            }
        }

        public Building(string address){
            _address = address;
        }

        static void Main(string[] args)
        {

        }
    } 
}
