// Garrett Gulker : TheresTreasuerEverywhere : 587 : ggulker
// Data Structure used: map and pairs
// using given directions find where the person walks to and the distance from start
#include<iostream>
#include<map>
#include<string>
#include<math.h>
#include<iomanip>
using namespace std;

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(NULL);

	string input;
	getline(cin, input);
	int caseNum = 1;
	while (input != "END")
	{
		string direction;
		map<string, pair<double, double>> change;

		for (int i = 0; i < input.length(); i += 2)
		{
			pair<double, double> x;

			double length = 0;
			//continues as long as the front is a number
			while (input[i] > 47 && input[i] < 58)
			{
				//moves the back number up one placement
				length *= 10;
				//back number replaced
				length += (double)input[i] - 48;
				i++;
			}

			direction = input[i];
			//if there is 2 chars for direction 
			if (input[i + 1] == 'W' || input[i + 1] == 'E')
			{
				direction += input[i + 1];
				i++;
				//creates a diagnal line pair
				pair<double, double> line(length*sqrt(2)/2, length*sqrt(2)/2);
				x = line;
			}
			//if the line is straight which direction is it going
			else if(direction == "N" || direction == "S")
			{
				pair<double, double> line(0, length);
				x = line;
			}
			else
			{
				pair<double, double> line(length, 0);
				x = line;
			}
			//places values into our map
			change[direction].first += x.first;
			change[direction].second += x.second;
		}

		pair<double, double> treasure;
		//adds all values up to create the location of the treasure
		treasure.first = change["E"].first + change["NE"].first + change["SE"].first - change["W"].first - change["NW"].first - change["SW"].first;
		treasure.second = change["N"].second + change["NE"].second + change["NW"].second - change["SW"].second - change["SE"].second - change["S"].second;

		//printing statements
		cout << setprecision(3) << fixed;
		cout << "Map #" << caseNum << '\n';
		cout << "The treasure is located at " << "(" << treasure.first << "," << treasure.second << ")." << '\n';
		cout << "The distance to the treasure is " << sqrt(pow(treasure.first,2) + pow(treasure.second,2)) << "." << '\n' << '\n';

		caseNum++;
		getline(cin, input);
	}
    return 0;
}

