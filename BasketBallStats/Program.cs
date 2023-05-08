using FootballStats.Models;

namespace FootballStats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();

            
        }
        public Program()
        {
            var team = new Teams();
            TeamsRepository.GetAPIResponse();

            foreach(var stats in Teams.TeamStats)
            {
                Console.WriteLine($"Team Name: {stats.TeamName}");
                Console.WriteLine($"Record: Wins: {stats.Wins} Losses: {stats.Losses} Ties: {stats.Ties}");
                Console.WriteLine($"Passing Offense: Att: {stats.PassingAtt} Cmp: {stats.Cmp} Yds: {stats.PassingYds} Interceptions thrown: {stats.Interceptions}");
                Console.WriteLine($"Rushing Offense: Att: {stats.RushingAtt} Yds: {stats.RushingYds}");
            }
        }
    }

}