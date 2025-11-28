public class Solution
{
    List<string> ret = ["JFK"];

    bool Dfs(ref Dictionary<string, List<string>> airports, string origin_airport, List<string> ret, int MaxPathLength)
    {
        if (ret.Count == MaxPathLength + 1) return true;
        if (!airports.ContainsKey(origin_airport)) return false;

        var DummyListofDestinations = new List<string>(airports[origin_airport]);

        for (int i = 0; i < DummyListofDestinations.Count; i++)
        {
            string destination = DummyListofDestinations[i];
            airports[origin_airport].RemoveAt(i);
            ret.Add(destination);
            if (Dfs(ref airports, destination, ret, MaxPathLength)) return true;
            airports[origin_airport].Insert(i, destination);
            ret.RemoveAt(ret.Count - 1);
        }
        return false;
    }

    public List<string> FindItinerary(List<List<string>> tickets)
    {
        var airports = new Dictionary<string, List<string>>();
        int MaxPathLength = 0;
        //adding list of destinations from an airport
        foreach (List<string> ListofTickets in tickets)
        {
            string origin = ListofTickets[0];
            string destination = ListofTickets[1];

            if (!airports.ContainsKey(origin))
            {
                airports[origin] = new List<string>();
            }
            airports[origin].Add(destination);
            MaxPathLength++;
        }

        //sorting the all the lists of destination
        foreach (var airport in airports)
        {
            airport.Value.Sort();
        }

        foreach (var KeyValuePair in airports)
        {
            Console.Write($"{KeyValuePair.Key}: ");
            {
                foreach (var destination in KeyValuePair.Value)
                {
                    Console.Write($"{destination}, ");
                }
            }
            Console.WriteLine();
        }

        Dfs(ref airports, "JFK", ret, tickets.Count);
        return ret;
    }
}