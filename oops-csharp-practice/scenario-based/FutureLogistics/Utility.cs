using System;
using System.Text.RegularExpressions;

public class Utility
{
    public bool validateTransportId(string transportId)
    {
        if (!Regex.IsMatch(transportId, "^RTS[0-9]{3}[A-Z]$"))
        {
            Console.WriteLine("Transport id " + transportId + " is invalid");
            Console.WriteLine("Please provide a valid record");
            return false;
        }
        return true;
    }

    public GoodsTransport parseDetails(string input)
    {
        string[] data = input.Split(':');
        string transportId = data[0];

        if (!validateTransportId(transportId))
            return null;

        string transportDate = data[1];
        int rating = int.Parse(data[2]);
        string type = data[3];

        if (type.Equals("BrickTransport", StringComparison.OrdinalIgnoreCase))
        {
            return new BrickTransport(
                transportId, transportDate, rating,
                float.Parse(data[4]),
                int.Parse(data[5]),
                float.Parse(data[6])
            );
        }
        else
        {
            return new TimberTransport(
                transportId, transportDate, rating,
                float.Parse(data[4]),
                float.Parse(data[5]),
                data[6],
                float.Parse(data[7])
            );
        }
    }

    public string findObjectType(GoodsTransport gt)
    {
        if (gt is TimberTransport)
            return "TimberTransport";
        else
            return "BrickTransport";
    }
}
