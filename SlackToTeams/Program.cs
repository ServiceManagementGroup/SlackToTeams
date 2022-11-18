// See https://aka.ms/new-console-template for more information
/* Mandar Bhanushali
 * Command line arguments - 
 * folder to Slack exported JSON files
 * webhook url to Teams channel
 */

using SlackToTeams;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Nodes;
using static System.Net.WebRequestMethods;

string folder = Environment.GetCommandLineArgs()[1];
string webhookUrl = Environment.GetCommandLineArgs()[2];

string[] files = Directory.GetFiles(folder);
foreach(var file in files)
{
    ProcessFile(file);
}

DateTime FromMS(string microSec)
{
    DateTime unixStart = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
    double unixTimestampInSeconds = Double.Parse(microSec);
    DateTime localDatetime = unixStart.AddSeconds(unixTimestampInSeconds).ToLocalTime();
    return localDatetime;
}

void ProcessFile(string file)
{

    FileStream fileStream = new FileStream("C:\\temp\\2022-11-10.json", FileMode.Open);

    List<Root> messages = JsonSerializer.Deserialize<List<Root>>(fileStream);

    using (var httpClient = new HttpClient())
    {

        messages.ForEach(m =>
        {
            string formattedMessage = "At : " + FromMS(m.ts) + ", " + m.user_profile?.real_name + " said: " + m.text.Replace("'", "''");
            string text = "{'text' : '" + formattedMessage + "'}";
            Console.WriteLine(text);
            using (var request = new HttpRequestMessage(new HttpMethod("POST"), webhookUrl))
            {
                request.Content = new StringContent(text);
                request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                HttpResponseMessage response;
                try
                {
                    response = httpClient.Send(request);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Caught exception: " + e);
                }
                Console.WriteLine("Finished sending message");
            }
        });
    }
}
