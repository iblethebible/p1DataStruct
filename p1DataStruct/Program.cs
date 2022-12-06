using System.Runtime.InteropServices;

namespace p1DataStruct
{
    internal class Program
    {

        //method to end program
        static void EndProgram()
        {
            Console.WriteLine("Press anykey to end program");
            Console.ReadKey();
        }
      
        //creat structure for team
        struct Team
        {
            public string name;
            public string dateEstablished;
            public int tier;
            public int positioninleague;
            //create constructor for team
            public Team(string name, string dateEstablished, int tier, int posiitioninleague)
            {
                this.name = name;
                this.dateEstablished = dateEstablished;
                this.tier = tier;
                this.positioninleague = posiitioninleague;
            }
            

            //method in struct to set team
            public void SetTeam()
            {
                this.name = Console.ReadLine();
            }        
        }

        //create struct for player
        struct Player
        {
            public string team;
            public int shirtNumber;
            public string name;
            public string dob;
            public string position;
           
            //constructor for player
            public Player(string team, int shirtNumber, string name, string dob, string position)
            {
                this.team = team;
                this.shirtNumber = shirtNumber;
                this.name = name;
                this.dob = dob;
                this.position = position;
            }
        }
        static void Main(string[] args)
        {

            //create team with constructor
            Team t1 = new Team("AFCCrewe", "02/02/02", 14, 1);

            
            //create player with constructor
            Player p1 = new Player("AFCCrewe", 7, "Tom Laight", "02/02/02", "CDM");
            Player p2 = new Player("AFCCrewe", 8, "Ronaldo", "02/02/95", "Striker");


            Console.WriteLine("The current team name is:");
            Console.WriteLine(t1.name);

            //Change team name using SetTeam method
            Console.WriteLine("Change the team name:");
            t1.SetTeam();


            Console.WriteLine(p1.name + " plays for " + t1.name);
            

            EndProgram();
        }
    }
}