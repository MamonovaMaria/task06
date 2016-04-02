using OfficeEvent.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeEvent
{
	public delegate void PlanningHandler(ActionEventArg arg);
	public interface IPlanner
	{
		event PlanningHandler Planning;

		void Emulation();
	}
}
