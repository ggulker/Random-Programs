// Garrett Gulker: HorrorDash : 11799 : ggulker
// Data structure required : vector
// 

#include<iostream>
#include<vector>
using namespace std;

int main()
{
	//how many times we run our entire program
	int testRuns;
	cin >> testRuns;
	for (int i = 0; i < testRuns; i++)
	{
		//how many values in the vector
		int children;
		cin >> children;
		vector<int> speeds = { };
		int max;
		//fill vector with speeds
		for (int y = 0; y < children; y++)
		{
			int input;
			cin >> input;
			speeds.push_back(input);
		}

		max = speeds[0];
		//compare all vector values to find the largest
		for (int y = 1; y < children; y++)
		{
			//if larger value is found relpace it
			if (max < speeds[y])
				max = speeds[y];
		}
		//print out what case were on and the speed needed for that case
		cout << "Case " << i + 1 << ": " << max << endl;
	}
    return 0;
}

