using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeEvent.Classes
{
	public class Employee
	{
		public string Name { get; private set; }

		DateTime daytime = new DateTime(2016, 4, 1, 12, 0, 0);
		DateTime evening = new DateTime(2016, 4, 1, 17, 0, 0);

		public Employee(string name)
		{
			if (string.IsNullOrEmpty(name))
				throw new ArgumentException("name");
			Name = name;
		}

		public void Arriving(Employee empl)
		{
			if (DateTime.Now.CompareTo(daytime) < 0)
				Console.WriteLine("\t{0} : Доброе утро, {1}", Name, empl.Name);
			if(DateTime.Now.CompareTo(daytime) >= 0 && DateTime.Now.CompareTo(evening) < 0)
				Console.WriteLine("\t{0} : Добрый день, {1}", Name, empl.Name);
			if(DateTime.Now.CompareTo(evening) >= 0 )
				Console.WriteLine("\t{0} : Добрый вечер, {1}", Name, empl.Name);
		}

		public void Departing(Employee empl)
		{
			Console.WriteLine("\t{0} : До свидания, {1}", Name, empl.Name);
		}
	}
}
