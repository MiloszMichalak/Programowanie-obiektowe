using System.Net.Http.Json;
using TrainTickerReservationSystem.builder;

namespace TrainTickerReservationSystem.api;

public class TrainTicketApiClient
{
    private static readonly Lazy<TrainTicketApiClient> _instance =
        new(() => new TrainTicketApiClient("http://localhost:8080"));

    public static TrainTicketApiClient Instance => _instance.Value;

    private readonly HttpClient _httpClient;

    private TrainTicketApiClient(string baseUrl)
    {
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri(baseUrl),
        };
    }

    public Task<HttpResponseMessage> CreateTicketAsync(TrainTicket ticket)
    {
        return _httpClient.PostAsJsonAsync("tickets/add", ticket);
    }

    public Task<List<TrainTicket>?> GetTicketsAsync()
    {
        return _httpClient.GetFromJsonAsync<List<TrainTicket>>("tickets/list");
    }
}