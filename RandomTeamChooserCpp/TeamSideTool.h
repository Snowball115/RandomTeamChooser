#pragma once

#include <vector>
#include <string>
#include <iostream>

class TeamSideTool
{
private:
    std::vector<std::string> teamSides = { "CT", "T" };

public:
    void ChooseMap();
};