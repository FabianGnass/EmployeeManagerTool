using EmployeeManagerTool.viewModel;
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

namespace EmployeeManagerTool.views
{
    /// <summary>
    /// Interaction logic for EmployeeListView.xaml
    /// </summary>
    public partial class EmployeeListView : Page
    {
        public EmployeeListView()
        {
            InitializeComponent();
            EmployeeListViewModel viewModel = new EmployeeListViewModel();
            this.DataContext = viewModel;
        }
    }
}
