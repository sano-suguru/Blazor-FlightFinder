namespace FlightFinder.Shared {
  public enum TicketClass : int {
    Economy,
    PremiumEconomy,
    Business,
    First
  }
  public static class TicketClassExtentions {
    readonly static string[] ClassNames = {
      "Economy", "Premium Economy", "Business", "First"
    };
    public static string ToDisplayString(this TicketClass ticketClass) =>
      ClassNames[(int)ticketClass];
  }
}