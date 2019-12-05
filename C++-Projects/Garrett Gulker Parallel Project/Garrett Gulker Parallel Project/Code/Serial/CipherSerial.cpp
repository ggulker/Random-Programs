/*
Garrett Gulker
================================
Due: 12/3/19
================================
Parallel Programming
================================
Encrypt and Decrypt data from a given file of a 4 ASCII character key and 
a message of any size using a custom made block cipher
================================
INSTRUCTIONS CAN BE FOUND IN FOLDER THIS FILE WAS FOUND
================================*/

#include <iostream>
#include <string>
#include <fstream>
#include <bitset>
#include <time.h>
using namespace std;

//precompiled headers for all needed functions
string BlockCipher(const string &in, const string &key);
string DecryptCipher(const string &in, const string &key);
void Shift(string &in, int start);
void ChangeBits(string &in, int start);
void XOr(string &in, const string &key, int start);
void BackBits(string &in, int start);
void ReShift(string &in, int start);

int main()
{
	//holders for key and all iterations of data
	string original;
	string encrypt;
	string decrypt;
	string key;

	//used to keep time
	clock_t e, d;

	//prepare files for i/o
	ifstream in;
	ofstream out;
	in.open("input.txt");
	out.open("output.txt");

	//get key from top of file
	in >> key;
	
	//input all chars from file
	string temp;
	while (getline(in, temp))
		original += temp;

	e = clock();//begin encrypt timer
	encrypt = BlockCipher(original, key);//encrypt our file
	e = clock() - e;//end encrypt timer

	d = clock();//begin decrypt timer
	decrypt = DecryptCipher(encrypt, key);//decrypt our file
	d = clock() - d;//end decrypt timer

	//calculate time
	float encryptTime = ((float)e) / CLOCKS_PER_SEC;
	float decryptTime = ((float)d) / CLOCKS_PER_SEC;
	
	//print time out on console and strings to file
	cout << "Time to encrypt: " << encryptTime << " seconds\n" << "Time to decrypt: " << decryptTime << " seconds\n";
	out<< "INPUT FROM FILE: \n" << original << "\n==============================\n" << "INPUT ENCRYPTED: \n" << encrypt
		<< "\n==============================\n" << "INPUT DECRYPTED: \n" << decrypt;
    return 0;
}

//takes given string and key then returns fully encrypted string
string BlockCipher(const string & in, const string & key)
{
	//copy data
	string ret = in;

	//if not divisible by 16 pad till true
	while (ret.size() % 16 != 0)
		ret.push_back(0);

	//does 3 rounds of each process
	for (int y = 0; y < 3; ++y)
	{
		//do each 16 block one by one
		for (int i = 0; i < ret.size(); i += 16)
		{
			//shift placement of each character
			Shift(ret, i);
			//exclusive or with key
			XOr(ret, key, i);
			//swap bits of each character
			ChangeBits(ret, i);
		}
	}
	
	//return encrypted string
	return ret;
}

//takes encrypted string and key returns original text
string DecryptCipher(const string & in, const string & key)
{
	//copy data
	string ret = in;

	//does 3 rounds of each process
	for (int y = 0; y < 3; ++y)
	{
		//do each 16 block one by one		
		for (int i = 0; i < ret.size(); i += 16)
		{
			//swap bits bacx
			BackBits(ret, i);
			//XOR with key again
			XOr(ret, key, i);
			//shifts characters back
			ReShift(ret, i);
		}
	}

	//pop off any padding added
	for (int i = in.size(); i < ret.size(); ++i)
	{
		ret.pop_back();
	}
	
	//return decrypted string
	return ret;
}

//shifts character placement of given string in 16 character block
void Shift(string& in, int start)
{
	//holds shifting characters
	string temp(16, ' ');

	//fill string with correct order
	temp[0] = in[start + 0];
	temp[1] = in[start + 5];
	temp[2] = in[start + 10];
	temp[3] = in[start + 15];

	temp[4] = in[start + 4];
	temp[5] = in[start + 9];
	temp[6] = in[start + 14];
	temp[7] = in[start + 3];

	temp[8] = in[start + 8];
	temp[9] = in[start + 13];
	temp[10] = in[start + 2];
	temp[11] = in[start + 7];

	temp[12] = in[start + 12];
	temp[13] = in[start + 1];
	temp[14] = in[start + 6];
	temp[15] = in[start + 11];

	//copy new string to given string
	for (int i = 0; i < 16; i++)
	{
		in[i + start] = temp[i];
	}
}

