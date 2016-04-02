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

		public void Emulation()
		{
			Employee[] staff =
			{
				new Employee("Иван"),
				new Employee("Пётр"),
				new Employee("Семён"),
				new Employee("Василий")
			};

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
			var e = Planning;
			if (e != null)
				e(new ActionEventArg(empl, isCommingIn ? ActionType.Come : ActionType.Gone));
			System.Threading.Thread.Sleep(10500);

        }

	}
}
