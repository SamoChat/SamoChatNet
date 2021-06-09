using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SamoChatNet;

namespace SamoChatNetTest
{
    [TestClass]
    public class UnitTest1
    {

        SamoChatData data = new SamoChatData();

        string ClientID = Environment.GetEnvironmentVariable("ClientID");
        string ClientSecret = Environment.GetEnvironmentVariable("ClientSecret");

        [TestMethod]
        public void TestGetAge()
        {
            SamoChatConfig.ClientID = ClientID;
            SamoChatConfig.ClientSecret = ClientSecret;

            var ActualAge = data.GetAge("SamoChat");

            var ExpectedAge = " 13 years ";

            //Checks if the two values are equal
            Assert.AreEqual(ExpectedAge, ActualAge);
        }

        [TestMethod]
        public void TestGetName()
        {
            SamoChatConfig.ClientID = ClientID;
            SamoChatConfig.ClientSecret = ClientSecret;

            var ActualName = data.GetName("SamoChat");

            var ExpectedName = "SamoChat";

            //Checks if the two values are equal
            Assert.AreEqual(ExpectedName, ActualName);
        }

        [TestMethod]
        public void TestGetGender()
        {
            SamoChatConfig.ClientID = ClientID;
            SamoChatConfig.ClientSecret = ClientSecret;

            var ActualGender = data.GetGender("SamoChat");

            var ExpectedGender = "Male";

            //Checks if the two values are equal
            Assert.AreEqual(ExpectedGender, ActualGender);
        }
        [TestMethod]
        public void TestGetLocation()
        {
            SamoChatConfig.ClientID = ClientID;
            SamoChatConfig.ClientSecret = ClientSecret;

            var ActualLocation = data.GetLocation("SamoChat");

            var ExpectedLocation = "Søborg, Danmark";

            //Checks if the two values are equal
            Assert.AreEqual(ExpectedLocation, ActualLocation);
        }

        [TestMethod]
        public void TestGetSamoCredits()
        {
            SamoChatConfig.ClientID = ClientID;
            SamoChatConfig.ClientSecret = ClientSecret;

            var ActualSamoCredits = data.GetSamoCredits("SamoChat");

            var ExpectedSamoCredits = "100.000.334";

            //Checks if the two values are equal
            Assert.AreEqual(ExpectedSamoCredits, ActualSamoCredits);
        }

        [TestMethod]

        public void TestGetRank()
        {
            SamoChatConfig.ClientID = ClientID;
            SamoChatConfig.ClientSecret = ClientSecret;

            var ActualRank = data.GetRank("SamoChat");

            var ExpectedRank = "Elite";

            //Checks if the two values are equal
            Assert.AreEqual(ExpectedRank, ActualRank);
        }

        [TestMethod]

        public void TestGetVideos()
        {
            SamoChatConfig.ClientID = ClientID;
            SamoChatConfig.ClientSecret = ClientSecret;

            var ActualVideos = data.GetVideos("SamoChat");

            var ExpectedVideos = "1";

            //Checks if the two values are equal
            Assert.AreEqual(ExpectedVideos, ActualVideos);
        }

        [TestMethod]
        public void TestGetPhotos()
        {
            SamoChatConfig.ClientID = ClientID;
            SamoChatConfig.ClientSecret = ClientSecret;

            var ActualPhotos = data.GetPhotos("SamoChat");

            var ExpectedPhotos = "30";

            //Checks if the two values are equal
            Assert.AreEqual(ExpectedPhotos, ActualPhotos);
        }

        [TestMethod]
        public void TestGetJoined()
        {
            SamoChatConfig.ClientID = ClientID;
            SamoChatConfig.ClientSecret = ClientSecret;

            var ActualJoined = data.GetJoined("SamoChat");

            var ExpectedJoined = "   Member since 2 years ago  ";

            //Checks if the two values are equal
            Assert.AreEqual(ExpectedJoined, ActualJoined);
        }

        [TestMethod]
        public void TestGetAbout()
        {
            SamoChatConfig.ClientID = ClientID;
            SamoChatConfig.ClientSecret = ClientSecret;

            var ActualAbout = data.GetAbout("SamoChat");

            var ExpectedAbout = " What's your idea?: To connect everyone, everywhere in a 💯 % secure and private way  About Me: We are the first Social media to truly respect and guard your privacy. Made in  but based in 🇩🇰  Website: Samochat.net ";

            //Checks if the two values are equal
            Assert.AreEqual(ExpectedAbout, ActualAbout);
        }
    }
}
