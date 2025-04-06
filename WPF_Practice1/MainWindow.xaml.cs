using System;
using System.Collections.Generic;
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


namespace WPF_Practice1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()

        {

            InitializeComponent();

            LoadData();

        }


        private void LoadData()

        {

            // создаем список объектов documents для отображения в DataGrid

            List<Worker> documents = new List<Worker>

            {

                new Worker { Documents = 0007, Institution = "МЦК-КТИТС", Qualification = "Бакалавр", Speciality = "ИСИП" },

                

            };


            // устанавливаем источник данных для DataGrid

            dataGrid.ItemsSource = documents;
        }


        public class Worker

        { 
            public string Institution { get; set; }
            public int Documents { get; set; }
            public string Speciality { get; set; }
            public string Qualification {  get; set; }


        }


    }
}
