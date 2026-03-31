using System;
using System.Diagnostics;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartPowerOutageSystem.Services
{
    public class SmsService
    {
        public async Task<bool> SendSignupSmsAsync(string userPhoneNumber, string username)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(userPhoneNumber)) return false;

                // Format phone: if Ghanaian (054...), convert to +23354...
                if (userPhoneNumber.StartsWith("0") && userPhoneNumber.Length >= 10)
                {
                    userPhoneNumber = "+233" + userPhoneNumber.Substring(1);
                }

                string messageText = $"Welcome to the Power Outage Prediction System, {username}!";

                using var client = new HttpClient();
                var values = new Dictionary<string, string>
                {
                    { "phone", userPhoneNumber },
                    { "message", messageText },
                    { "key", "textbelt" } // Public free tier key
                };

                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync("https://textbelt.com/text", content);
                var responseString = await response.Content.ReadAsStringAsync();
                
                // responseString typically contains: { "success": true, "quotaRemaining": 0, "textId": "..." }
                // or { "success": false, "error": "Only one test text message is allowed per day." }
                Debug.WriteLine("Textbelt SMS Response: " + responseString);

                return responseString.Contains("\"success\":true") || responseString.Contains("\"success\": true");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Failed to send real SMS: {ex.Message}");
                return false;
            }
        }
    }
}
