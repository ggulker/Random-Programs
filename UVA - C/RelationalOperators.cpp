// Garrett Gulker : Relational Operators : 11172 : ggulker
// data structure required: none

#include<iostream>
using namespace std;

int main()
{
	//reads in times ran
	int runTimes;
	cin >> runTimes;

	for(int i = 0; i < runTimes; i++)
	{
		//reads in both values
		int a, b;
		cin >> a >> b;
		//checks if first is greater if false then checks if less then if both fail its equal
		if (a > b)
			cout << ">" << endl;
		else if (a < b)
			cout << "<" << endl;
		else
			cout << "=" << endl;
	}

    return 0;
}

