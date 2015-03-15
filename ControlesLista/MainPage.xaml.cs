using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ControlesLista.Resources;
using ControlesLista.Models;

namespace ControlesLista
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Código de ejemplo para traducir ApplicationBar
            BuildLocalizedApplicationBar();
        }

        private void goToPage(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = list.SelectedItem as ItemMenu;
            if (selectedItem.Titulo == "Panorama")
            {
                NavigationService.Navigate(
                    new Uri("/Panorama.xaml?dato1=Saludos"
                    , UriKind.Relative));
            }
            else {
                NavigationService.Navigate(
                    new Uri("/Pivot.xaml?dato2=Hola"
                    , UriKind.Relative));
                
            }


        }

        // Código de ejemplo para compilar una ApplicationBar traducida
        private void BuildLocalizedApplicationBar()
        {
        //    // Establecer ApplicationBar de la página en una nueva instancia de ApplicationBar.
            ApplicationBar = new ApplicationBar();

        //    // Crear un nuevo botón y establecer el valor de texto en la cadena traducida de AppResources.
            ApplicationBarIconButton addButton = new ApplicationBarIconButton(new Uri("/Assets/Icons/new.png", UriKind.Relative));
            addButton.Text = "Agregar";
            addButton.Click += procesarAccion;

            ApplicationBarIconButton editButton = new ApplicationBarIconButton(new Uri("/Assets/Icons/edit.png", UriKind.Relative));
            editButton.Text = "Editar";
            editButton.Click += procesarAccion;

            ApplicationBarIconButton deleteButton = new ApplicationBarIconButton(new Uri("/Assets/Icons/delete.png", UriKind.Relative));
            deleteButton.Text = "Editar";
            deleteButton.Click += procesarAccion;
            

            ApplicationBar.Buttons.Add(addButton);
            ApplicationBar.Buttons.Add(editButton);
            ApplicationBar.Buttons.Add(deleteButton);

        //    // Crear un nuevo elemento de menú con la cadena traducida de AppResources.
            ApplicationBarMenuItem appBarMenuItem = 
                new ApplicationBarMenuItem("Compartir");

            ApplicationBarMenuItem startMenuItem =
                new ApplicationBarMenuItem("Marcar como Favorito");

            ApplicationBar.MenuItems.Add(appBarMenuItem);
            ApplicationBar.MenuItems.Add(startMenuItem);
        }

        void procesarAccion(object sender, EventArgs e)
        {

            MessageBox.Show("Presionaste una accion");
            
        }
    }
}