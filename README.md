# SlackToTeams

This is a skunkworks utility that will take a folder containing JSON files from a slack export and publish to a Teams sub-channel.
Currently it only publishes messages from a public Slack channel, the name of the person, the timestamp and the message sent. 
It does not thread messages or show attachments or publish the names of the @users
There is no support other than your own

#Steps
1. Download code from https://github.com/ServiceManagementGroup/SlackToTeams and build it using .NET 6+
2. Download the export from Slack
3. Open the export zip file from Slack and extract the exports you want to publish to Teams to a folder
4. Create an incoming webhook into the subchannel you want to publish your messages to. https://learn.microsoft.com/en-us/microsoftteams/platform/webhooks-and-connectors/how-to/add-incoming-webhook
5. Copy the generated webhook url to clipboard
6. Open up a command prompt and navigate to the location of the exe
7. Run slackToTeams.exe "&lt;path to folder&gt;" "&lt;webhook url&gt;"
