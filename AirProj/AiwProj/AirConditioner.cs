using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiwProj
{
    public class AirConditioner
    {
        private int temperature;

        private int fanIntensity;


        /// <summary>
        /// Температура
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Неверное значение температуры</exception>
        public int Temperature
        {
            get { return temperature; }
            set
            {
                if (value >= 10 && value <= 30)
                    temperature = value;
                else
                    throw new ArgumentOutOfRangeException("Температура должна быть от 10 до 30 градусов Цельсия.");
            }
        }


        /// <summary>
        /// Интенсивность работы
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Неверное значение интенсивности работы</exception>
        public int FanIntensity
        {
            get { return fanIntensity; }
            set
            {
                if (value >= 1 && value <= 10)
                    fanIntensity = value;
                else
                    throw new ArgumentOutOfRangeException("Интенсивность вентилятора должна быть от 1 до 10.");
            }
        }

        public AirConditioner(int initialTemperature, int initialFanIntensity)
        {
            Temperature = initialTemperature;
            FanIntensity = initialFanIntensity;
        }

        /// <summary>
        /// Повышение температуры на 1 шкалу
        /// </summary>
        public void IncreaseTemperature()
        {
            if (Temperature < 30)
                Temperature++;
        }

        /// <summary>
        /// Понижение температуры на 1 шкалу
        /// </summary>
        public void DecreaseTemperature()
        {
            if (Temperature > 10)
                Temperature--;
        }

        /// <summary>
        /// Повышение интенсивности на 1 шкалу. Если значение 10, то повышение приводит к значению 1
        /// </summary>
        public void IncreaseFanIntensity()
        {
            if (FanIntensity < 10)
                FanIntensity++;
            else
                FanIntensity = 1;
        }

        /// <summary>
        /// Понижение интенсивности на 1 шкалу. Если значение 1, то понижение приводит к значению 10
        /// </summary>
        public void DecreaseFanIntensity()
        {
            if (FanIntensity > 1)
                FanIntensity--;
            else
                FanIntensity = 10;
        }



    }
}
