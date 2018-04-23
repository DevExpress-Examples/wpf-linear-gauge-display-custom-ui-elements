using System.Windows;

namespace LinearGauge_CustomElement {
   
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e) {
            if (bar.Value < 100)
                bar.Value += 10;
        }

        private void button2_Click(object sender, RoutedEventArgs e) {
            if (bar.Value > 0)
                bar.Value -= 10;
        }
    }
}
