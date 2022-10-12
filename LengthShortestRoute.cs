namespace CustomerRoutApp;

internal class LengthShortestRoute
{
    public void GetLengthShortestRoute(Dictionary<string, int> routes, string start, string end, int len, int num)
    {
        Util util = new();
        var rts = new Dictionary<string, int>();
        foreach (var route in routes)
        {
            rts.Add(route.Key, route.Value);
        }

        int count = 9999;

        for (int i = 0; i < 3; i++)
        {
            var length = util.GetShortestRoute(rts, start, end, len);
            if (length < count)
                count = length;
        }

        if (count == 9999)
            count = 0;
        Console.WriteLine($"Output #{num}: {count}");
    }
}
