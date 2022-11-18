# SlackToTeams

This is a skunkworks utility that will take a folder containing JSON files from a slack export and publish to a Teams sub-channel

##Steps
1. Generate an export from Slack (you have to be an admin)
2. Download the export from Slack. This will download a zip file
3. Open the export zip file from Slack and extract the exports you want to publish to Teams to a folder
4. In Teams, create an incoming webhook into the subchannel you want to publish your messages to and copy the webhook url
5. Open up a command prompt and navigate to the location of the exe
6. Run SlackToTeams.exe <path to folder> <webhook url>
