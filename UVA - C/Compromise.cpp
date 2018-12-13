// Garrett Gulker : Compromise : 531 : ggulker
// Data Structure: 2d vector
#include <iostream>
#include <string>
#include <vector>
using namespace std;

string LCS(vector<string> x, vector<string>y);
void createString(vector<string> words,vector<vector<char>> directionGrid, int x, int y, string &ans);
int main()
{
	string word;
	while (cin >> word)
	{
		//reads in both texts into 2 diffrent vectors
		vector<string> text1;
		text1.reserve(100);
		vector<string> text2;
		text2.reserve(100);
		while (word != "#")
		{
			text1.push_back(word);
			cin >> word;
		}
		cin >> word;
		while (word != "#")
		{
			text2.push_back(word);
			cin >> word;
		}

		string answer = LCS(text1, text2);
		cout << answer << '\n';
	}
    return 0;
}

string LCS(vector<string> x, vector<string> y)
{
	int sizeX = x.size(), sizeY = y.size();
	//given one extra column and row for an empty row and column of 0s
	vector<vector<int>> grid(sizeX+1, vector<int>(sizeY+1));
	vector<vector<char>> direction(sizeX+1, vector<char>(sizeY+1));
	//start at 1,1 to account for 0 row and column
	for(int i = 1; i <= sizeX; i++)
		for (int j = 1; j <= sizeY; j++)
		{
			//if both equal increments based on spot diagnal and places an E in our char vector
			if (x[i-1] == y[j-1])
			{
				grid[i][j] = grid[i - 1][j - 1] + 1;
				direction[i][j] = 'E';
			}
			//if left value is greater makes it that value and places a L
			else if (grid[i - 1][j] >= grid[i][j - 1])
			{
				grid[i][j] = grid[i - 1][j];
				direction[i][j] = 'L';
			}
			//if up value is greater makes it that value and places a U
			else
			{
				grid[i][j] = grid[i][j - 1];
				direction[i][j] = 'U';
			}
		}

	string ans;
	createString(x, direction, sizeX, sizeY, ans);
	ans.replace(ans.size(), 1, "");
	return ans;
}

void createString(vector<string> words, vector<vector<char>> directionGrid, int x, int y, string &ans)
{
	if (x == 0 || y == 0)
		return;
	//if an equal value spot goes diagnal and adds the word in that spot to the string
	if (directionGrid[x][y] == 'E')
	{
		createString(words, directionGrid, x - 1, y - 1, ans);
		ans += words[x-1];
		ans += " ";
	}
	//goes left if L in char vector
	else if (directionGrid[x][y] == 'L')
	{
		createString(words, directionGrid, x - 1, y, ans);
	}
	//goes up if U in char vector
	else
	{
		createString(words, directionGrid, x, y - 1, ans);
	}
}

