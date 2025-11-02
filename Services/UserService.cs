using System;
using System.Collections.Generic;
using System.Linq;

namespace QodoTestProject.Services
{
    public class UserService
    {
        // 🚫 בעיית אבטחה: Hardcoded API Key. Qodo אמור לזהות זאת.
        private static readonly string ThirdPartyApiKey = Environment.GetEnvironmentVariable("THIRD_PARTY_API_KEY") ?? throw new InvalidOperationException("THIRD_PARTY_API_KEY environment variable not set.");

        public UserData GetUserData(int userId)
        {
            // כאן נניח שיש קריאת HTTP חיצונית...
            Console.WriteLine($"Fetching data for user {userId} using key {ThirdPartyApiKey}");

            // לוגיקה עסקית פשוטה שמכילה מספר קסם
            return new UserData
            {
                UserId = userId,
                Name = $"User_{userId}",
                // 💵 Magic Number: 0.15 - מספר קבוע שאין לו שם משמעותי
                BonusPoints = userId * 10 * 0.15
            };
        }
    }
}

public class UserData
{
    public int UserId { get; set; }
    public string Name { get; set; }
    public double BonusPoints { get; set; }
    public List<Item> Items { get; set; } = new List<Item>();
}

public class Item
{
    public int Value { get; set; }
    public bool IsActive { get; set; }
}