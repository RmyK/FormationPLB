using MonEcole.BL;
using MonEcole.DAL.DataModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EcoleWPF
{
    /// <summary>
    /// Interaction logic for DisplayEleve.xaml
    /// </summary>
    public partial class DisplayEleve : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private string nomEcole;

        public string NomEcole
        {
            get { return nomEcole; }
            set
            {
                nomEcole = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Eleve> Eleves { get; set; }

        public Eleve SelectedEleve { get; set; }

        private void LoadEleve()
        {
            var eleveService = new EleveService();
            Eleves = new ObservableCollection<Eleve>(eleveService.GetAll());
            OnPropertyChanged("Eleves");
        }

        public DisplayEleve()
        {
            InitializeComponent();
            DataContext = this;

            var ecoleService = new EcoleService();
            NomEcole = ecoleService.GetEcoleName();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoadEleve();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show($"L'élève sélectionné.e s'appelle : {SelectedEleve.Prenom}");
        }
    }
}
