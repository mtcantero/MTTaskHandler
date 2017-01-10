using System;
namespace MT.TaskHandler.Core
{
	
	public interface ITodoItem
	{
		string ItemName { get; set; }
		string DueDate { get; set; }
		int Priority { get; set; }

	}
}
