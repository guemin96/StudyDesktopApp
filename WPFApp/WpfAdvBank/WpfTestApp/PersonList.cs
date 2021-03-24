using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestApp
{
    public class PersonList : ObservableCollection<Person> //List<Person>//   //List<Person> //ObservableCollection과 큰 차이는 없다.
    {
        public PersonList()
        {
            this.Add(new Person("Willa", "Cather"));
            this.Add(new Person("Isak", "Dinesen"));
            this.Add(new Person("Victor", "Hugo"));
            this.Add(new Person("Park", "Gyumin"));

        }
    }
}
