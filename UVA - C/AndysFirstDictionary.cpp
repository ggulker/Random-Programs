// Garrett Gulker : AndysFirstDictionary : 10815 : ggulker
// Data Structures Used: set
// creates a list of words in alphabetical order used in a given paragraph
// with only one instance of each word
#include<iostream>
#include<set>
#include<string>
using namespace std;

int main()
{
	set<string> dictionary;
	string word;
	while (cin >> word)
	{
		string corrected;
		//goes through entire word to check for abnormalities
		for (int y = 0; y < word.size(); y++)
		{
			//if upper case changes to lower case
			if (word[y] >= 'A' && word[y] <= 'Z')
				corrected.push_back(word[y] + 32);
			//if not a letter checks if two words are stuck together
			else if (word[y] < 'a' || word[y] > 'z')
			{
				if (corrected != "")
				{
					dictionary.insert(corrected);
					corrected = "";
				}
			}
			else
				//if lower case letter pushes back
				corrected.push_back(word[y]);

		}
		if(corrected != "")
			dictionary.insert(corrected);
	}
	//goes through entire set and prints
	for (auto i : dictionary)
		cout << i << '\n';
    return 0;
}

