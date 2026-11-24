using System;
using System.Windows;
using WeatherApp.Models;
using WeatherApp.Services;
using System.Windows.Controls;
using System.Windows.Media;
using System.Globalization;

namespace WeatherApp {
    public partial class MainWindow : Window {

        // 天気情報を取得するクラス
        private readonly WeatherService _weatherService
            = new WeatherService();

        public MainWindow() {
            InitializeComponent();
        }

        // 天気更新ボタンを押したときの処理
        private async void RefreshButton_Click(
            object sender, RoutedEventArgs e) {

            try {
                // ボタンを無効にする
                RefreshButton.IsEnabled = false;

                StatusText.Text = "天気情報を取得しています...";

                // APIから天気情報を取得する
                WeatherData weather =
                    await _weatherService.GetWeatherAsync();

                // 現在の気温
                TemperatureText.Text =
                    $"{weather.Current.Temperature:0.#} ℃";

                // 現在の天気マーク
                CurrentWeatherIcon.Text =
                    GetWeatherEmoji(weather.Current.WeatherCode);

                // 現在の天気の説明
                WeatherText.Text =
                    GetWeatherDescription(weather.Current.WeatherCode);

                // 湿度
                HumidityText.Text =
                    $"湿度：{weather.Current.Humidity} %";

                // 風速
                WindSpeedText.Text =
                    $"風速：{weather.Current.WindSpeed:0.#} m/s";

                // 7日間の天気予報を表示
                ForecastPanel.Children.Clear();

                DailyWeather daily = weather.Daily;

                if (daily != null &&
                    daily.Dates != null &&
                    daily.WeatherCodes != null &&
                    daily.MaxTemperatures != null &&
                    daily.MinTemperatures != null &&
                    daily.PrecipitationProbabilities != null) {

                    // 配列のデータ数を確認
                    int count = Math.Min(
                        daily.Dates.Length,
                        Math.Min(
                            daily.WeatherCodes.Length,
                            Math.Min(
                                daily.MaxTemperatures.Length,
                                Math.Min(
                                    daily.MinTemperatures.Length,
                                    daily.PrecipitationProbabilities.Length
                                )
                            )
                        )
                    );

                    // 7日分の予報を表示
                    for (int i = 0; i < count; i++) {

                        // 日付
                        string date = DateTime.Parse(daily.Dates[i])
                            .ToString(
                                "M/d (ddd)",
                                new CultureInfo("ja-JP")
                            );

                        // その日の天気コード
                        int code = daily.WeatherCodes[i];

                        // 天気マーク
                        string icon = GetWeatherEmoji(code);

                        // 天気の説明
                        string description =
                            GetWeatherDescription(code);

                        // 日付表示
                        TextBlock dateText = new TextBlock {
                            Text = date,
                            FontSize = 14,
                            FontWeight = FontWeights.Bold,
                            Foreground = Brushes.White,
                            HorizontalAlignment =
                                HorizontalAlignment.Center
                        };

                        // 天気マーク
                        TextBlock iconText = new TextBlock {
                            Text = icon,
                            FontFamily =
                                new FontFamily("Segoe UI Emoji"),
                            FontSize = 48,
                            HorizontalAlignment =
                                HorizontalAlignment.Center,
                            Margin = new Thickness(0, 8, 0, 3)
                        };

                        // 天気の説明
                        TextBlock weatherText = new TextBlock {
                            Text = description,
                            FontSize = 14,
                            FontWeight = FontWeights.Bold,
                            Foreground =
                                new SolidColorBrush(
                                    Color.FromRgb(255, 255, 255)
                                ),
                            HorizontalAlignment =
                                HorizontalAlignment.Center,
                            Margin = new Thickness(0, 0, 0, 5)
                        };

                        // 最高気温
                        TextBlock maxText = new TextBlock {
                            Text = $"↑ {daily.MaxTemperatures[i]:0.#}℃",
                            FontSize = 16,
                            FontWeight = FontWeights.Bold,
                            Foreground =
                                new SolidColorBrush(
                                    Color.FromRgb(255, 180, 80)
                                ),
                            HorizontalAlignment =
                                HorizontalAlignment.Center,
                            Margin = new Thickness(0, 8, 0, 2)
                        };

                        // 最低気温
                        TextBlock minText = new TextBlock {
                            Text = $"↓ {daily.MinTemperatures[i]:0.#}℃",
                            FontSize = 14,
                            Foreground =
                                new SolidColorBrush(
                                    Color.FromRgb(150, 220, 255)
                                ),
                            HorizontalAlignment =
                                HorizontalAlignment.Center
                        };

                        // 降水確率
                        TextBlock rainText = new TextBlock {
                            Text =
                                $"☂ {daily.PrecipitationProbabilities[i]}%",
                            FontSize = 13,
                            FontWeight = FontWeights.Bold,
                            Foreground =
                                new SolidColorBrush(
                                    Color.FromRgb(130, 220, 255)
                                ),
                            HorizontalAlignment =
                                HorizontalAlignment.Center,
                            Margin = new Thickness(0, 9, 0, 0)
                        };

                        // カードの中身
                        StackPanel cardContent = new StackPanel {
                            VerticalAlignment =
                                VerticalAlignment.Center
                        };

                        cardContent.Children.Add(dateText);
                        cardContent.Children.Add(iconText);
                        cardContent.Children.Add(weatherText);
                        cardContent.Children.Add(maxText);
                        cardContent.Children.Add(minText);
                        cardContent.Children.Add(rainText);

                        // カード本体
                        Border forecastCard = new Border {
                            Background =
                                new SolidColorBrush(
                                    Color.FromRgb(65, 107, 147)
                                ),
                            CornerRadius = new CornerRadius(12),
                            Width = 125,
                            Height = 210,
                            Margin = new Thickness(5),
                            Padding = new Thickness(8),
                            Child = cardContent
                        };

                        // 画面に追加
                        ForecastPanel.Children.Add(forecastCard);
                    }
                }

                // 更新完了
                StatusText.Text = "天気情報を更新しました！";
            }

