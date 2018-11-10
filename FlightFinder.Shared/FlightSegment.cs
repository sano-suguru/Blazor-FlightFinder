using System;

namespace FlightFinder.Shared {
  public class FlightSegment {
    public FlightSegment() { }
    public FlightSegment(
      string airLine,
      string fromAirportCode,
      string toAirportCode,
      DateTime departureTime,
      DateTime returnTime,
      double durationHours,
      TicketClass ticketClass
    ) {
      this.AirLine = airLine;
      this.FromAirportCode = fromAirportCode;
      this.ToAirportCode = toAirportCode;
      this.DepartureTime = departureTime;
      this.ReturnTime = returnTime;
      this.DurationHours = durationHours;
      this.TicketClass = ticketClass;
    }

    public string AirLine { get; private set; }
    public string FromAirportCode { get; private set; }
    public string ToAirportCode { get; private set; }
    public DateTime DepartureTime { get; private set; }
    public DateTime ReturnTime { get; private set; }
    public double DurationHours { get; private set; }
    public TicketClass TicketClass { get; private set; }
  }
}
