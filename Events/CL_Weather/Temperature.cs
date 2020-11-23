using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Temperature
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

        public delegate void DelegateAlerte(float temperatureDAlerte);
        public event DelegateAlerte Alerte;

        public Temperature(float temperature, float[] temperatureDAlertes)
        {
            this.temperature = temperature;
            this.temperatureDAlertes = temperatureDAlertes;
        }

        public Temperature(float[] temperatureDAlertes)
        {
            this.temperature = 20;
            this.temperatureDAlertes = temperatureDAlertes;
        }

        public Temperature()
        {
            this.temperature = 20;
            this.temperatureDAlertes = new float[] { 0, 5, 10, 15, 25 };
        }


        /// </summary>
        private void CheckTemperatureDAlertes()
        {
   
            if (temperatureDAlertes.Length != 0)
            {
                bool trouve = false;
                int i = 0;
                while ((!trouve)&&(i<temperatureDAlertes.Length))
                {
                    if (temperature.Equals(temperatureDAlertes[i]))
                    {
                        trouve = true;
                        //genere l'evenement
                        if (Alerte != null)
                        {
                            Alerte(temperatureDAlertes[i]);
                        }

                    }

                    i++;
                }
               
            }
        }

        public void Monter()
        {
            temperature++;
            CheckTemperatureDAlertes();
        }

        public void Diminuer()
        {
            temperature--;
            CheckTemperatureDAlertes();
        }
    }
}
