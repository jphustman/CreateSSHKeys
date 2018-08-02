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

namespace CreateSSHKeys
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string homefolderText = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        // var welcomeText = string.Format("This will create your SSH keys and place them in your {homefolder}";

        public string homefolder
        {
            get { return homefolderText; }
            set { homefolderText = value; }
        }

        //public string WelcomeText
        //{
         //   get { return welcomeText; }
          //  set { welcomeText = value; }
        //}

        public MainWindow()
        {
            this.DataContext = this;
            InitializeComponent();
        }
    }
}
