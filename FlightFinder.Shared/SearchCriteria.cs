using System;

namespace FlightFinder.Shared {
  public class SearchCriteria {
    public SearchCriteria(
      string fromAirport, string toAirport, TicketClass ticketClass
    ) {
      FromAirport = fromAirport;
      ToAirport = toAirport;
      TicketClass = ticketClass;
      OutboundDate = DateTime.Now.Date;
      ReturnDate = OutboundDate.AddDays(7);
    }

    public string FromAirport { get; }
    public string ToAirport { get; }
    public TicketClass TicketClass { get; }
    public DateTime OutboundDate { get; }
    public DateTime ReturnDate { get; }
  }
}
