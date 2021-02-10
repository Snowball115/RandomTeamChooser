#include "MapTool.h"

void MapTool::ChooseMap()
{
    std::cout << "==== MAP TOOL ====\n\n";
    std::cout << "Choose game: 1. Valorant // 2. CoD MW2\n";
    std::cout << "Your choice: ";

    std::string userInput;
    std::cin >> userInput;

    std::vector<std::string> gameMaps = chooseGameMaps(userInput);

    srand((unsigned int)time(NULL));

    int index = rand() % gameMaps.size();
    std::string result = gameMaps[index];

    std::cout << "Your map is: " << result << "\n\n";
    std::cout << "Press enter to exit...";
    fgetc(stdin);
    std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
}

std::vector<std::string> MapTool::chooseGameMaps(std::string userInput)
{
    std::vector<std::string> tmpList;

    std::cin >> userInput;

    switch (stoi(userInput))
    {
    case 1:
        tmpList = valorantMaps;
        break;

    case 2:
        tmpList = mw2Maps;
        break;

    default:
        std::cout << "No valid input detected. Shutdown." << std::endl;
        break;
    }

    return tmpList;
}