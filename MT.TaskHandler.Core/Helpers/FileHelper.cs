using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;
using Newtonsoft.Json;


namespace MT.TaskHandler.Core
{
	
	//Class that will help me save records to a CSV File in a folder.
	public class FileHelper
	{
		IDataHelper fileservice;
		string filename;
		public FileHelper(IDataHelper _fileservice, string _filename)
		{
			fileservice = _fileservice;
			filename = _filename;
		}

		public void addNewItem(string name, string dueDate, int priority)
		{
			var items = retrieveItems();
			items.Add(new TodoItem(dueDate, name, priority));
			var newJson = JsonConvert.SerializeObject(items, Formatting.Indented);
			fileservice.SaveTodoAsync(filename, newJson);

		}


		public List<TodoItem> retrieveItems()
		{
			return fileservice.LoadTodosAsync(filename);

		}



	}
}
