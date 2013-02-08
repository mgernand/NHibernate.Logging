namespace LoggingExample
{
	public class Customer
	{
		public virtual long Id { get; protected set; }
		public virtual string FirstName { get; set; }
		public virtual string LastName { get; set; }
		public virtual string Comment { get; set; }

		public override string ToString()
		{
			return string.Format("FistName: {0}, LastName: {1}, Comment: {2}",
				this.FirstName, this.LastName, this.Comment);
		}
	}
}
