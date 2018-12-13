//Garrett Gulker: ParenthesesBalance : 672 : ggulker
//Data Structure: stacks
//make sure that each left facing parenthesis or bracket has a correct right facing same character
#include<iostream>
#include<stack>
#include<string>
#include<sstream>
using namespace std;

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(NULL);

	int runs;
	stringstream ss;
	string line, run;
	getline(cin, run);
	ss << run;
	ss >> runs;
	for (int i = 0; i < runs; i++)
	{
		//need to use get line as there are empty lines
		getline(cin, line);
		stack<char> holder;
		bool decision = 1;

		for (int y = 0; y < line.size(); y++)
		{
				//pushes onto the stack if seeing a left facing parenthises or bracket
				switch (line[y])
				{
				case '(':
					holder.push('(');
					break;

				case '[':
					holder.push('[');
					break;

				//pops off if seeing a right facing parenthises or bracket
				case ')':
					//top method errors if holder is empty
					if (!(holder.empty()))
					{
						if (holder.top() == '(')
							holder.pop();
						else
						{
							//ends the loop early if not enough left facing
							decision = 0;
							y = line.size();
						}
					}
					else
					{
						decision = 0;
						y = line.size();
					}
					break;

				//same as ')' just with brackets
				case ']':
					if (!(holder.empty()))
					{
						if (holder.top() == '[')
							holder.pop();
						else
						{
							decision = 0;
							y = line.size();
						}
					}
					else
					{
						decision = 0;
						y = line.size();
					}
					break;
				}
		}

		//if holder is not empty then there wasnt enough right facing charas
		if (holder.empty())
			if (decision)
				cout << "Yes" << '\n';
			else
				cout << "No" << '\n';
		else
			cout << "No" << '\n';
	}
    return 0;
}

