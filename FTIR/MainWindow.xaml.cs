using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace FTIR
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private bool _isBaselineSetted;

        public List<Comparison> comparison = new List<Comparison>();
        public ObservableCollection<LibraryItem> libraryItems = new ObservableCollection<LibraryItem>();
        public bool IsOffline;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool IsBaselineSetted
        {
            get { return _isBaselineSetted; }
            set { _isBaselineSetted = value; OnPropertyChanged("IsBaselineSetted"); }
        }
        public MainWindow()
        {
            InitializeComponent();
            FillGrid();
            FillList();
            //comparisonGrid.DataContext = comparison;
            lbLaboratoryElements.ItemsSource = libraryItems;
            comparisonGrid.ItemsSource = comparison;
            //this.DataContext = this;
        }

        private void FillGrid()
        {
            comparison.Add(new Comparison { Score = 990, Library = "Sample Library 1", Name = "Sample 1", Comment = "Comment for sample 1" });
            comparison.Add(new Comparison { Score = 990, Library = "Sample Library 1", Name = "Sample 2", Comment = "Comment for sample 2" });
            comparison.Add(new Comparison { Score = 990, Library = "Sample Library 1", Name = "Sample 3", Comment = "Comment for sample 3" });
            comparison.Add(new Comparison { Score = 990, Library = "Sample Library 1", Name = "Sample 4", Comment = "Comment for sample 4" });
            comparison.Add(new Comparison { Score = 990, Library = "Sample Library 1", Name = "Sample 5", Comment = "Comment for sample 5" });
            comparison.Add(new Comparison { Score = 990, Library = "Sample Library 1", Name = "Sample 6", Comment = "Comment for sample 6" });
            comparison.Add(new Comparison { Score = 990, Library = "Sample Library 1", Name = "Sample 7", Comment = "Comment for sample 7" });
            comparison.Add(new Comparison { Score = 990, Library = "Sample Library 1", Name = "Sample 7a", Comment = "Comment for sample 7a" });
            comparison.Add(new Comparison { Score = 990, Library = "Sample Library 1", Name = "Sample 8", Comment = "Comment for sample 8" });
            comparison.Add(new Comparison { Score = 990, Library = "Sample Library 1", Name = "Sample 9", Comment = "Comment for sample 9" });
            comparison.Add(new Comparison { Score = 990, Library = "Sample Library 1", Name = "Sample 10", Comment = "Comment for sample 10" });
            comparison.Add(new Comparison { Score = 990, Library = "Sample Library 1", Name = "Sample 11", Comment = "Comment for sample 11" });
            comparison.Add(new Comparison { Score = 990, Library = "Sample Library 1", Name = "Sample 12", Comment = "Comment for sample 12" });
            comparison.Add(new Comparison { Score = 990, Library = "Sample Library 1", Name = "Sample 13", Comment = "Comment for sample 13" });
        }

        private void FillList()
        {
            libraryItems.Add(new LibraryItem { IsChecked = true, Name = "Library Element Name 1" });
            libraryItems.Add(new LibraryItem { IsChecked = true, Name = "Library Element Name 2" });
            libraryItems.Add(new LibraryItem { IsChecked = true, Name = "Library Element Name 3" });
            libraryItems.Add(new LibraryItem { IsChecked = true, Name = "Library Element Name 4" });
            libraryItems.Add(new LibraryItem { IsChecked = true, Name = "Library Element Name 5" });
            libraryItems.Add(new LibraryItem { IsChecked = true, Name = "Library Element Name 6" });
            libraryItems.Add(new LibraryItem { IsChecked = true, Name = "Library Element Name 7" });
            libraryItems.Add(new LibraryItem { IsChecked = true, Name = "Library Element Name 8" });
            libraryItems.Add(new LibraryItem { IsChecked = true, Name = "Library Element Name 9" });
            libraryItems.Add(new LibraryItem { IsChecked = true, Name = "Library Element Name 10" });
            libraryItems.Add(new LibraryItem { IsChecked = true, Name = "Library Element Name 11" });
            libraryItems.Add(new LibraryItem { IsChecked = true, Name = "Library Element Name 12" });
            libraryItems.Add(new LibraryItem { IsChecked = true, Name = "Library Element Name 13" });
            libraryItems.Add(new LibraryItem { IsChecked = true, Name = "Library Element Name 14" });
        }



        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.Show();
        }

        private void btnSetBaseLine_Click(object sender, RoutedEventArgs e)
        {
            IsBaselineSetted = true;
        }
    }
}
