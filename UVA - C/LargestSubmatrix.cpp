// Garrett Gulker: LargestSubmatrix : 836 : ggulker
// Data Structure: vector
#include<iostream>
#include<vector>
#include<string>
using namespace std;
int main()
{
	int cases;
	cin >> cases;
	for (int i = 0; i < cases; i++)
	{
		string line;
		cin >> line;
		int size = line.size();
		vector<vector<int>> input(size, vector<int>(size));
		//readin everyline and correctly apply to 2d vector
		for(int y = 1; y < size; y++)
		{
			for (int j = 0; j < size; j++)
			{
				int number = (int)line[j] - 48;
				if (number)
					input[y-1][j] = number;
				else
					//instead of 0 make a number that doesnt take it into account
					input[y-1][j] = -100;
			}
			cin >> line;
		}
		//last line of input
		for (int j = 0; j < size; j++)
		{
			int number = (int)line[j] - 48;
			if (number)
				input[size - 1][j] = number;
			else
				input[size - 1][j] = -100;
		}

		int maxSub = 0;
		//top left of the submatrix
		for(int startR = 0; startR < size; startR++)
			for(int startC = 0; startC < size; startC++)
				//bottom right of the sub matrix
				for(int endR = startR; endR < size; endR++)
					for (int endC = startC; endC < size; endC++)
					{
						int sub = 0;
						//adds every value in the sub matrix
						for (int a = startR; a <= endR; a++)
							for (int b = startC; b <= endC; b++)
								sub += input[a][b];
						//if greater then our current max replaces
						if (sub > maxSub)
							maxSub = sub;
					}

		if (i < cases - 1)
			cout << maxSub << '\n' << '\n';
		else
			cout << maxSub << '\n';
	}
    return 0;
}

