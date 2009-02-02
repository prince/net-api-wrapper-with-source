﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignMonitorAPISample
{
    public class User
    {
        internal static void GetClients()
        {
            string apiKey = "xxxxxxxxxxxxApiKeyxxxxxxxxxxxxxx";

            var result = CampaignMonitorAPIWrapper.User.GetClients(apiKey);

            if (result.Code != 0)
                Console.WriteLine("Error getting user clients : " + result.Code.ToString() + " - " + result.Message);
            else if (result.ReturnObject.Count == 0)
                Console.WriteLine("There are no clients for this user");
            else
                foreach (var client in result.ReturnObject)
                {
                    Console.WriteLine("ClientID : " + client.ClientID);
                    Console.WriteLine("Client Name : " + client.Name);

                    Console.WriteLine("---------------------------------------");
                }
        }

        internal static void GetSystemDate()
        {
            string apiKey = "xxxxxxxxxxxxApiKeyxxxxxxxxxxxxxx";

            var result = CampaignMonitorAPIWrapper.User.GetSystemDate(apiKey);

            if (result.Code != 0)
                Console.WriteLine("Error getting system date : " + result.Code.ToString() + " - " + result.Message);
            else
                Console.WriteLine("System date in users timezone : " + result.ReturnObject.ToString());
        }
    }
}
