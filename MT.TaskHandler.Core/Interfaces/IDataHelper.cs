using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MT.TaskHandler.Core
{
	public interface IDataHelper
	{
		//List<TodoItem> retrieveItems();
		//void addNewItem(string name, string dueDate, int priority);

		bool SaveTodoAsync(string filename, string text);
		List<TodoItem> LoadTodosAsync(string filename);
		bool FileExists(string filename);


	}
}
