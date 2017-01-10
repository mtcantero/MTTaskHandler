using System;
using Xamarin.Forms;
using MT.TaskHandler.iOS;
using System.IO;
using System.Threading.Tasks;
using MT.TaskHandler.Core;
using Foundation;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

[assembly: Dependency(typeof(IDataHelper))]
namespace MT.TaskHandler.iOS
{
	
	public class FileHelper: IDataHelper
	{
		public static string DocumentsPath
		{
			get
			{
				var documentsDirUrl = NSFileManager.DefaultManager.GetUrls(NSSearchPathDirectory.DocumentDirectory, NSSearchPathDomain.User).Last();
				return documentsDirUrl.Path;
			}
		}

		static string CreatePathToFile(string fileName)
		{
			return Path.Combine(DocumentsPath, fileName);
		}

		public bool SaveTodoAsync(string filename, string text)
		{
			string path = CreatePathToFile(filename);

			try
			{
				using (var sw = new StreamWriter(path))
				{
					sw.WriteAsync(text);
				}
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}

				
		}

		public List<TodoItem> LoadTodosAsync(string filename)
		{
			if (filename != null)
			{
				System.Diagnostics.Debug.WriteLine("Filename is not null opening reader");
				Rootobject rootobject;

				string path = CreatePathToFile(filename);


				using (var reader = File.OpenText(path))
				{
					var json = reader.ReadToEnd();
					rootobject = JsonConvert.DeserializeObject<Rootobject>(json);

				}
				return  rootobject.todoItems;

			}
			System.Diagnostics.Debug.WriteLine("Stream was null");
			return null;
		}

		public bool FileExists(string filename)
		{
			return File.Exists(CreatePathToFile(filename));
		}
	}
}
