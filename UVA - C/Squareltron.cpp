// Garrett Gulker: Squareltron : 10016 : ggulker
// Data Structure: 2D Vector
// Takes a given 2D vector and can do four diffrent flips
// up down, left right, main diagnal, or inverse diagnal

#include<iostream>
#include<vector>
using namespace std;

void upDwn(vector<vector<int>> & square, int ring);
void leftRght(vector<vector<int>> & square, int ring);
void mainFlip(vector<vector<int>> & square, int ring);
void invFlip(vector<vector<int>> & square, int ring);

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(NULL);

	int runs;
	cin >> runs;
	for (int i = 0; i < runs; i++)
	{
		int size;
		cin >> size;
		vector<vector<int>> square(size, vector<int>(size));
		//fills out square
		for (int r = 0; r < size; r++)
			for (int c = 0; c < size; c++)
				cin >> square[r][c];

		//loops how many rings there are
		for (int ring = 0; ring < size/2 + size%2; ring++)
		{
			int changes;
			cin >> changes;
			//how many changes one ring does
			for (int x = 0; x < changes; x++)
			{
				int change;
				cin >> change;
				//determines which function to call
				switch (change)
				{
				case 1:
					upDwn(square, ring);
					break;

				case 2:
					leftRght(square, ring);
					break;

				case 3:
					mainFlip(square, ring);
					break;

				case 4:
					invFlip(square, ring);
					break;
				}
			}
		}

		//printing out the square
		for (int r = 0; r < square.size(); r++)
		{
			for (int c = 0; c < square.size() - 1; c++)
			{
				cout << square[r][c] << " " ;
			}
			//ends one early for formatting
			cout << square[r][square.size() - 1] << "\n";
		}
	}

	return 0;
}

void upDwn(vector<vector<int>> & square, int ring)
{
	int size = square.size() - 1;
	//swaps top and bottom rows
	for (int i = ring; i < square.size() - ring; i++)
		swap(square[ring][i], square[size - ring][i]);

	for (int x = ring + 1; x < square.size() / 2; x++)
	{
		//swaps numbers between top and bottom rows
		swap(square[x][ring], square[size - x][ring]);
		swap(square[x][size - ring], square[size - x][size - ring]);
	}
}

void leftRght(vector<vector<int>> & square, int ring)
{
	int size = square.size() - 1;
	//swaps right and left columns
	for (int i = ring; i < square.size() - ring; i++)
		swap(square[i][ring], square[i][size - ring]);

	//swaps top and bottom numbers between columns
	for (int x = ring + 1; x < square.size() / 2; x++)
	{
		swap(square[ring][x], square[ring][size - x]);
		swap(square[size - ring][x], square[size - ring][size - x]);
	}
}

void mainFlip(vector<vector<int>> & square, int ring)
{
	int size = square.size() - 1;
	//swaps the top row and left column 
	for (int i = ring + 1; i < square.size() - ring; i++)
		swap(square[i][ring], square[ring][i]);

	//swaps bottom row and right column
	for (int i = ring + 1; i < square.size() - ring - 1; i++)
		swap(square[size - ring][i], square[i][size - ring]);
}

void invFlip(vector<vector<int>> &  square, int ring)
{
	int size = square.size() - 1;
	for (int i = ring; i < square.size() - ring - 1; i++)
	{
		//swapping left column with bottom row
		swap(square[i][ring], square[size - ring][size - i]);

		//swapping top row with right column
		swap(square[ring][i + 1], square[size - i - 1][size - ring]);
	}
}


