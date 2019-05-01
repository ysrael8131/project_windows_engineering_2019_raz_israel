using DevExpress.Xpf.Map;
using System;
using System.Collections.Generic;
using System.Device.Location;
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
    /// Interaction logic for explosionMap.xaml
    /// </summary>
    public partial class explosionMap : UserControl
    {
        public explosionMap()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            List<GeoPoint> locations = new List<GeoPoint> {
                new GeoPoint(31,35),
                new GeoPoint(36.131389, -90.937222),
                new GeoPoint(32.175, -80.136389)
            };
          //  provider.RequestPointsElevations(locations);
       
        }
        
    }
}
