namespace LoggingExample
{
	using System;
	using System.Collections.Generic;
	using System.Collections.Specialized;
	using Common.Logging;
	using Common.Logging.NLog;
	using NHibernate;
	using NHibernate.Cfg;

	public static class Program
	{
		public static void Main()
		{
			NameValueCollection properties = new NameValueCollection();
			properties["configType"] = "FILE";
			properties["configFile"] = "~/NLog.config";
			LogManager.Adapter = new NLogLoggerFactoryAdapter(properties);

			Configuration cfg = new Configuration();
			cfg.Configure("NHibernate.config");
			ISessionFactory sessionFactory = cfg.BuildSessionFactory();
			ISession session = sessionFactory.OpenSession();

			Customer entity = new Customer
			{
				FirstName = "Hans",
				LastName = "Moleman",
				Comment = "Blind guy."
			};
			session.SaveOrUpdate(entity);

			ICriteria criteria = session.CreateCriteria<Customer>();
			IList<Customer> customers = criteria.List<Customer>();

			foreach (Customer customer in customers)
			{
				Console.WriteLine(customer);
			}

			Console.ReadKey();
		}
	}
}
