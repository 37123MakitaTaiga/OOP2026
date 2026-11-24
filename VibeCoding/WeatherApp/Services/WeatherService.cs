using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.Services {
    public class WeatherService {
        // API通信に使用するHttpClient
        private readonly HttpClient _httpClient;

        public WeatherService() {
            _httpClient = new HttpClient();
        }

        // 東京の天気情報を取得する
        public async Task<WeatherData> GetWeatherAsync() {
            string url =
                "https://api.open-meteo.com/v1/forecast" +
                "?latitude=35.6762" +
                "&longitude=139.6503" +
                "&current=temperature_2m,relative_humidity_2m,weather_code,wind_speed_10m" +
                "&daily=weather_code,temperature_2m_max,temperature_2m_min,precipitation_probability_max" +
                "&timezone=Asia%2FTokyo" +
                "&forecast_days=7";

            // APIにアクセスする
            HttpResponseMessage response =
                await _httpClient.GetAsync(url);

            // 通信エラーを確認する
            response.EnsureSuccessStatusCode();

            // JSONデータを取得する
            string json =
                await response.Content.ReadAsStringAsync();

            // JSONをC#のクラスに変換する
            WeatherData weather =
                JsonSerializer.Deserialize<WeatherData>(json);

            return weather;
        }
    }
}