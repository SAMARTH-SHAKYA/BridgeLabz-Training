class HospitalUnit
{
  public string Name { get; set; }
  public bool Occupied { get; set; }
  public HospitalUnit NextUnit { get; set; }
  public HospitalUnit PrevUnit { get; set; }

  public HospitalUnit(string name)
  {
    Name = name;
    Occupied = false;
    NextUnit = null;
    PrevUnit = null;
  }
}