// Garrett Gulker : FactorsandFactorials : 160 : ggulker
// data structure: bitset, map, vector

#include<iostream>
#include<iomanip>
#include<vector>
#include<bitset>
#include<map>
#include<math.h>
using namespace std;
int const SIZE = 100;

//function called to create a vector of prime numbers up to SIZE
void sieve(vector<int> &key);

int main()
{ 
	//creates a list primes
	vector<int> primes;
	sieve(primes);

	int number;
	cin >> number;
	while (number)
	{
		cout << setw(3) << right << number << "! =";

		map<int, int> factors;
		//used to make sure we do every number in the factorial
		while (number != 1) {
			int factor = primes[0], index = 0;
			int temp = number;
			//if the factor is the sqrt of our number its done
			while (factor * factor <= temp)
			{
				//if the factor is still a multiple
				while (temp % factor == 0)
				{
					//reduces the number 
					temp /= factor;
					//increment that factor in our map
					factors[factor]++;
				}
				//change what factor were using
				factor = primes[index++];
			}
			//if the number is not 1 its a prime
			if (temp != 1)
				factors[temp]++;
			number--;
		}


		int counter = 1;
		cout << setw(3);
		//goes through our map and prints out specified by the problem
		for (map<int, int>::iterator it = factors.begin(); it != factors.end(); it++)
		{
			cout << right << it->second;
			if (it != prev(factors.end()))
			{
				if (counter % 15 == 0 && it != prev(factors.end()))
				{
					cout << '\n' << setw(9);
				}
				else
					cout << setw(3);
			}
			counter++;
		}
		cout << '\n';

		cin >> number;
	}
    return 0;
}

void sieve(vector<int> &primes) {
	bitset<SIZE> key;
	key.set();
	key[0] = key[1] = 0;
	int limit = sqrt(key.size());
	for (int i = 2; i < limit; i++) {
		if (key[i]) {
			for (int j = i*i; j < key.size(); j += i)
				key[j] = 0;
		}
	}
	for (int j = 0; j < SIZE; j++)
	{
		if (key[j])
			primes.push_back(j);
	}
}

