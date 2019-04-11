﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [DataContract]
    public class Person
    {

        [DataMember]
        public int Id { get; set; }


        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }


        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string GUID { get; set; }
    }
}
