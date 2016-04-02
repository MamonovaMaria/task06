using OfficeEvent.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeEvent
{
	public delegate void ComeHandler(Employee empl);
	public delegate void GoneHandler(Employee empl);

	public interface IOffice
	{
		event ComeHandler ComeEvent;
		event GoneHandler GoneEvent;

		void AddEmployeeToOffice(Employee empl);
		void RemoveEmployeeFromOffice(Employee empl);
		List<Employee> GetAllPresentingEmployee();

		void PlannerAction(ActionEventArg arg);
	}
}
