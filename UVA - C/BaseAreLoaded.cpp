//	Garrett Gulker : TheBasesAreLoaded : 355 : ggulker
//  Data Structure: vector
//	changes given values from one base to a diffrent base
#include<iostream>
#include<vector>
#include<string>
using namespace std;

//changes the given string to base 10 then returns that string
string ToBaseTen(string num, int base, vector<int> key);
//changes a base 10 number to any other type of base
string FromBaseTen(string num, int base);

int main()
{
	int from, to;
	string number;

	vector<int> key(128);
	string location = "123456789ABCEDFGHIJKLMONPQRSTUVWXYZ";
	int value = 1;
	for (auto i : location)
	{
		key[i] = value;
		value++;
	}

	while (cin >> from)
	{
		cin >> to >> number;
		string startNumber = number;
		
		bool error = false;
		//checks for illegal values for that base
		for (auto y : number)
		{
			if (key[y] > from-1)
				error = true;
		}

		if (!error)
		{
			if (from == 10)
				number = FromBaseTen(number, to);
			else if (to == 10)
				number = ToBaseTen(number, from, key);
			else
				number = FromBaseTen(ToBaseTen(number, from, key), to);

			cout << startNumber << " base " << from << " = " << number << " base " << to << '\n';
		}
		else
			cout << startNumber << " is an illegal base " << from << " number" << '\n';
	}
	return 0;
}

string ToBaseTen(string num, int base, vector<int> key)
{
	long long S = key[num[0]];
	//uses horner's rule to convert to base ten
	for (int i = 1; i < num.size(); i++)
	{
		S = S*base + key[num[i]];
	}
	string out = to_string(S);
	return out;
}

string FromBaseTen(string num, int base)
{
	string extraKey = "0123456789ABCDEFGHIJKLMONPQRSTUVWXYZ";
	string output = "";
	long long number = stoll(num);
	if (number == 0)
	{
		return "0";
	}
	while (number > 0)
	{
		//modulo of the base gives us its correct value in new base
		output = extraKey[number%base] + output;
		number /= base;
	}
	return output;
}