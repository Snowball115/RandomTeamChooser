#include <iostream>
#include <memory>

#include "TeamTool.h"
#include "MapTool.h"

//std::unique_ptr<MapTool> m_mapTool;
//std::unique_ptr<TeamTool> m_teamTool;

MapTool* m_mapTool = new MapTool();
TeamTool* m_teamTool = new TeamTool();

bool isRunning = true;

int main()
{
    while (isRunning)
    {
        std::cout << "==== Choose Tool ====\n\n";
        std::cout << "1. Map chooser\n2. Random team generator\n3. Exit program\n\n";
        std::cout << "Your number: ";
        std::string userInput;

        std::cin >> userInput;
        switch (stoi(userInput))
        {
        case 1:
            system("CLS");
            m_mapTool->ChooseMap();
            system("CLS");
            break;

        case 2:
            system("CLS");
            m_teamTool->GenerateTeams();
            system("CLS");
            break;

        case 3:
            isRunning = false;
            break;

        default:
            std::cout << "No valid input detected. Please choose again.\n\n";
            std::cout << "Your number: ";
            break;
        }
    }

    delete m_mapTool;
    delete m_teamTool;
}