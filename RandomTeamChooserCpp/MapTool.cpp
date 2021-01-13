#include "MapTool.h"

void MapTool::ChooseMap()
{
    std::cout << "==== MAP TOOL ====\n\n";

    srand((unsigned int)time(NULL));

    int index = rand() % valorantMaps.size();
    std::string result = valorantMaps[index];

    std::cout << "Your map is: " << result << "\n\n";
    std::cout << "Press enter to exit...";
    fgetc(stdin);
    std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
}