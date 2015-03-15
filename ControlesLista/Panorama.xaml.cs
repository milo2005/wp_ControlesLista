using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace ControlesLista
{
    public partial class Panorama : PhoneApplicationPage
    {
        public Panorama()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if(NavigationContext.QueryString.ContainsKey("dato1")){
            
                String dato1 = NavigationContext.QueryString["dato1"];
                panorama.Title = dato1;

            }
        }
    }
}