namespace CustomerRoutApp;

internal class Trip
{
    public void GetTrips(Dictionary<string, int> routes, int len, string start, string end, int num)
    {
        Util util = new();
        var mainRoutes = routes
              .Where(x => x.Key.StartsWith(start))
              .Select(x => x.Key)
              .ToList();

        int count = 0;
        foreach (var route in mainRoutes)
        {
            int trips = 0;
            string endValueKey = route.Substring(1, 1);
            for (int i = 0; i < len; i++)
            {
                var nextRoute = util.GetNextRoute(routes, endValueKey);

                if (nextRoute != string.Empty)
                {
                    trips++;
                    endValueKey = nextRoute.Substring(1, 1);
                    if (endValueKey == end)
                    {
                        count++;
                        break;
                    }
                }
            }
        }
        Console.WriteLine($"Output #{num}: {count}");
    }
}
