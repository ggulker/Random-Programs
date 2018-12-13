// Garrett Gulker :  OrderingTasks : 10305 : ggulker
// Data Structure: vector
#include<iostream>
#include<vector>
using namespace std;

class AdjacencyGraph
{
private:
	vector<vector<int>> graph;
	vector<bool> visited;

	void Dfs(int u, vector<int> &order)
	{
		//marks this task as visited
		visited[u] = 1;
		//marks all its children and their children etc as visited and pushes them into vector
		for (int j = 0; j < graph[u].size(); j++)
		{
			int v = graph[u][j];
			if (!visited[v])
				Dfs(v,order);
		}
		order.push_back(u);
	}
public:
	//when constructed creates a graph with specified verticies
	AdjacencyGraph(int vert)
	{
		const int fuck = vert;
		vector<vector<int>> x(vert + 1);
		graph = x;
		vector<bool> y(vert + 1, false);
		visited = y;
	}

	//creates an edge between two vertices
	void AddEdge(int from, int to)
	{
		graph[from].push_back(to);
	}

	void ExecutionOrder(vector<int> &order)
	{
		for (int i = 1; i < graph.size(); i++)
		{
			if (!visited[i])
			{
				//if a non visited task visits it and its children
				Dfs(i,order);
			}
		}
	}

	~AdjacencyGraph()
	{
	}

};

int main()
{
	int tasks;
	cin >> tasks;
	while (tasks)
	{
		AdjacencyGraph execution(tasks);
		int relationships;
		cin >> relationships;
		//creates edges between tasks from inputs
		for (int i = 0; i < relationships; i++)
		{
			int x, y;
			cin >> x >> y;
			execution.AddEdge(x, y);
		}

		vector<int> path;
		path.reserve(tasks);
		//creates a vector of the possible path backwards
		execution.ExecutionOrder(path);

		//prints in reverse order
		for (int y = path.size() - 1; y >= 0; y--)
		{
			if (y != 0)
				cout << path[y] << " ";
			else
				cout << path[y] << '\n';
		}

		cin >> tasks;
	}
    return 0;
}

