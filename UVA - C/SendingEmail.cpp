// Garrett Gulker : SendingEmail : 10986 : ggulker
// Data Structures: vector, priority queue, pair, adjacency list
#include<vector>
#include<queue>
#include<iostream>
#include<utility>
#include<functional>
#include<climits>
using namespace std;


class AdjacencyGraph
{
private:
	vector<vector<pair<int,int>>> graph;
public:
	//when constructed creates a graph with specified verticies
	AdjacencyGraph(int vert)
	{
		vector<vector<pair<int,int>>> x(vert + 1);
		graph = x;
	}

	//creates an edge between two vertices
	void AddEdge(int from, int to, int weight)
	{
		pair<int, int> x(to, weight);
		pair<int, int> y(from, weight);
		graph[from].push_back(x);
		graph[to].push_back(y);
	}

	int ShortestPath(int from, int to)
	{
		//create a priority queue to keep greatest in front
		priority_queue < pair<int, int>, vector<pair<int, int>>, greater<pair<int, int>>> q;
		//holds shortest distance for each vertex
		vector<int> dist(graph.size(), INT_MAX);
		//starting vertex is 0 distance away
		dist[from] = 0;
		q.push({ 0,from });
		while (!q.empty())
		{
			pair<int,int> front = q.top();
			q.pop();
			int d = front.first;
			int u = front.second;
			//for every connected vertex checks to see if distance is shortest
			for (int i = 0; i < graph[u].size(); i++)
			{
				pair<int, int> v = graph[u][i];
				if (dist[u] + v.second < dist[v.first])
				{
						dist[v.first] = dist[u] + v.second;
						q.push({ dist[v.first],v.first });
				}
			}
		}
		//returns distance from start to given ending vertex
		return dist[to];
	}

	~AdjacencyGraph()
	{
	}

};


int main()
{
	int cases;
	cin >> cases;
	//grab and loop through a given amount of cases
	for(int i = 0; i < cases; i++)
	{
		int servers, cables, s, t, from, to , weight;
		//takes in how many servers, cables, and where the start and stop are
		cin >> servers >> cables >> s >> t;
		//creates a graph with given vertexs
		AdjacencyGraph graph(servers);
		//for each cable adds to graph and given weight
		for (int y = 0; y < cables; y++)
		{
			cin >> from >> to >> weight;
			graph.AddEdge(from, to, weight);
		}
		//creates a shortest path list and returns distance
		int answer = graph.ShortestPath(s, t);

		//max int indicates unreachable
		if (answer == INT_MAX)
			cout << "Case #" << i+1 << ": unreachable" << '\n';
		else
			cout << "Case #" << i + 1 << ": " << answer << '\n';
	}
    return 0;
}

