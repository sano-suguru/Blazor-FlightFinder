using System;

namespace FlightFinder.Shared {
  class FlightSegment {
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

    public string AirLine { get; }
    public string FromAirportCode { get; }
    public string ToAirportCode { get; }
    public DateTime DepartureTime { get; }
    public DateTime ReturnTime { get; }
    public double DurationHours { get; }
    public TicketClass TicketClass { get; }
  }
}
