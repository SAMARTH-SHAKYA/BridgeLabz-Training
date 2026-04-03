using System;

public class UserInterface
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Goods Transport details");
        string input = Console.ReadLine();

        Utility util = new Utility();
        GoodsTransport gt = util.parseDetails(input);

        if (gt == null)
            return;

        string type = util.findObjectType(gt);

        Console.WriteLine("Transporter id : " + gt.TransportId);
        Console.WriteLine("Date of transport : " + gt.TransportDate);
        Console.WriteLine("Rating of the transport : " + gt.TransportRating);

        if (type.Equals("BrickTransport"))
        {
            BrickTransport bt = (BrickTransport)gt;
            Console.WriteLine("Quantity of bricks : " + bt.BrickQuantity);
            Console.WriteLine("Brick price : " + bt.BrickPrice);
        }
        else
        {
            TimberTransport tt = (TimberTransport)gt;
            Console.WriteLine("Type of the timber : " + tt.TimberType);
            Console.WriteLine("Timber price per kilo : " + tt.TimberPrice);
        }

        Console.WriteLine("Vehicle for transport : " + gt.vehicleSelection());
        Console.WriteLine("Total charge : " + gt.calculateTotalCharge());
    }
}
