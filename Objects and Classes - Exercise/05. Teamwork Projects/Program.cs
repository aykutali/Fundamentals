
namespace _05._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            int teamCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < teamCount; i++)
            {
                List<string> creatingCommands = Console.ReadLine()
                    .Split('-')
                    .ToList();

                string currCreator = creatingCommands[0];
                string currTeamName = creatingCommands[1];

                bool isAlreadyCreated = false;
                foreach (var item in teams)
                {
                    if (item.TeamName == currTeamName)
                    {
                        isAlreadyCreated = true;
                    }
                }

                bool isCreatorNotUnique = false;
                foreach (var item in teams)
                {
                    if (item.Creator == currCreator)
                    {
                        isCreatorNotUnique = true;
                    }
                }

                if (isAlreadyCreated)
                {
                    Console.WriteLine($"Team {currTeamName} was already created!");
                    continue;
                }

                if (isCreatorNotUnique)
                {
                    Console.WriteLine($"{currCreator} cannot create another team!");
                    continue;
                }

                Team currTeam = new Team(currTeamName, currCreator);
                Console.WriteLine($"Team {currTeamName} has been created by {currCreator}!");
                teams.Add(currTeam);
            }

            string input = "";
            while ((input = Console.ReadLine()) != "end of assignment")
            {
                List<string> addMembersCommand = input.Split("->").ToList();

                string currMember = addMembersCommand[0];
                string currTeam = addMembersCommand[1];

                bool isTeamExist = false;
                foreach (var item in teams)
                {
                    if (item.TeamName == currTeam)
                    {
                        isTeamExist = true;
                        break;
                    }
                }

                bool isMemberNotAJoinAnotherTeam = false;
                foreach (var item in teams)
                {
                    if (item.Members.Contains(currMember) || item.Creator == currMember)
                    {
                        isMemberNotAJoinAnotherTeam = true;
                    }

                }

                if (!isTeamExist)
                {
                    Console.WriteLine($"Team {currTeam} does not exist!");
                    continue;
                }

                if (isMemberNotAJoinAnotherTeam)
                {
                    Console.WriteLine($"Member {currMember} cannot join team {currTeam}!");
                    continue;
                }

                foreach (var item in teams)
                {
                    if (item.TeamName == currTeam)
                    {
                        item.AddMember(currMember);
                    }
                }
            }

            List<Team> disbandedTeams = new List<Team>();

            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].Members.Count < 1)
                {
                    disbandedTeams.Add(teams[i]);
                    teams.Remove(teams[i]);
                    i--;
                }
            }

            List<Team> sortedDisbands =
                disbandedTeams.OrderBy(x => x.TeamName)
                .ToList();

            List<Team> sortedTeams =
                teams.OrderByDescending(x => x.Members.Count)
                    .ThenBy(x => x.TeamName)
                    .ToList();

            //Print

            foreach (var team in sortedTeams)
            {
                team.Print();
            }

            Console.WriteLine($"Teams to disband:");
            foreach (var team in sortedDisbands)
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }


    public class Team
    {
        public Team(string name, string creatorName)
        {
            TeamName = name;
            Creator = creatorName;
            Members = new List<string>();
        }
        public string TeamName { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; } = new List<string>();

        public void Register(string teamName, string creator)
        {
            TeamName = teamName;
            Creator = creator;
            Console.WriteLine($"Team {TeamName} has been created by {Creator}!");
        }

        public void AddMember(string member)
        {
            Members.Add(member);
        }
        public void Print()
        {
            Members.Sort();

            Console.WriteLine(TeamName);
            Console.WriteLine($"- {Creator}");

            foreach (var member in Members)
            {
                Console.WriteLine($"-- {member}");
            }
        }
    }
}