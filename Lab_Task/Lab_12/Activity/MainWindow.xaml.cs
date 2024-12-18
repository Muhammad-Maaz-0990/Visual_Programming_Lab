using System;
using System.Windows;
using System.Windows.Controls;

namespace Activity
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            var timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += (s, e) => CurrentTime = DateTime.Now;
            timer.Start();

        }

        public DateTime CurrentTime
        {
            get { return (DateTime)GetValue(CurrentTimeProperty); }
            set { SetValue(CurrentTimeProperty, value); }
        }

        public static readonly DependencyProperty CurrentTimeProperty = DependencyProperty.Register(
            "CurrentTime",
            typeof(DateTime),
            typeof(MainWindow),
            new FrameworkPropertyMetadata(DateTime.Now, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnCurrentTimeChanged)
        );

        private static void OnCurrentTimeChanged(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            MainWindow control = source as MainWindow;
            DateTime newTime = (DateTime)e.NewValue;
        }

        private static bool OnValidateCurrentTimeProperty(object value)
        {
            DateTime timeValue = (DateTime)value;
            return timeValue > DateTime.MinValue; 
        }
    }
}
