using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace DoVanSang_5951071091.Models
{
    [DataContract]
    public class MyWeatherInfo
    {
        [DataMember(Name = "lacation")]
        public string MyLocation { get; set; }

        [DataMember(Name = "degree")]
        public float MyDegree { get; set; }

        [DataMember(Name = "dateTime")]
        public DateTime MyDateTime { get; set; }
    }
}