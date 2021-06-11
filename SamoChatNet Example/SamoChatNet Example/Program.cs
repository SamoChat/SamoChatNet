using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SamoChatNet;

namespace SamoChatNet_example
{
    class Program
    {
        static void Main(string[] args)
        {
            SamoChatData data = new SamoChatData();

            //Client Credentials
            SamoChatConfig.ClientID = "ClientID";
            SamoChatConfig.ClientSecret = "ClientSecret";

            string username = "SamoChat";

            //Fetches the profile details
            Console.WriteLine("Name: " + data.GetName(username));
            Console.WriteLine("Age: " + data.GetAge(username));
            Console.WriteLine("Gender: " + data.GetGender(username));
            Console.WriteLine("Location: " + data.GetLocation(username));
            Console.WriteLine("SamoCredits: " + data.GetSamoCredits(username));
            Console.WriteLine("Rank: " + data.GetRank(username));
            Console.WriteLine("Videos: " + data.GetVideos(username));
            Console.WriteLine("Photos: " + data.GetPhotos(username));
            Console.WriteLine("Joined: " + data.GetJoined(username));
            Console.WriteLine("About: " + data.GetAbout(username) + "\n");

            // Fetches the profile data
            Console.WriteLine("profile: " + data.GetProfile(username)+ "\n");

            // Fetches public posts
            Console.WriteLine("Posts: " + data.GetPosts(username));
          
            Console.ReadLine();
        }
    }
}
