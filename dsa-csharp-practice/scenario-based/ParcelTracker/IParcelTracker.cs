public interface IParcelTracker
{
    Stages CreateStagesNode();
    void AddParcel(string name);
    void MoveToNextStage(string name);
    void TrackParcel(string name);
    void MarkLost(string name);
}
