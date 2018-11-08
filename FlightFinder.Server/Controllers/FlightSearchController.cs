using FlightFinder.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightFinder.Server.Controllers {
  [Route("api/[controller]")]
  public class FlightSearchController : Controller {
    public async Task<IEnumerable<Itinerary>> Search([FromBody] SearchCriteria criteria) {
      // web api 疑似遅延
      await Task.Delay(500);
      var random = new Random();
      return Enumerable.Range(0, random.Next(1, 5))
        .Select(_ => new Itinerary(
          price: random.Next(100, 2000),
          outBound: new FlightSegment(
            airLine: RandomAirline(),
            fromAirportCode: criteria.FromAirport,
            toAirportCode: criteria.ToAirport,
            departureTime: criteria.OutboundDate.AfterLessThanADay(),
            returnTime: criteria.OutboundDate.AfterLessThanADay(),
            durationHours: 2 + random.Next(10),
            ticketClass: criteria.TicketClass
          ),
          @return: new FlightSegment(
            airLine: RandomAirline(),
            fromAirportCode: criteria.FromAirport,
            toAirportCode: criteria.ToAirport,
            departureTime: criteria.ReturnDate.AfterLessThanADay(),
            returnTime: criteria.ReturnDate.AfterLessThanADay(),
            durationHours: 2 + random.Next(10),
            ticketClass: criteria.TicketClass
          )
        ));
    }

    private string RandomAirline() =>
      SampleData.Airlines[new Random().Next(SampleData.Airlines.Length)];
  }

  static class DateTimeExtentions {
    public static DateTime AfterLessThanADay(this DateTime dateTime) {
      var random = new Random();
      return dateTime
       .AddHours(random.Next(24))
       .AddMinutes(5 * random.Next(12));
    }
  }
}