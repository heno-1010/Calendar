namespace Calendar
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            displayDates();
        }

        public void displayDates()
        {
            int displayYear = 2026;
            int displayMonth = 1;
            var firstDayOfMonth = new DateTime(displayYear, displayMonth, 1);//何曜日から始まるか
            var daysInMonth = DateTime.DaysInMonth(displayYear, displayMonth);//その月の日数
            int firstDayOfWeek = ((int)firstDayOfMonth.DayOfWeek + 6) % 7;//曜日を数値化

            for (int i = 0; i < 42; i++)
            {
                int day = i - firstDayOfWeek + 1;//日付表示用
                int row = i / 7;//行数計算
                int col = i % 7;//列数計算

                var border = new Border
                {
                    Stroke = Colors.LightGray,
                    StrokeThickness = 1
                };

                if (day >= 1 && day <= daysInMonth)
                {
                    border.Content = new Label{
                        Text = day.ToString(),
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Center
                    };
                }

                Grid.SetRow(border, row);
                Grid.SetColumn(border, col);
                CalendarGrid.Children.Add(border);

            }
        }
    }
}
