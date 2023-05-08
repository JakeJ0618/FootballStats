using FootballStats.Models;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace FootballStats
{
    public class TeamsRepository 
    {
        
        public static void GetAPIResponse()
        {
            var client = new RestClient("https://nfl-team-stats1.p.rapidapi.com/teamStats");
            var request = new RestRequest();
            request.AddHeader("content-type", "application/octet-stream");
            request.AddHeader("X-RapidAPI-Host", "nfl-team-stats1.p.rapidapi.com");
            var response = client.Execute(request);


            for (var i = 0; i < Teams.TeamNames.Count; i++)
            {
                var team = new Teams();
                team.TeamName = JObject.Parse(response.Content)["stats"][Teams.TeamNames[i]]["Standings"]["Tm"].ToString();
                team.Wins = double.Parse(JObject.Parse(response.Content)["stats"][Teams.TeamNames[i]]["Standings"]["W"].ToString());
                team.Wins = double.Parse(JObject.Parse(response.Content)["stats"][Teams.TeamNames[i]]["Standings"]["W"].ToString());
                team.Losses = double.Parse(JObject.Parse(response.Content)["stats"][Teams.TeamNames[i]]["Standings"]["L"].ToString());
                team.PassingAtt = double.Parse(JObject.Parse(response.Content)["stats"][Teams.TeamNames[i]]["Offense"]["Passing"]["Att"].ToString());
                team.Cmp = double.Parse(JObject.Parse(response.Content)["stats"][Teams.TeamNames[i]]["Offense"]["Passing"]["Cmp"].ToString());
                team.Interceptions = double.Parse(JObject.Parse(response.Content)["stats"][Teams.TeamNames[i]]["Offense"]["Passing"]["Int"].ToString());
                team.PassingYds = double.Parse(JObject.Parse(response.Content)["stats"][Teams.TeamNames[i]]["Offense"]["Passing"]["Yds"].ToString());
                team.RushingAtt = double.Parse(JObject.Parse(response.Content)["stats"][Teams.TeamNames[i]]["Offense"]["Rushing"]["Att"].ToString());
                team.RushingYds = double.Parse(JObject.Parse(response.Content)["stats"][Teams.TeamNames[i]]["Offense"]["Rushing"]["Yds"].ToString());
                team.Ties = double.Parse(JObject.Parse(response.Content)["stats"][Teams.TeamNames[i]]["Standings"]["T"].ToString());
                Teams.TeamStats.Add(team);
            }

        }




    }
}
