#include "TeamTool.h"

/*=================================
*      MAIN PROCESS
*=================================*/

void TeamTool::GenerateTeams()
{
    std::cout << "==== TEAM TOOL ====\n\n";

    CountTeams();

    CountPlayers();

    // Calculate player count equally for all teams
    playersPerTeamCount = (playersCount / teamsCount);

    std::cout << "\n";

    // If number is not a whole number, adjust the index count of list, because we can't add a "half" player to the team
    // HACK: Check if playersPerTeamCount is a whole number, if not, its a decimal. Basically adding a invisible player to make it work
    std::string stringToCheck = std::to_string(playersPerTeamCount);
    float result;
    result = atof(stringToCheck.c_str());

    if (result != static_cast<int>(result))
    {
        double newPlayerCount = playersPerTeamCount;
        newPlayerCount = ceil(playersPerTeamCount);
        playersPerTeamCount = newPlayerCount;

        activePlayers.push_back("");
    }

    // Save all active players
    for (int i = 0; i < playersCount; i++)
    {
        std::string inputString;

        std::cout << "Player " << i + 1 << ": ";
        std::cin >> inputString;
        activePlayers.push_back(inputString);
    }

    std::cout << "\n";

    // Randomize player order
    activePlayers = ShuffleList(activePlayers);

    for (int i = 0; i < teamsCount; i++)
    {
        std::cout << "==== TEAM " << i + 1 << " ====\n";

        // Create array for each team
        //int teamSizeInt = playersPerTeamCount;
        std::string team[100];

        // Get players from shuffled list and put them in the current team
        for (int j = 0; j < playersPerTeamCount; j++)
        {
            std::string player = GetPlayerFromList(activePlayers);

            team[j] = player;

            // Write the invisible player in the same line to hide the space between players
            if (team[j] == "") std::cout << team[j];
            else std::cout << team[j] << "\n";
        }
    }

    std::cout << "\nPress Enter to continue...";
    fgetc(stdin);
    std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
}


/*=================================
*      HELPER FUNCTIONS
*=================================*/

// Set team count
void TeamTool::CountTeams()
{
    std::string teamsCountString;

    std::cout << "How many teams are playing? ";
    std::cin >> teamsCountString;

    float result;
    result = atof(teamsCountString.c_str());

    if (result == 0)
    {
        // Error handling
        std::cout << "\nPlease type in a whole number...\n\n";
        CountTeams();
        return;
    }

    teamsCount = std::stof(teamsCountString);
}

// Set player count
void TeamTool::CountPlayers()
{
    std::string playersCountString;

    std::cout << "How many players are online? ";
    std::cin >> playersCountString;

    float result;
    result = atof(playersCountString.c_str());

    if (result == 0)
    {
        // Error handling
        std::cout << "\nPlease type in a whole number...\n\n";
        CountPlayers();
        return;
    }

    playersCount = std::stof(playersCountString);
}

// Randomize the order of all elements in a list
std::vector<std::string> TeamTool::ShuffleList(std::vector<std::string> list)
{
    std::random_device rd;
    std::default_random_engine rng(rd());
    std::shuffle(std::begin(list), std::end(list), rng);
    return list;
}

// Draw first player from the list and remove him
std::string TeamTool::GetPlayerFromList(std::vector<std::string> &playerList)
{
    std::string player = playerList[0];
    playerList.erase(playerList.begin());
    return player;
}