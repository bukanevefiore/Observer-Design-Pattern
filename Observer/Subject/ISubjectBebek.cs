using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
      // takip edilecek sınıfımız
    public interface ISubjectBebek
    {
        // yeni girişlerde burda değişiklik olmuyor
        void RegisterObserver(IObserverBakıcı observerBakıcı);
        void UnRegisterObserver(IObserverBakıcı observerBakıcı);
        void NotifyObservers();
    }
}
