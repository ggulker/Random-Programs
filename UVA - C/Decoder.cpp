// Garrett Gulker: The Decoder : 458 : ggulker
// change every chara of a string to 7 places back on the ascii table to decode a message

#include<iostream>
#include<string>
using namespace std;
int main()
{
	string input;
	//checks if any lines are remaining then reads them in
	while (getline(cin, input))
	{
		//goes through line and changes each chara 
		for (int i = 0; i < input.size(); i++)
		{
			input[i] = input[i] - 7;
		}
		cout << input << endl;
	}
    return 0;
}

