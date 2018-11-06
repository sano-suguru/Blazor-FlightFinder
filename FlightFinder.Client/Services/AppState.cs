using System;
using Microsoft.AspNetCore.Blazor;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FlightFinder.Shared;

namespace FlightFinder.Client.Services {
  public class AppState {
    public IReadOnlyList<Itinerary> SearchResults { get; private set; }
    public bool SearchInProgress { get; private set; }

    readonly List<Itinerary> shortList = new List<Itinerary>();
    public IReadOnlyList<Itinerary> ShortList => shortList;

    public event Action OnChange;

    readonly HttpClient http;
    public AppState(HttpClient httpClient) =>
      this.http = httpClient;

    public async Task Search(SearchCriteria criteria) {
      SearchInProgress = true;
      NotifyStateChanged();
      SearchResults = await http.PostJsonAsync<Itinerary[]>("api/flightsearch", criteria);
      SearchInProgress = false;
      NotifyStateChanged();
    }

    public void AddtoShortList(Itinerary itinerary) {
      shortList.Add(itinerary);
      NotifyStateChanged();
    }

    public void RemoveFromShortList(Itinerary itinerary) {
      shortList.Remove(itinerary);
      NotifyStateChanged();
    }

    void NotifyStateChanged() => OnChange?.Invoke();
  }
}
