using System.Windows;

namespace ScaleCheck
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Btn_Close(object sender, RoutedEventArgs e)
        {
            var Ok = MessageBox.Show("Are you want to close", "Scale Check", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (Ok == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }
        private void Btn_Clear(object sender,RoutedEventArgs e)
        {
            TxtP.Text = "";
            TxtA.Text = "";
            TxtD1.Text = "";
            TxtD2.Text = "";
            TxtDD1.Text = "";
            TxtDD2.Text = "";
            TxtDS1.Text = "";
            TxtDS2.Text = "";
            TxtDS3.Text = "";
            TxtI.Text = "";
            TxtM.Text = "";
            TxtM12.Text = "";
            TxtM3.Text = "";
            TxtO.Text = "";
            TxtS.Text = "";
            TxtT1.Text = "";
            TxtT2.Text = "";
            TxtV1.Text = "";
            TxtV2.Text = "";
            TxtT.Text = "";
            TxtMM2.Text = "";
            TxtMM4.Text = "";
        }

        private void Btn_Search(object sender,RoutedEventArgs e)
        {

        }
    }
}
