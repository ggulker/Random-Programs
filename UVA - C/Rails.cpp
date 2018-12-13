// Garrett Gulker : Rails : 541 : ggulker
// Data Structures: Queues and stacks

#include<iostream>
#include<stack>
#include<queue>
#include<vector>
using namespace std;

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(NULL);

	//how many carts a train has
	int carts;
	cin >> carts;
	//waits for the termination 0
	while (carts != 0)
	{
		//checking the first integer given
		int needed;
		cin >> needed;
		//looking for the termination 0 aswell
		while (needed != 0)
		{
			//output holds what train is needed 
			queue<int> output;
			//holds whats in the station
			stack<int> station;
			output.push(needed);
			//fills output with needed carts
			for (int i = 1; i < carts; i++)
			{
				cin >> needed;
				output.push(needed);
			}

			//for every cart coming in either adds it to the station or pushes onto track B
			for (int y = 1; y <= carts; y++)
			{
				if (y == output.front())
					output.pop();
				else
					station.push(y);
				//constant checking station doesnt have needed cart
				while (!station.empty() && output.front() == station.top())
				{
					station.pop();
					output.pop();
				}
			}

			//if all output popped correct train left
			if (output.empty())
				cout << "Yes" << '\n';
			else
				cout << "No" << '\n';
			//resets to check if 0 infront
			cin >> needed;
		}
		cout << '\n';
		cin >> carts;
	}
    return 0;
}

