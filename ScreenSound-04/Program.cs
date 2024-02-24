using (HttpClient client = new HttpClient())
{
    string reposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    Console.WriteLine(reposta);
}