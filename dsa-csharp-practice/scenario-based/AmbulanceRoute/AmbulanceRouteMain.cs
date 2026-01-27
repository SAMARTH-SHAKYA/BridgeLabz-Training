using System;

class AmbulanceRouteMain
{
  static void Main()
  {
    // 1. Create route
    AmbulanceRoute route = new AmbulanceRoute();

    // 2. Add some hospital units
    route.AddUnit("ICU");
    route.AddUnit("Emergency");
    route.AddUnit("General");
    route.AddUnit("Pediatrics");
    route.AddUnit("Cardiology");

    // 3. Pass route to menu
    AmbulanceRouteMenu menu = new AmbulanceRouteMenu(route);

    // 4. Start menu
    menu.Start();
  }
}
