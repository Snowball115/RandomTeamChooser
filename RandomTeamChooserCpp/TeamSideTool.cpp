#include "TeamSideTool.h"

void TeamSideTool::ChooseMap()
{
    std::cout << "==== TEAM SIDE CHOOSER TOOL ====\n\n";

    srand((unsigned int)time(NULL));

    int index = rand() % teamSides.size();
    std::string result = teamSides[index];

    std::cout << "Your Team: " << result << "\n\n";
    std::cout << "Press enter to exit...";
    fgetc(stdin);
    std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
}