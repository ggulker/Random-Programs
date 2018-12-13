// Garrett Gulker : SternBrocotTree : 11350 : ggulker
// Data Structure : pairs
// make a program that tells you the number 
#include<iostream>
#include<string>
#include<sstream>
#include<utility>
using namespace std;

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(NULL);

	//use ignore as we need getline in the loop
	int cases;
	cin >> cases;
	cin.ignore();

	for (int i = 0; i < cases; i++)
	{
		string input;
		//need to use getline as no termination call
		getline(cin, input);
		//create the three values from the tree at the root
		pair<long long, long long> leftNum(0, 1);
		pair<long long, long long> centNum(1, 1);
		pair<long long, long long> rightNum(1, 0);
		for (int y = 0; y < input.size(); y++)
		{
			//if R then update our leftmost number and make our central number
			//a sum of left and central numbers
			if (input[y] == 'R')
			{
				leftNum = centNum;
				centNum = make_pair(centNum.first + rightNum.first, centNum.second + rightNum.second);
			}
			//if L do the opposite of R updating rightmost and 
			//has the sum of left and central number
			else
			{
				rightNum = centNum;
				centNum = make_pair(centNum.first + leftNum.first, centNum.second + leftNum.second);
			}
		}
		cout << centNum.first << "/" << centNum.second << '\n';
	}
    return 0;
}

