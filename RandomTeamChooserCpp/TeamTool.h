#pragma once

#include <vector>
#include <string>
#include <iostream>
#include <random>

class TeamTool
{
private:
	std::vector<std::string> activePlayers;

	float teamsCount = 0;
	float playersCount = 0;
	float playersPerTeamCount = 0;

	void CountTeams();
	void CountPlayers();
	std::vector<std::string> ShuffleList(std::vector<std::string> list);
	std::string GetPlayerFromList(std::vector<std::string>& playerList);

public:
	void GenerateTeams();
};

