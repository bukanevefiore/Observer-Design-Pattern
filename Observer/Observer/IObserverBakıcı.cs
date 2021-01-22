using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface IObserverBakıcı
    {
        // Bir değişiklikte bildirilecek methodumuz 
        void Update(float temperature, string name);
    }
}
