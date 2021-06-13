﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace WeatherApp.Models
{
    class Weather
    {
        public Object getWeatherForcast()
        {
            string appid = "5ae2f0d776e07770827b7ae3d1274372";
            string url = "http://api.openweathermap.org/data/2.5/weather?q=Cleveland&APPID=" + appid + "&units=metric";
            //synchronous client.
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }

    }
}