// Garrett Gulker : Vertex : 280 : ggulker
// Data Structure used: queue,vector

#include <iostream>
#include <string>
#include <queue>
using namespace std;

class AdjacencyGraph
{
private:
	vector<vector<int>> graph;
public:
	//when constructed creates a graph with specified verticies
	AdjacencyGraph(int vert)
	{
		vector<vector<int>> x(vert + 1);
		graph = x;
	}
	
	//creates an edge between two vertices
	void AddEdge(int from, int to)
	{
		graph[from].push_back(to);
	}

	//returns a bool value if it can be reaches
	bool IsConnectedTo(int from, int to)
	{
		vector<int> visits(graph.size());
		queue<int> q;
		q.push(from);
		//does a BFS algorithm and if at any point finds it returns true
		while (!q.empty())
		{
			int u = q.front();
			q.pop();
			for (auto i : graph[u])
			{
				if (i == to)
					return true;
				else if (visits[i] == 0)
				{
					visits[i] = 1;
					q.push(i);
				}
			}
		}
		//if searches the whole tree and cant find it returns false
		return false;
	}

	~AdjacencyGraph()
	{
	}

};

int main()
{
	int vertices;
	cin >> vertices;
	while (vertices)
	{
		AdjacencyGraph graph(vertices);
		int to, from;
		cin >> from;
		//creates all specified edges
		while (from) {
			cin >> to;
			while (to)
			{
				graph.AddEdge(from, to);
				cin >> to;
			}
			cin >> from;
		}

		int cases;
		cin >> cases;
		//tries every verticy in the array to see which ones cant be reached
		for(int i = 0; i < cases; i++) 
		{
			string unreachable = "";
			int verticy, count = 0;
			cin >> verticy;
			for (int i = 1; i <= vertices; i++)
			{
				//checks to see if it can be reach and if not adds to string
				if (!graph.IsConnectedTo(verticy, i))
				{
					unreachable += to_string(i);
					unreachable	+= " ";
					count++;
				}
			}

			//if it found any unreachable verticies
			if (unreachable != "")
			{
				unreachable.erase(unreachable.end() - 1, unreachable.end());
				cout << count << " " << unreachable << '\n';
			}
			else
				cout << count << '\n';
		}
		cin >> vertices;
	}
    return 0;
}



