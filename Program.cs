namespace Prog_124_S23_L3_Containment_Aggregation
{
    internal class Program
    {
        static List<Engine> _engines;
        static void Main(string[] args)
        {
            int year = 2023;
            Console.WriteLine(year);
            ChangeNumber(ref year);
            Console.WriteLine(year);
        }

        public static void ChangeEngineHP(Engine e)
        {
            e.Hp = 100000;
        }

        public static void ChangeNumber(ref int num)
        {
            num = 1000000;
        }

        public void Example2()
        {
            // Create a new instance of engine with 100
            Engine e = new Engine(100);
            // DIsplaying the hp
            Console.WriteLine(e.Hp);
            // Passing in the instance of the engine to change it to 100000
            ChangeEngineHP(e);
            Console.WriteLine(e.Hp);
        }

        public static void Loop(int count = 10) {

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(i);
            }
        }

        public bool MyTryParse(string value, ref int num)
        {
            try
            {
                num = int.Parse(value);
                return true;
                
            }
            catch (FormatException fe)
            {
                return false;
            }
        }

        public void Example()
        {
            _engines = new List<Engine>();


            GraphicsCard gc = new GraphicsCard(GraphicsCard.Brand.Intel);

            Computer comp = new Computer(gc);

            Engine fastEngine = new Engine(250);
            Engine slowerEngine = new Engine(120);

            _engines.Add(fastEngine);
            _engines.Add(slowerEngine);

            Suspension suspension = new Suspension(-.4f, 5, .5f);

            Car car = new Car("Ford", "Escort", fastEngine, suspension);
            Console.WriteLine(car.ToString());

            Character donkeyKong = new Character(150, "Donkey Kong");
            GoKart goKart = new GoKart(donkeyKong);

            Console.WriteLine(goKart);

            Character toad = new Character(50, "Toad");
            GoKart goKartToad = new GoKart(toad);
            Console.WriteLine(goKartToad);

            Console.WriteLine("Before our try catch");
            // Respond to exceptions
            goKartToad.TweakEngine(-50);
            try
            {

                Console.WriteLine("We reached this line of code");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("This is after our try catch");



        }

        // Containment and Aggregation
        // What is containment

        // What is aggregation
    }
}
