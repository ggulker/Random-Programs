// Garrett Gulker : TheJackpot : 10684 : ggulker
// find the 1D range sum of a group of numbers

#include<iostream>
using namespace std;

int main()
{
	int caseNums;
	cin >> caseNums;
	while (caseNums)
	{
		int input, sum = 0, ans = 0;
		for (int i = 0; i < caseNums; i++)
		{
			cin >> input;
			sum += input;
			//if our sum is greater it becomes the new answer
			if (sum > ans)
				ans = sum;
			//if the sum is negative all numbers previous are not needed
			if (sum < 0)
				sum = 0;
		}
		
		//if the answer is 0 all numbers are negative
		if (ans == 0)
			cout << "Losing streak." << '\n';
		else
			cout << "The maximum winning streak is " << ans << "." << '\n';

		cin >> caseNums;
	}
    return 0;
}

