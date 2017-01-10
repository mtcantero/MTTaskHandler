using NUnit.Framework;
using System;

using MT.TaskHandler.Core;

namespace MT.TaskHandle.Core.Tests
{
	[TestFixture()]
	public class FileHelperTests
	{
		IDataHelper mockFileService = new DataHelperMock();
		[Test()]
		public void RetrieveItemsTest()
		{
			//Arrange



			FileHelper helper = new FileHelper(mockFileService,"test.txt");
			//Act
			var result = helper.retrieveItems();
			//Assert
			Assert.IsTrue(result.Count != 0);
			Assert.IsTrue(result[0].GetType().Equals(typeof(TodoItem)));
		}

		[Test()]
		public void AddNewItemTest()
		{
			//Arrange
			FileHelper helper = new FileHelper(mockFileService, "text.txt");
			//Act
			helper.addNewItem("Ir a ver a Lola", "2016-12-23", 3);
			//Assert
			Assert.IsTrue(helper.retrieveItems().Count == 4);
		}
	}
}
