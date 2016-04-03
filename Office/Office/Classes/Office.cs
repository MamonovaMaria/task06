using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeEvent.Classes
{
	class Office : IOffice
	{
		private List<Employee> allEmployee = new List<Employee>();

		public event ComeHandler ComeEvent;
		public event GoneHandler GoneEvent;


		public void AddEmployeeToOffice(Employee empl)
		{
			if (allEmployee.Contains(empl))
				return;
			allEmployee.Add(empl);
			OnComeEvent(empl);
			this.ComeEvent += empl.Arriving;
			this.GoneEvent += empl.Departing;
		}

		public List<Employee> GetAllPresentingEmployee()
		{
			return allEmployee;
		}

		public void PlannerAction(ActionEventArg arg)
		{
			if (arg.ActionType == ActionType.Come)
				AddEmployeeToOffice(arg.Employee);
			if (arg.ActionType == ActionType.Gone)
				RemoveEmployeeFromOffice(arg.Employee);
		}

		public void RemoveEmployeeFromOffice(Employee empl)
		{
			if (!allEmployee.Contains(empl))
				return;
			this.ComeEvent -= empl.Arriving;
			this.GoneEvent -= empl.Departing;
			allEmployee.Remove(empl);
			OnGoneEvent(empl);
		}

		protected void OnComeEvent(Employee Employee)
		{
			var e = ComeEvent;
			if (e != null)
				e(Employee);
		}
		protected void OnGoneEvent(Employee Employee)
		{
			var e = GoneEvent;
			if (e != null)
				e(Employee);
		}
	}
}
