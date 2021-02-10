#pragma once

#include <vector>
#include <string>
#include <iostream>

class MapTool
{
private:
    std::vector<std::string> valorantMaps = { "Split", "Bind", "Haven", "Ascent", "Icebox" };

    std::vector<std::string> mw2Maps = { "Afghan", "Derail", "Estate", "Favela", "Highrise", "Invasion", "Karachi", "Quarry", "Rundown", "Scrapyard", "Skidrow", "Sub Base", "Terminal", "Underpass", "Wasteland" };

    std::vector<std::string> chooseGameMaps(std::string userInput);

public:
    void ChooseMap();
};

