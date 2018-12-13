// Garrett Gulker : ContinuedFractions : 835 : ggulker
//
#include<iostream>
using namespace std;
void fractionMaker(int numer, int denom);
int main()
{
	int numer, denom;
	while (cin >> numer >> denom)
	{
		//first number is the rounded number of the 2 given values divded
		cout << "[" << numer / denom << ";";
		//reduces numerator down to its remainder
		numer %= denom;
		fractionMaker(numer, denom);
	}
    return 0;
}

void fractionMaker(int numer, int denom)
{
	//recursively called until hitting a number that cannot be divded
	if (numer != 1)
	{
		cout << denom / numer << ",";
		denom %= numer;
		fractionMaker(denom, numer);
	}
	else
		cout << denom << "]" << '\n';
}
