// Garrett Gulker : Group Reverse : 11192 : ggulker
// reverse a strings characters by subsectioned groups dictated by the user

#include<iostream>
#include<string>
using namespace std;

//method used to reverse the characters
void reverse(int r, int l, string &line);

int main()
{
	int groupSize;
	int groupNum;
	//how manys groups are there in the string
	cin >> groupNum;
	//checks for the termination numbers
	while (groupNum != 0)
	{
		//makes sure we dont get blank space for getline
		cin.ignore();
		string line;
		getline(cin, line);

		//determines how large our groups will be
		groupSize = line.size() / groupNum;
		//makes two pointers at the end and the beggining of our first subsection
		int right = groupSize - 1;
		int left = 0;

		//makes sure we dont go out of bounds
		while (right <= line.size() - 1)
		{
			reverse(right, left, line);
			//increment both pointers to the next subsection
			right += groupSize;
			left += groupSize;
		}

		cout << line << endl;
		cin >> groupNum;
	}
    return 0;
}

void reverse(int r, int l, string & line)
{
	//makes sure our pointers to cross
	while (r != l && l < r)
	{
		//replacment method with a temporary
		char temp = line[r];
		line[r] = line[l];
		line[l] = temp;
		r--;
		l++;
	}
	return;
}
