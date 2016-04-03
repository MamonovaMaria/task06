using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeEvent.Classes
{
	public enum ActionType
	{
		Come,
		Gone
	}
	public class ActionEventArg
	{
		public Employee Employee { get; private set; }
		public ActionType ActionType { get; private set; }
		public ActionEventArg(Employee empl, ActionType actionType)
		{
			Employee = empl;
			ActionType = actionType;
		}
	}
}
