using CustomerRoutApp;

Console.WriteLine("Hello, World!");

Console.WriteLine("Add routes information");
var request = Console.ReadLine();
var listRoutes = request.Split(',');

var routes = new Dictionary<string, int>();

foreach (var route in listRoutes)
{
    routes.Add(route.Trim().Substring(0, 2), int.Parse(route.Trim().Substring(2, 1)));
}

Destination Destination = new();
Destination.GetDistances(routes);

Trip Trip = new Trip();
Trip.GetTrips(routes, 3, "C", "C", 6);
Trip.GetTrips(routes, 4, "A", "C", 7);

LengthShortestRoute LengthShortestRoute = new();
LengthShortestRoute.GetLengthShortestRoute(routes, "A", "C", 100, 7);
LengthShortestRoute.GetLengthShortestRoute(routes, "B", "B", 5, 8);
LengthShortestRoute.GetLengthShortestRoute(routes, "C", "C", 30, 9);

DifferentRoutes DifferentRoutes = new();
DifferentRoutes.GetDifferentRoutes(routes, 10, "C", "C");