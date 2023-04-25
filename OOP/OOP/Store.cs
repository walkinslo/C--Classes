using System;
namespace OOP
{
	class Store
	{
		private List<Chair> chairs;

		public Store()
		{
			this.chairs = new List<Chair>();
		}

		public void AddChair(Chair chair)
		{
			chairs.Add(chair);
		}

		public void RemoveChair(Chair chair)
		{
			chairs.Remove(chair);
		}

		public void PrintAllChairs(Chair chair)
		{
			foreach (var c in chairs)
			{
				c.PrintDetails();
			}
		}
	}
}

