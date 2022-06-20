// See https://aka.ms/new-console-template for more information
namespace Example1
{
  
    class ModeOfMovement 
    {
        public virtual void Movement()
        {
            Console.WriteLine("it will describe the movement");

        }

        
    }
    interface Ifuel
    {
        void DisplayFuelType();

    }

    //Car is a ModeOfMovement--------------------------------------------
    class Car : ModeOfMovement,Ifuel
    {
        public override void Movement()
        {
            Console.WriteLine("Car is mode of movement by road");
        }
        public void DisplayFuelType() {
            Console.WriteLine("Car can have either petrol and diesel as fuel");
        }
        public void AvgSpeed(int speed) { 
        
            Console.WriteLine("Avg speed of car is "+speed);
        }
        public void AvgSpeed(double speed)
        {

            Console.WriteLine("Avg speed of car is " +speed);
        }

    }
        //Ship is a ModeOfMovement--------------------------------------
        class Ship : ModeOfMovement,Ifuel
        {

            public override void Movement()
            {
                Console.WriteLine("Ship is mode of movement by Water");
            }
        public void DisplayFuelType()
        {
            Console.WriteLine("Ship can take gasoil as a fuel");
        }
    }

        //Aeroplane is a ModeOfMovement----------------------------------
        class Aeroplane : ModeOfMovement,Ifuel
        {

            public override void Movement()
            {
                Console.WriteLine("Aeroplane is mode of movement by Air");
            }
           public void DisplayFuelType()
           {
            Console.WriteLine("Aeroplane takes Aviation kerosene as a fuel");
           }
    }
         
        //Tester class
        class Tester
        {
            public static void Main()
            {

                ModeOfMovement Vikrant = new Ship();
                ModeOfMovement BMW = new Car();
                ModeOfMovement Spicejet = new Aeroplane();
                
                Vikrant.Movement();
                BMW.Movement();
                Spicejet.Movement();

            Aeroplane xyz = new Aeroplane();
            Car c = new Car();
                 xyz.DisplayFuelType();
                 c.DisplayFuelType();

            c.AvgSpeed(25);
            c.AvgSpeed(45.50);
            

            }


        }

    }

