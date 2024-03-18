using Laba3;
using System;
using System.Windows;

namespace Laba3
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {

                var dataSet = new ASSASINS_CREEDDataSet1();

                gamesDataGrid.ItemsSource = dataSet.GAMES;
            charactersDataGrid.ItemsSource = dataSet.CHARACTERS;
           
        }
    }
}
