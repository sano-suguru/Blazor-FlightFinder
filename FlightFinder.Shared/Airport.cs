namespace FlightFinder.Shared {
  class Airport {
    public Airport(string code, string displayName) {
      Code = code;
      DisplayName = displayName;
    }

    public string Code { get; }
    public string DisplayName { get; }
  }
}
