using System;
using System.Collections.Generic;
using MT.TaskHandler.Core;
using Xamarin.Forms;

namespace MT.TaskHandler
{
	public partial class TodoMain : ContentPage
	{
		public TodoMain()
		{
			InitializeComponent();

			BindingContext = new TodoMainViewModel(DependencyService.Get<IDataHelper>());
		}
	}
}
