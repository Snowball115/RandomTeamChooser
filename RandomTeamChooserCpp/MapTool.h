#pragma once

#include <vector>
#include <string>
#include <iostream>

class MapTool
{
private:
    std::vector<std::string> valorantMaps = { "Split", "Bind", "Haven", "Ascent", "Icebox" };

public:
    void ChooseMap();
};

