public class VehicleNode
{
    public string VehicleNumber;
    public VehicleNode next;

    public VehicleNode(string number)
    {
        VehicleNumber = number;
        next = null;
    }
}