            catch (Exception ex) {

                StatusText.Text = "天気情報の取得に失敗しました";

                MessageBox.Show(
                    ex.Message,
                    "天気情報取得エラー",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                );
            }

            finally {
                // ボタンを再び有効にする
                RefreshButton.IsEnabled = true;
            }
        }

        // 天気コードからカラフルな天気マークを取得
        private string GetWeatherEmoji(int code) {

            return code switch {
                0 => "☀️",
                1 => "🌤️",
                2 => "⛅",
                3 => "☁️",
                45 or 48 => "🌫️",
                51 or 53 or 55 or 56 or 57 => "🌦️",
                61 or 63 or 65 or 66 or 67 => "🌧️",
                71 or 73 or 75 or 77 => "❄️",
                80 or 81 or 82 => "🌧️",
                85 or 86 => "🌨️",
                95 or 96 or 99 => "⛈️",
                _ => "🌈"
            };
        }

        // 天気コードから日本語の説明を取得
        private string GetWeatherDescription(int code) {

            return code switch {
                0 => "快晴",
                1 => "晴れ",
                2 => "晴れ時々曇り",
                3 => "曇り",

                45 or 48 => "霧",

                51 or 53 or 55 => "霧雨",
                56 or 57 => "凍るような霧雨",

                61 => "弱い雨",
                63 => "雨",
                65 => "強い雨",
                66 or 67 => "凍るような雨",

                71 => "弱い雪",
                73 => "雪",
                75 => "大雪",
                77 => "雪の粒",

                80 => "にわか雨",
                81 => "強いにわか雨",
                82 => "激しいにわか雨",

                85 => "弱い雪",
                86 => "強い雪",

                95 => "雷雨",
                96 or 99 => "ひょうを伴う雷雨",

                _ => "天気不明"
            };
        }
    }
}