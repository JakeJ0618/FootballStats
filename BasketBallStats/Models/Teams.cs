using System.Text;

namespace FootballStats.Models
{
    public class Teams
    {
        public Teams()
        {

        }
        public string APIResponse { get; set; }
        public StringBuilder APIResponseMod { get; set; }
        public string TeamName { get; set; }
        public double Wins { get; set; }
        public double Losses { get; set; }
        public double Ties { get; set; }
        public double PassingYds { get; set; }
        public double RushingYds { get; set; }
        public double TD { get; set; }
        public double Interceptions { get; set; }
        public double Cmp { get; set; }
        public double PassingAtt { get; set; }
        public double RushingAtt { get; set; }
        public static List<Teams> TeamStats { get; set; } = new List<Teams>();
        public static List<string> TeamNames { get; set; } = new List<string>() { "Buffalo Bills", "Miami Dolphins", "Philadelphia Eagles", "Kansas City Chiefs", "Chicago Bears", "Green Bay Packers",
        "San Francisco 49ers", "New England Patriots", "Detroit Lions", "Houston Texans", "Minnesota Vikings", "Seattle Seahawks", "Las Vegas Raiders", "New York Giants", "Carolina Panthers"
        ,"New York Jets", "Cincinnati Bengals", "Arizona Cardinals", "Indianapolis Colts", "Washington Commanders", "Baltimore Ravens", "Denver Broncos", "New Orleans Saints", "Tennessee Titans"
        , "Cleveland Browns", "Tampa Bay Buccaneers", "Jacksonville Jaguars", "Los Angeles Chargers", "Atlanta Falcons", "Los Angeles Rams", "Dallas Cowboys", "Pittsburgh Steelers"};


    }
        

    

    
}
