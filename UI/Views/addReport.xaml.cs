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
using UI.ViewModels;

namespace UI
{
    /// <summary>
    /// Interaction logic for addReport.xaml
    /// </summary>
    public partial class addReport : UserControl
    {
        public AddReportViewModel CurrentVM { set; get; }
        public addReport()
        {
            InitializeComponent();
            CurrentVM = new AddReportViewModel();
            this.DataContext = CurrentVM;
        }
    }
}
