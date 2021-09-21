using MacroscopTest.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xamarin.Essentials;

namespace MacroscopTest.ViewModels
{
    class CamerasListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Camera> Cameras { get; set; }
        public CamerasListViewModel()
        {
            Cameras = new ObservableCollection<Camera>();
            LoadAsync();
        }
        public void Update()
        {
            Cameras.Clear();
            LoadAsync();
        }
        private async void LoadAsync()
        {
            await Task.Run(() => Load());
        }
        private void Load()
        {
                XDocument xDocument = XDocument.Load(@"http://demo.macroscop.com/configex?login=root&amp;password=");
                var cam = from n in xDocument.Root.Element("Channels").Elements("ChannelInfo") select new Camera { Name = n.Attribute("Name").Value, ServerName = n.Attribute("Id").Value, IsSoundOn = Convert.ToBoolean(n.Attribute("IsSoundOn").Value) };
                foreach (var c in cam)
                    Cameras.Add(c);
        }
    }
}
