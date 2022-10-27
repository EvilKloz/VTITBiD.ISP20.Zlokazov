using Vtitbid.ISP20.Zlokazov.Zodiac;
using static Vtitbid.ISP20.Zlokazov.Zodiac.Delegates;

List<Person> person = new List<Person>();
Del writer = DelegateMethod;
int count = 2;

Zodiac.Inicialize(ref person, count);

Zodiac.SortDate(ref person);
writer("Введите знак зодиака для поиска");
Zodiac.FindZodiak(person, Console.ReadLine());
writer("Введите название файла");
string title = Console.ReadLine();
for (int i = 0; i < person.Count; i++)
{
    File.AppendAllText(@$"C:\Users\student\Desktop\{title}.txt", $"{person[i]}\n");
}
