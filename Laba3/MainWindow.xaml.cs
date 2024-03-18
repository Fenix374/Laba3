using Laba3;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows;

namespace Laba3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
                using (var context = new ASSASINS_CREEDEntities())
                {
                    context.GAMES.Load();
                    context.CHARACTERS.Load();

                    gamesDataGrid.ItemsSource = context.GAMES.Local.Select(g => new
                    {
                        Title = g.TITLE,
                        RealeseDate = g.REALESEDATE,
                        Platforms = g.PLATFORMS,
                        Rating = g.RATING,
                        Description = g.DESCRIPTIONn
                    });

                    charactersDataGrid.ItemsSource = context.CHARACTERS.Local.Select(c => new
                    {
                        Character = c.NAMEe,
                        Game = c.GAMES,
                        Description = c.DESCRIPTIONn
                    });
                }
            
            
        }
    }
}
