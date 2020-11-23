using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLTemperature
{
    public class Temperature
    {

        private float temperature;

        /// <summary>
        /// evenement qui se produit qd risque de gel 0 --- Gel
        /// evenement qui se produit qd on a de la fievre 38--- Fievre
        /// 
        /// 
        /// Cerise sur le gateau:
        /// 
        /// evenement preconfigurable...evenement declenche pour une temperature specifique
        private float[] temperatureDAlertes;
        /// </summary>

        public void Monter()
        {
        }

        public void Diminuer()
        { 
        }
    }
}
