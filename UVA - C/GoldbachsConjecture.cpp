// Garrett Gulker : GoldbachsConjecture : 543 : ggulker
// Data Structure: bitset
// create a program that finds the two prime odd numbers that sum
// up to the given number with the largest diffrence
#include<iostream>
#include<bitset>
#include<math.h>
using namespace std;

//creates our bitset of prime numbers 
void sieve(bitset<1000000> &key);

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(NULL);

	//create a bitset of prime numbers
	bitset<1000000> primeKey;
	sieve(primeKey);

	int number;
	cin >> number;
	while (number)
	{
		bool possible = false;
		//starts from 3 as to avoid 2 sense we only want odds
		for (int i = 3; i < number; i++)
		{
			//checks if number is prime
			if (primeKey[i])
			{
				//if prime creates another number to sum to the given number
				int otherNum = number - i;
				// checks if other created number is also prime
				if (primeKey[otherNum])
				{
					//if both prime prints out statement
					cout << number << " = " << i << " + " << otherNum << '\n';
					possible = true;
					//breaking out of the loop
					i = number;
				}
			}
		}

		if (!possible)
			cout << "Goldbach's conjecture is wrong." << '\n';

		cin >> number;
	}
    return 0;
}

void sieve(bitset<1000000> &key) {
	key.set();
	key[0] = key[1] = 0;
	int limit = sqrt(key.size());
	for (int i = 2; i < limit; i++) {
		if (key[i]) {
			for (int j = i*i; j < key.size(); j += i)
				key[j] = 0;
		}
	}
}