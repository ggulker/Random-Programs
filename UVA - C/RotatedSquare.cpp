// Garrett Gulker : Rotated Square : 10855 : ggulker
// Data structure: 2D vectors
// compares a small square to a large square of chars and outputs ho many times
// then rotate the square 90 degrees and do again repeat 4 times

#include<iostream>
#include<vector>
using namespace std;

//used to rotate the smaller square by 90degrees
void rotate(vector<vector<char>> &in, int size);
//checks to see how many times the small square matches 
//the large and returns how many times
int matching(vector<vector<char>> &small, vector<vector<char>> &large);

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(NULL);

	int largeSize;
	int smallSize;
	cin >> largeSize >> smallSize;
	//checks for our terminating sizes
	while (largeSize != 0 && smallSize != 0)
	{
		vector<vector<char>> grid(largeSize, vector<char>(largeSize));
		vector<vector<char>> smlGrid(smallSize, vector<char>(smallSize));

		//fills both grids
		for (int r = 0; r < largeSize; r++)
			for (int c = 0; c < largeSize; c++)
				cin >> grid[r][c];

		for (int r = 0; r < smallSize; r++)
			for (int c = 0; c < smallSize; c++)
				cin >> smlGrid[r][c];

		//goes through 4 rotates
		for (int i = 0; i < 3; i++)
		{
			cout << matching(smlGrid, grid) << " ";
			rotate(smlGrid, smallSize);
		}
		//ends the loop 1 early for formatting and stop an extra rotate
		cout << matching(smlGrid, grid) << "\n";
		cin >> largeSize >> smallSize;
	}
    return 0;
}

void rotate(vector<vector<char>> &in, int size)
{
	//if square is just 1 dont need rotate
	if (size == 1)
		return;
	for (int ring = 0; ring < size / 2; ring++)
	{
		for (int st = ring; st < size - ring - 1; st++)
		{
			//holds the first position in a temp
			char temp = in[ring][st];
			
			//bottom left to top left
			in[ring][st] = in[size - 1 - st][ring];
			
			//bottom right to bottom left
			in[size - 1 - st][ring] = in[size - 1 - ring][size - 1 - st];
			
			//top right to bottom right
			in[size - 1 - ring][size - 1 - st] = in[st][size - 1 - ring];
			
			//top left to top right
			in[st][size - 1 - ring] = temp;
		}
	}
}

int matching(vector<vector<char>>& small, vector<vector<char>>& large)
{
	int matching = 0;
	//these 2 loops shift what part of the larger grid were looking at
	for (int r = 0; r < large.size() - (small.size() - 1); r++)
	{
		for (int c = 0; c < large.size() - (small.size() - 1); c++)
		{
			bool matched = 1;
			//these 2 go through the smaller grid and compare
			for (int x = 0; x < small.size(); x++)
			{
				for(int y = 0; y < small.size(); y++)
				{
					//checking to see if matching
					if (small[x][y] != large[r + x][c + y])
					{
						matched = 0;
						//forces out of the loops as they dont match
						y = small.size();
						x = small.size();
					}
				}
			}

			//increments if all matching
			if (matched)
				matching++;
		}
	}
	return matching;
}
