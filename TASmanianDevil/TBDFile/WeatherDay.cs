using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBDFile
{
    /// <summary>
    /// TAS Weather Day
    /// </summary>
    public class WeatherDay
    {
        private TBD.WeatherDay pWeatherDay;

        internal WeatherDay(TBD.WeatherDay WeatherDay)
        {
            pWeatherDay = WeatherDay;
        }

        /// <summary>
        /// TAS Weather Day Cloud Cover
        /// </summary>
        /// <param name="WeatherDay">Weather Day</param>
        /// <param name="Hour">Hour</param>
        /// <returns name="CloudCover">Cloud Cover</returns>
        /// <search>
        /// TAS, WeatherDay, Weatherday, Weather Day, Weatherday, CloudCover, Weather Day Descriprion, Weatherdaycloudcover, cloudcover
        /// </search>
        public static float CloudCover(WeatherDay WeatherDay, int Hour)
        {
            return WeatherDay.pWeatherDay.cloudCover[Hour];
        }

        /// <summary>
        /// TAS Weather Day Diffuse Radiation
        /// </summary>
        /// <param name="WeatherDay">Weather Day</param>
        /// <param name="Hour">Hour</param>
        /// <returns name="DiffuseRadiation">Diffuse Radiation</returns>
        /// <search>
        /// TAS, WeatherDay, Weatherday, Weather Day, Weatherday, Diffuse Radiation, Weather Day Diffuse Radiation, Weatherdaydiffuseradiation, diffuseradiation, DiffuseRadiation
        /// </search>
        public static float DiffuseRadiation(WeatherDay WeatherDay, int Hour)
        {
            return WeatherDay.pWeatherDay.diffuseRadiation[Hour];
        }

        /// <summary>
        /// TAS Weather Day Dry Bulb
        /// </summary>
        /// <param name="WeatherDay">Weather Day</param>
        /// <param name="Hour">Hour</param>
        /// <returns name="DryBulb">Dry Bulb Temperature</returns>
        /// <search>
        /// TAS, WeatherDay, Weatherday, Weather Day, Weatherday, Diffuse Radiation, Weather Day Diffuse Radiation, Weatherdaydiffuseradiation, diffuseradiation, DiffuseRadiation
        /// </search>
        public static float DryBulb(WeatherDay WeatherDay, int Hour)
        {
            return WeatherDay.pWeatherDay.dryBulb[Hour];
        }

        /// <summary>
        /// TAS Weather Day Global Radiation
        /// </summary>
        /// <param name="WeatherDay">Weather Day</param>
        /// <param name="Hour">Hour</param>
        /// <returns name="GlobalRadiation">Global Radiation</returns>
        /// <search>
        /// TAS, WeatherDay, Weatherday, Weather Day, Weatherday, Global Radiation, Weather Day Global Radiation, Weatherdayglobalradiation, globalradiation, GlobalRadiation
        /// </search>
        public static float GlobalRadiation(WeatherDay WeatherDay, int Hour)
        {
            return WeatherDay.pWeatherDay.globalRadiation[Hour];
        }

        /// <summary>
        /// TAS Weather Day Humidity
        /// </summary>
        /// <param name="WeatherDay">Weather Day</param>
        /// <param name="Hour">Hour</param>
        /// <returns name="Humidity">Humidity</returns>
        /// <search>
        /// TAS, WeatherDay, Weatherday, Weather Day, Weatherday, Humidity, Weather Day Humidity, Weatherdayhumidity, humidity
        /// </search>
        public static float Humidity(WeatherDay WeatherDay, int Hour)
        {
            return WeatherDay.pWeatherDay.humidity[Hour];
        }

        /// <summary>
        /// TAS Weather Day Wind Direction
        /// </summary>
        /// <param name="WeatherDay">Weather Day</param>
        /// <param name="Hour">Hour</param>
        /// <returns name="WindDirection">Wind Direction</returns>
        /// <search>
        /// TAS, WeatherDay, Weatherday, Weather Day, Weatherday, WindDirection, Weather Day Wind Direction, Weatherdaywinddirection, Wind Direction, wind direction
        /// </search>
        public static float WindDirection(WeatherDay WeatherDay, int Hour)
        {
            return WeatherDay.pWeatherDay.windDirection[Hour];
        }

        /// <summary>
        /// TAS Weather Day Wind Speed
        /// </summary>
        /// <param name="WeatherDay">Weather Day</param>
        /// <param name="Hour">Hour</param>
        /// <returns name="WindSpeed">Wind Speed</returns>
        /// <search>
        /// TAS, WeatherDay, Weatherday, Weather Day, Weatherday, Wind Speed, Weather Day Wind Speed, Weatherdaywindspeed, WindSpeed, wind speed
        /// </search>
        public static float WindSpeed(WeatherDay WeatherDay, int Hour)
        {
            return WeatherDay.pWeatherDay.windSpeed[Hour];
        }
    }
}
