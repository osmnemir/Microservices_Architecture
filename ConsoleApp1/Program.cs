HttpClient httpClient = new();
HttpResponseMessage response = await httpClient.GetAsync("https://localhost:7128/api/values");
if (response.IsSuccessStatusCode)
{
    Console.WriteLine(await response.Content.ReadAsStringAsync());
}