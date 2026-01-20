using System;
using System.Collections.Generic;

public class ParcelUtilityIMPL : IParcelTracker
{
    private Dictionary<string, Parcel> parcels = new Dictionary<string, Parcel>();
    private Stages headStage;

    public ParcelUtilityIMPL()
    {
        headStage = CreateStagesNode();
    }

    public Stages CreateStagesNode()
    {
        Stages packed = new Stages("Packed");
        Stages shipped = new Stages("Shipped");
        Stages inTransit = new Stages("In Transit");
        Stages outForDelivery = new Stages("Out for Delivery");
        Stages delivered = new Stages("Delivered");

        packed.SetNext(shipped);
        shipped.SetNext(inTransit);
        inTransit.SetNext(outForDelivery);
        outForDelivery.SetNext(delivered);

        return packed;
    }

    public void AddParcel(string name)
    {
        if (parcels.ContainsKey(name))
        {
            Console.WriteLine("Parcel already exists!");
            return;
        }

        Parcel parcel = new Parcel(name);
        parcel.SetParcelStageNode(headStage);
        parcels[name] = parcel;

        Console.WriteLine("Parcel added at Packed stage.");
    }

    public void MoveToNextStage(string name)
    {
        if (!parcels.ContainsKey(name))
        {
            Console.WriteLine("Parcel not found!");
            return;
        }

        Parcel parcel = parcels[name];

        if (parcel.ParcelStageNode == null)
        {
            Console.WriteLine("Parcel is LOST.");
            return;
        }

        if (parcel.ParcelStageNode.Next == null)
        {
            Console.WriteLine("Parcel already delivered!");
            return;
        }

        parcel.SetParcelStageNode(parcel.ParcelStageNode.Next);
        Console.WriteLine("Parcel moved to next stage.");
    }

    public void TrackParcel(string name)
    {
        if (!parcels.ContainsKey(name))
        {
            Console.WriteLine("Parcel not found!");
            return;
        }

        Parcel parcel = parcels[name];

        if (parcel.ParcelStageNode == null)
        {
            Console.WriteLine("Parcel is LOST.");
        }
        else
        {
            Console.WriteLine(parcel.ParcelStageNode);
        }
    }

    public void MarkLost(string name)
    {
        if (!parcels.ContainsKey(name))
        {
            Console.WriteLine("Parcel not found!");
            return;
        }

        parcels[name].SetParcelStageNode(null);
        Console.WriteLine("Parcel marked as LOST.");
    }
}
