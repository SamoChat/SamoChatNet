using System;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace SamoChatNet
{
    public class SamoChatData
    {
        //Initiates client
        public static IRestClient client = new RestClient("https://api.samochat.net/");
        
        //Fetches the AccessToken
        private string GetAccessToken()
        {
            //request token
            var restclient = new RestClient("https://samochat.eu.auth0.com/");
            RestRequest request = new RestRequest("oauth/token") { Method = Method.POST };

            //sends the necessary headers
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");

            //sends the necessary parameters
            request.AddParameter("client_id", SamoChatConfig.ClientID);
            request.AddParameter("client_secret", SamoChatConfig.ClientSecret);
            request.AddParameter("audience", "https://api.samochat.net", ParameterType.GetOrPost);
            request.AddParameter("grant_type", "client_credentials");

            var response = restclient.Execute(request);

            JObject output = (JObject)JsonConvert.DeserializeObject(response.Content);

            var apiKey = output["access_token"].ToString();
            return apiKey;
        }

        //Gets the details of the specified profile in json format
        public string GetProfile(string username)
        {
            string profileData;
            try
            {

                var request = new RestRequest("profile/" + username, Method.GET);

                request.AddParameter("Authorization", "Bearer " + GetAccessToken(), ParameterType.HttpHeader);

                var response = client.Execute(request);

                JObject output = (JObject)JsonConvert.DeserializeObject(response.Content);
                profileData = output.ToString();
            }
            catch (NullReferenceException)
            {
                profileData = "Data not available";
            }
            return profileData;
        }

        //Gets the public posts of the specified user in json format
        public string GetPosts(string username)
        {
            string posts;
            try
            {
                var request = new RestRequest("profile/" + username + "/timeline", Method.GET);
                request.AddParameter("Authorization", "Bearer " + GetAccessToken(), ParameterType.HttpHeader);
               
                var response = client.Execute(request);

                JObject output = (JObject)JsonConvert.DeserializeObject(response.Content);
                posts = output.ToString();
            }
            catch (NullReferenceException)
            {
                posts = "Data not available";
            }
            return posts;
        }

        //Fetches the name of the specified user
        public string GetName(string username)
        {
            string name;
            try
            {
                var request = new RestRequest("user/" + username + "?query=name", Method.GET);
                request.AddParameter("Authorization", "Bearer " + GetAccessToken(), ParameterType.HttpHeader);

                var response = client.Execute(request);

                JObject output = (JObject)JsonConvert.DeserializeObject(response.Content);

                name = output["name"].ToString();

            }
            catch (NullReferenceException)
            {
                name = "Data not available";
            }
            return name;
        }

        //Fetches the age of the specified user
        public string GetAge(string username)
        {
            string age;
            try
            {
                var request = new RestRequest("user/" + username + "?query=age", Method.GET);
                request.AddParameter("Authorization", "Bearer " + GetAccessToken(), ParameterType.HttpHeader);

                var response = client.Execute(request);

                JObject output = (JObject)JsonConvert.DeserializeObject(response.Content);
                age = output["age"].ToString();

            }
            catch (NullReferenceException)
            {
                age = "Data not available";
            }
            return age;
        }

        //Fetches the gender of the specified user
        public string GetGender(string username)
        {
            string gender;
            try
            {
                var request = new RestRequest("user/" + username + "?query=gender", Method.GET);
                request.AddParameter("Authorization", "Bearer " + GetAccessToken(), ParameterType.HttpHeader);

                var response = client.Execute(request);

                JObject output = (JObject)JsonConvert.DeserializeObject(response.Content);
                gender = output["gender"].ToString();

            }
            catch (NullReferenceException)
            {
                gender = "Data not available";
            }
            return gender;
        }

        //Fetches the Location of the specified user
        public string GetLocation(string username)
        {
            string location;
            try
            {
                var request = new RestRequest("user/" + username + "?query=location", Method.GET);

                request.AddParameter("Authorization", "Bearer " + GetAccessToken(), ParameterType.HttpHeader);

                var response = client.Execute(request);

                JObject output = (JObject)JsonConvert.DeserializeObject(response.Content);
                location = output["location"].ToString();

            }
            catch (NullReferenceException)
            {
                location = "Data not available";
            }
            return location;
        }

        //Fetches the amount of SamoCredits the specified user has got
        public string GetSamoCredits(string username)
        {
            string samocredits;
            try
            {
                var request = new RestRequest("user/" + username + "?query=samocredits", Method.GET);
                request.AddParameter("Authorization", "Bearer " + GetAccessToken(), ParameterType.HttpHeader);

                var response = client.Execute(request);

                JObject output = (JObject)JsonConvert.DeserializeObject(response.Content);
                samocredits = output["SamoCredits"].ToString();

            }
            catch (NullReferenceException)
            {
                samocredits = "Data not available";
            }
            return samocredits;
        }

        //Fetches the rank of the specified user
        public string GetRank(string username)
        {
            string rank;
            try
            {
                var request = new RestRequest("user/" + username + "?query=rank", Method.GET);
                request.AddParameter("Authorization", "Bearer " + GetAccessToken(), ParameterType.HttpHeader);

                var response = client.Execute(request);

                JObject output = (JObject)JsonConvert.DeserializeObject(response.Content);
                rank = output["rank"].ToString();

            }
            catch (NullReferenceException)
            {
                rank = "Data not available";
            }
            return rank;
        }

        //Fetches the number of public videos the specified user has uploaded
        public string GetVideos(string username)
        {
            string videos;
            try
            {
                var request = new RestRequest("user/" + username + "?query=videos", Method.GET);
                request.AddParameter("Authorization", "Bearer " + GetAccessToken(), ParameterType.HttpHeader);

                var response = client.Execute(request);

                JObject output = (JObject)JsonConvert.DeserializeObject(response.Content);
                videos = output["videos"].ToString();

            }
            catch (NullReferenceException)
            {
                videos = "Data not available";
            }
            return videos;
        }

        //Fetches the number of public photos the specified user has uploaded
        public string GetPhotos(string username)
        {
            string photos;
            try
            {
                var request = new RestRequest("user/" + username + "?query=photos", Method.GET);
                request.AddParameter("Authorization", "Bearer " + GetAccessToken(), ParameterType.HttpHeader);

                var response = client.Execute(request);

                JObject output = (JObject)JsonConvert.DeserializeObject(response.Content);
                photos = output["photos"].ToString();

            }
            catch (NullReferenceException)
            {
                photos = "Data not available";
            }
            return photos;
        }
        // Fetches when the specified user joined SamoChat 
        public string GetJoined(string username)
        {
            string joined;
            try
            {
                var request = new RestRequest("user/" + username + "?query=joined", Method.GET);
                request.AddParameter("Authorization", "Bearer " + GetAccessToken(), ParameterType.HttpHeader);

                var response = client.Execute(request);

                JObject output = (JObject)JsonConvert.DeserializeObject(response.Content);
                joined = output["joined"].ToString();

            }
            catch (NullReferenceException)
            {
                joined = "Data not available";
            }
            return joined;
        }

        //Fetches the about of the specified user
        public string GetAbout(string username)
        {
            string about;
            try
            {
                var request = new RestRequest("user/" + username + "?query=about", Method.GET);

                request.AddParameter("Authorization", "Bearer " + GetAccessToken(), ParameterType.HttpHeader);


                var response = client.Execute(request);

                JObject output = (JObject)JsonConvert.DeserializeObject(response.Content);
                about = output["about"].ToString();

            }
            catch (NullReferenceException)
            {
                about = "Data not available";
            }
            return about;
        }
    }
}

