using OfficeEvent.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeEvent
{
	class Program
	{
		static void Main(string[] args)
		{
			IPlanner plan = new Planner();
			IOffice office = new Office();
			var monitor = new Monitor();
			office.ComeEvent += monitor.OnIncomming;
			office.GoneEvent += monitor.OnLeaving;
			plan.Planning += office.PlannerAction; 
			plan.Emulation();
			Console.ReadKey();

		}
	}
}
