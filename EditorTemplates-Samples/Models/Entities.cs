using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EditorTemplateSample.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string CountryID { get; set; }
        public string SexID { get; set; }
        public IList<Hobby> Hobbies { get; set; }

    }

    //public class Country
    //{
    //    public string ID { get; set; }
    //    public string Name { get; set; }
    //}

    public class Hobby
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Checked { get; set; }
    }

    public class Sex
    {
        public string ID { get; set; }
        public string SexName { get; set; }
    }
}