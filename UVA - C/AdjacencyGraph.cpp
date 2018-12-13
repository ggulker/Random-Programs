#include "AdjacencyGraph.h"
AdjacencyGraph::AdjacencyGraph(int vert)
{
	vector<vector<int>> x(vert + 1);
	graph = x;
}

void AdjacencyGraph::AddEdge(int from, int to)
{
	graph[from].push_back(to);
}

bool AdjacencyGraph::IsConnectedTo(int from, int to)
{
	vector<int> visits(graph.size());
	queue<int> q;
	q.push(from);
	while (!q.empty())
	{
		int u = q. front();
		q.pop();
		for (auto i : graph[u])
		{
			if (i == to)
				return true;
			else if(visits[i] == 0)
			{
				visits[i] = 1;
				q.push(i);
			}
		}
	}
	return false;
}

AdjacencyGraph::~AdjacencyGraph()
{
}
