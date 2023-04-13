namespace Prog_124_S23_L3_Containment_Aggregation
{
    internal class Program
    {
        static List<Engine> _engines;
        static void Main(string[] args)
        {
            _engines = new List<Engine>();


            GraphicsCard gc = new GraphicsCard(GraphicsCard.Brand.Intel);

            Computer comp = new Computer(gc);

            Engine fastEngine = new Engine(250);
            Engine slowerEngine = new Engine(120);

            _engines.Add(fastEngine);
            _engines.Add(slowerEngine);

            Suspension suspension = new Suspension(-.4f, 5, .5f);

            Car car = new Car("Ford", "Escort" , fastEngine, suspension);
            Console.WriteLine(car.ToString());

            Character donkeyKong = new Character(150, "Donkey Kong");
            GoKart goKart = new GoKart(donkeyKong);

            Console.WriteLine(goKart);

            Character toad = new Character(50, "Toad");
            GoKart goKartToad = new GoKart(toad);

            Console.WriteLine(goKartToad);


        }

        public static void Loop(int count = 10) {

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(i);
            }
        }

        // Containment and Aggregation
        // What is containment

        // What is aggregation
    }
}
