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

        public void Construct ()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase (string name)
        {
            _owner = name;
        }

        public void Designer (string designerName)
        {
           _designer = designerName;
        }

    
   
        static void Main(string[] args)
        {
            Console.WriteLine();
            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            FiveOneTwoEigth.Width = 50;
            FiveOneTwoEigth.Depth = 30;
            FiveOneTwoEigth.Stories = 20;
            FiveOneTwoEigth.Designer("Denzel Washington");
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Robert Oppenheimer");

            Console.WriteLine(FiveOneTwoEigth._address);
            Console.WriteLine("---------------");
            Console.WriteLine("Designed by " + FiveOneTwoEigth._designer);
            Console.WriteLine("Constructed on " + FiveOneTwoEigth._dateConstructed);
            Console.WriteLine("Owned by " + FiveOneTwoEigth._owner);
            Console.WriteLine(FiveOneTwoEigth.Volume + " cubic meters of space");

            Console.WriteLine();

            Building FiveOhFiveSouth = new Building("505 South Avenue");
            FiveOhFiveSouth.Width = 90;
            FiveOhFiveSouth.Depth = 70;
            FiveOhFiveSouth.Stories = 40;
            FiveOhFiveSouth.Designer("Annette Bening");
            FiveOhFiveSouth.Construct();
            FiveOhFiveSouth.Purchase("Robert Frost");
            
            Console.WriteLine(FiveOhFiveSouth._address);
            Console.WriteLine("---------------");
            Console.WriteLine("Designed by " + FiveOhFiveSouth._designer);
            Console.WriteLine("Constructed on " + FiveOhFiveSouth._dateConstructed);
            Console.WriteLine("Owned by " + FiveOhFiveSouth._owner);
            Console.WriteLine(FiveOhFiveSouth.Volume + " cubic meters of space");

            Console.WriteLine();

            Building TwentyNineWest = new Building("29 West Street");
            TwentyNineWest.Width = 30;
            TwentyNineWest.Depth = 20;
            TwentyNineWest.Stories = 7;
            TwentyNineWest.Designer("Timothy Olyphant");
            TwentyNineWest.Construct();
            TwentyNineWest.Purchase("Robert McNamara");
            
            Console.WriteLine(TwentyNineWest._address);
            Console.WriteLine("---------------");
            Console.WriteLine("Designed by " + TwentyNineWest._designer);
            Console.WriteLine("Constructed on " + TwentyNineWest._dateConstructed);
            Console.WriteLine("Owned by " + TwentyNineWest._owner);
            Console.WriteLine(TwentyNineWest.Volume + " cubic meters of space");

            Console.WriteLine();
        }
     
    } 
}
