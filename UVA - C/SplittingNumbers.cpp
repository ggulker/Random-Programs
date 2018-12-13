// Garrett Gulker : SplittingNumbers : 11933 : ggulker
// Data Structure: Bitset

#include<iostream>
#include<bitset>
#include<math.h>
using namespace std;

int main() {
	int value;
	cin >> value;
	while (value != 0)
	{
		bitset<31> a = 0;
		bitset<31> b = 0;
		int location = 0;
		int counter = 0;
		int aVal = 0;
		int bVal = 0;
		while (value > 0)
		{
			//finds the binary values
			int bit = value % 2;
			value /= 2;
			//if a 1 is found adds to bitset and increases counter
			if (bit == 1)
			{
				//checks counter to determine which bitset its going to
				if (counter % 2 == 0)
				{
					a[location] = bit;
					counter++;
				}
				else
				{
					b[location] = bit;
					counter++;
				}
			}
			location++;
		}
		//goes through entire bitset and finds the value in base 2
		for (int i = 0; i < 31; i++)
		{
			if (a[i])
				aVal += pow(2, i);
			if (b[i])
				bVal += pow(2, i);
		}
		//prints out both values
		cout << aVal << " " << bVal << '\n';
		cin >> value;
	}
}