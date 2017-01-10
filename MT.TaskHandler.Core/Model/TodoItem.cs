using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace MT.TaskHandler.Core
{
	
	public class TodoItem:ITodoItem
	{
		public TodoItem()
		{
			
		}
		public TodoItem(string _dueDate,string _itemName, int _priority)
		{
			DueDate = _dueDate;
			ItemName = _itemName;
			Priority = _priority;
			
		}

		private string dueDate;
		public string DueDate
		{
			get
			{
				return dueDate;
			}

			set
			{
				dueDate = value;
			}
		}

		private string itemName;
		public string ItemName
		{
			get
			{
				return itemName;
			}

			set
			{
				itemName = value;
			}
		}

		private int priority;
		public int Priority
		{
			get
			{
				return priority;
			}

			set
			{
				priority = value;
			}
		}
	}

	public class Rootobject
	{
		public List<TodoItem> todoItems { get; set; }
	}
}
