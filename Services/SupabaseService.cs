public class SupabaseService
{
    private readonly HttpClient _client;

    public SupabaseService(HttpClient client)
    {
        _client = client;
        _client.BaseAddress = new Uri("https://bzqpemdhtgahihjzfcvo.supabase.co/rest/v1/");
        _client.DefaultRequestHeaders.Add("apikey", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImJ6cXBlbWRodGdhaGloanpmY3ZvIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NDc1ODk5MTksImV4cCI6MjA2MzE2NTkxOX0.O6uMbCxtng07FvgFrtkdwLeNXrnPcLXAyji-G1XF1kk");
        _client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImJ6cXBlbWRodGdhaGloanpmY3ZvIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NDc1ODk5MTksImV4cCI6MjA2MzE2NTkxOX0.O6uMbCxtng07FvgFrtkdwLeNXrnPcLXAyji-G1XF1kk");
    }

    public async Task<string> GetPlacesAsync()
    {
        var response = await _client.GetAsync("places?select=*");
        return await response.Content.ReadAsStringAsync();
    }

    // Get places by city
    public async Task<string> GetPlacesByCityAsync(string city)
    {
        var encodedCity = Uri.EscapeDataString(city);
        var response = await _client.GetAsync($"places?city=eq.{encodedCity}&select=*");
        return await response.Content.ReadAsStringAsync();
    }
}
