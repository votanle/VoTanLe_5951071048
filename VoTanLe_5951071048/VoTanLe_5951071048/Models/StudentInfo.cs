using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace VoTanLe_5951071048.Models
{
    [DataContract]
    public class StudentInfo
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }
        [DataMember(Name = "Age")]
        public int Age { get; set; }
        [DataMember(Name = "Student_code")]
        public string Student_code { get; set; }
    }
}