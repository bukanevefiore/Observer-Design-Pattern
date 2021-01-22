using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Temperatures : ISubjectBebek
    {
        // yapıcı method
        public Temperatures()
        {
            observers = new List<IObserverBakıcı>();    // gözlemci listemiz

        }
        // observer listesi 
        public List<IObserverBakıcı> observers;

        // proporties
        private float _temperature;

        public float temperature
        {
            get { return _temperature; }
            set
            {
                _temperature = value;
               // NotifyObservers();
            }

        }


        private string _name;
        public string name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyObservers();
            }

        }


        // methodlarımızın içeriklerini oluşturuyoruz
        public void NotifyObservers()
        {
            foreach(IObserverBakıcı ob in observers)
            {
                ob.Update(this.temperature, Convert.ToString( this.name));
            }
        }

        public void RegisterObserver(IObserverBakıcı observerBakıcı)
        {
            observers.Add(observerBakıcı);
        }

        public void UnRegisterObserver(IObserverBakıcı observerBakıcı)
        {
            observers.Remove(observerBakıcı);
        }
    }
}
