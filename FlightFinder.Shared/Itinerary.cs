using System;

namespace FlightFinder.Shared {
  public class Itinerary {
    public Itinerary(
      FlightSegment outBound, FlightSegment @return, decimal price
    ) {
      this.OutBound = outBound ?? throw new ArgumentNullException(nameof(outBound));
      this.Return = @return ?? throw new ArgumentNullException(nameof(@return));
      this.Price = price;
    }

    public Itinerary() { }

    public FlightSegment OutBound { get; private set; }
    public FlightSegment Return { get; private set; }
    public decimal Price { get; private set; }

    public double TotalDurationhours =>
      OutBound.DurationHours + Return.DurationHours;

    public string AirlineName =>
      (OutBound.AirLine == Return.AirLine) ? OutBound.AirLine : "Multiple airlines";
  }
}
