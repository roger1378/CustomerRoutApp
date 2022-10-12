namespace CustomerRoutApp;

internal class Destination
{
    public void GetDistances(Dictionary<string, int> routes)
    {
        string[] arrList = new string[] { "ABC", "AD", "ADC", "AEBCD", "AED" };

        int count = 1;
        foreach (var item in arrList)
        {
            string response = "0";

            for (int i = 0; i < item.Length - 1; i++)
            {
                var key = item.Substring(i, 2);
                if (key.Length == 2)
                {
                    if (routes.ContainsKey(key))
                    {
                        response = (int.Parse(response) + routes[key]).ToString();
                    }
                    else
                    {
                        response = "NO SUCH ROUTE";
                        break;
                    }
                }
            }
            Console.WriteLine($"Output #{count++}: {response}");
        }
    }
}
