using System;
using System.ComponentModel;

namespace MT.TaskHandler.Core
{
	public class TodoMainViewModel:INotifyPropertyChanged
	{
		IDataHelper fileService;
		public TodoMainViewModel(IDataHelper _fileService)
		{
			fileService = _fileService;
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
