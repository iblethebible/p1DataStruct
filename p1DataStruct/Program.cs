namespace p1DataStruct
{
    internal class Program
    {
        static void EndProgram()
        {
            Console.WriteLine("Press anykey to end program");
            Console.ReadKey();
        }
        struct Team
        {
            public string name;
            public string dateEstablished;
            public int tier;
            public int positioninleague;
        }
        struct Player
        {
            public string team;
            public int shirtNumber;
            public string name;
            public string dob;
            public string position;
        }
        static void Main(string[] args)
        {
            Team t1 = new Team();
            t1.name = "AFCCrewe";
            t1.dateEstablished = "02/02/2022";
            t1.tier = 14;
            t1.positioninleague = 1;

            Player p1 = new Player();
            p1.name = "Tom Laight";
            p1.shirtNumber = 7;
            p1.team = "AFCCrewe";
            p1.dob = "02/02/2001";
            p1.position = "CDM";


            Console.WriteLine(t1.name);

            EndProgram();
        }
    }
}