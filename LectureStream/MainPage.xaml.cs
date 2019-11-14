using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LectureStream.Interfaces;
using LectureStream.Views;
using Xamarin.Forms;

namespace LectureStream
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            var connection = DependencyService.Get<ISQLiteDB>().GetConnection();
            connection.CreateTable<Album>();
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
        }
    }
}
