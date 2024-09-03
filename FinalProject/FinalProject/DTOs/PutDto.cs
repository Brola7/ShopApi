using System.Text.Json.Serialization;

namespace FinalProject.DTOs
{
    public class PutDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("stock")]
        public int Stock { get; set; }
    }
}
