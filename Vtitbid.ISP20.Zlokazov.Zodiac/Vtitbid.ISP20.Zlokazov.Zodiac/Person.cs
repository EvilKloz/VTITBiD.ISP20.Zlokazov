using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.Zlokazov.Zodiac
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DayOfBirth { get; set; }
        public string Zodiak { get; }

        public Person(string firstname, string lastname, DateTime dayofbirth)
        {
            FirstName = firstname;
            LastName = lastname;
            DayOfBirth = dayofbirth;
            Zodiak = Zodiac.GiveZodiak(DayOfBirth);
        }

        public override string ToString()
        {
            return $"Фамилия: {LastName}\nИмя: {FirstName}\nДата рождения: {DayOfBirth.ToShortDateString()}\nЗодиак: {Zodiak}\n";
        }
    }
}
