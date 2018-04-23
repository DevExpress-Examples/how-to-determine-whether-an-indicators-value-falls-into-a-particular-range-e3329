using System.Windows.Controls;
using System.Windows.Media;
using DevExpress.Xpf.Gauges;

namespace DXGauge_RangeEvents {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        private void GreenRange_IndicatorEnter(object sender, IndicatorEnterEventArgs e) {
            stateIndicator.Fill = new SolidColorBrush(Colors.Green);
        }

        private void GreenRange_IndicatorLeave(object sender, IndicatorLeaveEventArgs e) {
            stateIndicator.Fill = new SolidColorBrush(Colors.Gray);
        }

        private void YellowRange_IndicatorEnter(object sender, IndicatorEnterEventArgs e) {
            stateIndicator.Fill = new SolidColorBrush(Colors.Yellow);
        }

        private void YellowRange_IndicatorLeave(object sender, IndicatorLeaveEventArgs e) {
            if (((e.NewValue) < 10) || (((e.NewValue) > 90)))
                stateIndicator.Fill = new SolidColorBrush(Colors.Gray);
        }

        private void RedRange_IndicatorEnter(object sender, IndicatorEnterEventArgs e) {
            stateIndicator.Fill = new SolidColorBrush(Colors.Red);
        }

        private void RedRange_IndicatorLeave(object sender, IndicatorLeaveEventArgs e) {
            if (((e.NewValue) < 10) || (((e.NewValue) > 90)))
                stateIndicator.Fill = new SolidColorBrush(Colors.Gray);
        }
    }
}