//swaps the bits of each character in a given 16 char block
void ChangeBits(string & in, int start)
{
	//holds bits of ascii character
	bitset<7> letBits;
	//holds char being changed
	char letter;
	unsigned long y;

	for (int i = 0; i < 16; ++i)
	{
		//grabs letter
		letter = in[start + i];
		//gets the bits of letter
		letBits[0] = (letter & (1 << 0)) >> 0;
		letBits[1] = (letter & (1 << 1)) >> 1;
		letBits[2] = (letter & (1 << 2)) >> 2;
		letBits[3] = (letter & (1 << 3)) >> 3;
		letBits[4] = (letter & (1 << 4)) >> 4;
		letBits[5] = (letter & (1 << 5)) >> 5;
		letBits[6] = (letter & (1 << 6)) >> 6;
		
		//swaps bit 1 and 4
		bool temp = letBits[1];
		letBits[1] = letBits[4];
		letBits[4] = temp;
		
		//swaps bit 2 and 3
		temp = letBits[2];
		letBits[2] = letBits[3];
		letBits[3] = temp;

		//change bitset to long
		y = letBits.to_ulong();
		//change long into char
		char c = y;
		
		//replace char in string
		in[start + i] = c;
	}
}

//XOR given key with 16 char block
void XOr(string& in, const string & key, int start)
{
	//key is 4 char long we do in sets of 4 
	in[start] = in[start] ^ key[0];
	in[start + 1] = in[start + 1] ^ key[1];
	in[start + 2] = in[start + 2] ^ key[2];
	in[start + 3] = in[start + 3] ^ key[3];

	in[start + 4] = in[start + 4] ^ key[0];
	in[start + 5] = in[start + 5] ^ key[1];
	in[start + 6] = in[start + 6] ^ key[2];
	in[start + 7] = in[start + 7] ^ key[3];

	in[start + 8] = in[start + 8] ^ key[0];
	in[start + 9] = in[start + 9] ^ key[1];
	in[start + 10] = in[start + 10] ^ key[2];
	in[start + 11] = in[start + 11] ^ key[3];

	in[start + 12] = in[start + 12] ^ key[0];
	in[start + 13] = in[start + 13] ^ key[1];
	in[start + 14] = in[start + 14] ^ key[2];
	in[start + 15] = in[start + 15] ^ key[3];
}

//undoes Shift function by putting chars back
void ReShift(string& in, int start)
{
	string temp(16, ' ');

	temp[0] = in[start + 0];
	temp[1] = in[start + 13];
	temp[2] = in[start + 10];
	temp[3] = in[start + 7];

	temp[4] = in[start + 4];
	temp[5] = in[start + 1];
	temp[6] = in[start + 14];
	temp[7] = in[start + 11];

	temp[8] = in[start + 8];
	temp[9] = in[start + 5];
	temp[10] = in[start + 2];
	temp[11] = in[start + 15];

	temp[12] = in[start + 12];
	temp[13] = in[start + 9];
	temp[14] = in[start + 6];
	temp[15] = in[start + 3];

	for (int i = 0; i < 16; i++)
	{
		in[i + start] = temp[i];
	}
}

//undoes ChangeBits function by swapping bits back
void BackBits(string & in, int start)
{
	bitset<7> letBits;
	char letter;
	unsigned long y;

	for (int i = 0; i < 16; ++i)
	{
		letter = in[start + i];
		letBits[0] = (letter & (1 << 0)) >> 0;
		letBits[1] = (letter & (1 << 1)) >> 1;
		letBits[2] = (letter & (1 << 2)) >> 2;
		letBits[3] = (letter & (1 << 3)) >> 3;
		letBits[4] = (letter & (1 << 4)) >> 4;
		letBits[5] = (letter & (1 << 5)) >> 5;
		letBits[6] = (letter & (1 << 6)) >> 6;

		bool temp = letBits[1];
		letBits[1] = letBits[4];
		letBits[4] = temp;

		temp = letBits[2];
		letBits[2] = letBits[3];
		letBits[3] = temp;

		y = letBits.to_ulong();
		char c = y;

		in[start + i] = c;
	}
}
