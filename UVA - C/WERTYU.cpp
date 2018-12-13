//Garrett Gulker: WERTYU : 10082 : ggulker
//Data structure required:  array used as a table
//Tricks of the trade : using the array as a decoder we feed in 
//our string and change its letters comparing to the table

#include <iostream>
#include <string>
#include <vector>
using namespace std;

int main()
{
		string input;
		char  ascii[128] = " ";
		//use these strings to fill the table with location being the ascii location
		string location = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890-=[]\\;',./";
		//and this being what we put in the table location
		string filler = " VXSWDFGUHJKNBIO EARYCQZT `1234567890-P[]L;M,.";

		//fills the entire table
		for (int y = 0; y < location.size(); y++)
		{
			ascii[location[y]] = filler[y];
		}

		//gets the line and one by one changes each letter
		while (getline(cin, input))
		{
			for (int i = 0; i < input.size(); i++)
			{
					input[i] = ascii[input[i]];
			}
			cout << input << endl;
		}
		return 0;
}


