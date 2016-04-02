using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeEvent.Classes
{
	public class Planner : IPlanner 
	{
		public event PlanningHandler Planning;

		Employee[] staff =
			{
				new Employee("Иван"),
				new Employee("Пётр"),
				new Employee("Семён"),
				new Employee("Василий")
			};

		public void Emulation()
		{
			EmployeeComeEvent(staff[0], true);
			EmployeeComeEvent(staff[1], true);
			EmployeeComeEvent(staff[2], true);
			EmployeeComeEvent(staff[0], false);
			EmployeeComeEvent(staff[2], false);
			EmployeeComeEvent(staff[3], true);
			EmployeeComeEvent(staff[1], false);
			EmployeeComeEvent(staff[3], false);
		}

		protected void EmployeeComeEvent(Employee empl, bool isCommingIn)
		{
			if (Planning != null)
			{
				if (isCommingIn)
					Planning(new ActionEventArg(empl, ActionType.Come));
				else
					Planning(new ActionEventArg(empl, ActionType.Gone));
			}
			System.Threading.Thread.Sleep(10400);
        }

	}
}
