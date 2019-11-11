using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UXPlayer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            var Entry = new ToolbarItem
           {  
              IconImageSource = "search.png" 

            };  
             var Button = new ToolbarItem  
             {  
                 Text = "New broadcast",

                 Order = ToolbarItemOrder.Secondary  

             };  

             this.ToolbarItems.Add(Entry);  
             this.ToolbarItems.Add(Button); 
        }

    }
}