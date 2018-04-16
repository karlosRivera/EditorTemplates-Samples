using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EditorTemplateSample.Models
{
    public class StudentListViewModel
    {
        public List<SelectListItem> Countries { get; set; }
        public IList<Student> Students { get; set; }
        public List<Sex> Sex { get; set; }

        public StudentListViewModel()
        {
            Students = new List<Student>
            {
                new Student
                {
                    ID=1,Name="Keith",CountryID="0",SexID="F",
                    Hobbies= new List<Hobby>
                    {
                        new Hobby{ID=1,Name="Football",Checked=true},
                        new Hobby{ID=2,Name="Hocky",Checked=false},
                        new Hobby{ID=3,Name="Cricket",Checked=false}
                    }
        
                },

                new Student
                {
                    ID=2,Name="Paul",CountryID="2",
                    Hobbies= new List<Hobby>
                    {
                        new Hobby{ID=1,Name="Football",Checked=false},
                        new Hobby{ID=2,Name="Hocky",Checked=true},
                        new Hobby{ID=3,Name="Cricket",Checked=false}
                    }
                },

                new Student
                {
                    ID=3,Name="Sam",CountryID="3",
                    Hobbies= new List<Hobby>
                    {
                        new Hobby{ID=1,Name="Football",Checked=false},
                        new Hobby{ID=2,Name="Hocky",Checked=false},
                        new Hobby{ID=3,Name="Cricket",Checked=true}
                    }
                }
            };
        }

        public List<Sex> GetSex()
        {
            Sex = new List<Sex>
            {
                new Sex{ID="M",SexName="Male"},
                new Sex{ID="F",SexName="Female"}
            };

            return Sex;
        }

        public List<SelectListItem> GetCountries()
        {
            Countries = new List<SelectListItem>
            {
                new SelectListItem{Value="1",Text="India"},
                new SelectListItem{Value="2",Text="UK"},
                new SelectListItem{Value="3",Text="USA"}
            };

            return Countries;
        }
    }
}