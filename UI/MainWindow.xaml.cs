using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UI
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            listBox.Items.Clear();
            BL.MyBL bl = new BL.MyBL();
            string myInput = input.Text;
            List<Flower> list = bl.getFlowersWithTheWord(myInput);
            foreach(Flower f in list)
            {    
                listBox.Items.Add(f.Area);
                listBox.Items.Add(f.Color);
                listBox.Items.Add(f.Description);
                listBox.Items.Add("------------");
            }
   
        }
    }
}
