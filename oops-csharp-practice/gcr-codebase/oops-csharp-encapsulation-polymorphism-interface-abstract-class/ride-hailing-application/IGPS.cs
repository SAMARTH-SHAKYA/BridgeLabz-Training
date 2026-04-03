using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.ride_hailing_application
{
    internal interface IGPS
    {
        object GetCurrentLocation();
        object UpdateLocation();
    }
}
