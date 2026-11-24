using System;
using System.Text.Json.Serialization;

namespace WeatherApp.Models {
    // APIから取得する天気情報
    public class WeatherData {
        [JsonPropertyName("current")]
        public CurrentWeather Current { get; set; }

        [JsonPropertyName("daily")]
        public DailyWeather Daily { get; set; }
    }

    // 現在の天気
    public class CurrentWeather {
        [JsonPropertyName("temperature_2m")]
        public double Temperature { get; set; }

        [JsonPropertyName("relative_humidity_2m")]
        public int Humidity { get; set; }

        [JsonPropertyName("weather_code")]
        public int WeatherCode { get; set; }

        [JsonPropertyName("wind_speed_10m")]
        public double WindSpeed { get; set; }
    }

    // 7日間の天気予報
    public class DailyWeather {
        [JsonPropertyName("time")]
        public string[] Dates { get; set; }

        [JsonPropertyName("weather_code")]
        public int[] WeatherCodes { get; set; }

        [JsonPropertyName("temperature_2m_max")]
        public double[] MaxTemperatures { get; set; }

        [JsonPropertyName("temperature_2m_min")]
        public double[] MinTemperatures { get; set; }

        [JsonPropertyName("precipitation_probability_max")]
        public int[] PrecipitationProbabilities { get; set; }
    }
}