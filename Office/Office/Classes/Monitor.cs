using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeEvent.Classes
{
	class Monitor
	{
		public void OnIncomming(Employee empl)
		{
			Console.WriteLine("\n[На часах, {0},   {1} пришёл в офис]", DateTime.Now.ToShortTimeString(), empl.Name);
		}
		public void OnLeaving(Employee empl)
		{
			Console.WriteLine("\n[На часах {0},   {1} ушёл домой]", DateTime.Now.ToShortTimeString(), empl.Name);
		}

	}
}
