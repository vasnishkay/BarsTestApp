using BarsTestApp.Services;
using System.Windows;

namespace BarsTestApp
{
    public partial class MainWindow : Window
    {
        private readonly IContractService _contractService;

        public MainWindow(IContractService contractService)
        {
            _contractService = contractService;
            InitializeComponent();
            dataGrid.ItemsSource = _contractService.GetContracts();
        }
    }
}
