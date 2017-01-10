using System;
using System.Collections.Generic;
using MT.TaskHandler.Core;

namespace MT.TaskHandle.Core.Tests
{
	//TODO Implement this Mock
	public class DataHelperMock:IDataHelper
	{
		public DataHelperMock()
		{
		}

		public bool FileExists(string filename)
		{
			throw new NotImplementedException();
		}

		public List<TodoItem> LoadTodosAsync(string filename)
		{
			throw new NotImplementedException();
		}

		public bool SaveTodoAsync(string filename, string text)
		{
			throw new NotImplementedException();
		}
	}
}
