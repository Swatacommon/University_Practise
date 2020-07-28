using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVC_architecture.Models
{
    public class Phone
    {
        public int Id { get; set; }
        [DisplayName("Фамилия")]
        public string Last_name { get; set; }
        [DisplayName("Номер телефона")]
        public string Phone_number { get; set; }
    }
}