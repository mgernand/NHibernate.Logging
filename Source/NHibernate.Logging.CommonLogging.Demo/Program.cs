namespace NHibernate.Logging.CommonLogging.Demo
{
	using System;
	using System.Collections.Generic;
	using Common.Logging;
	using Common.Logging.Configuration;
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

			Console.WriteLine();
			Console.WriteLine("-------------------------------------------------");
			INHibernateLogger logger = NHibernateLogger.For("Demo");

			logger.Debug("Single Message");
			logger.Debug("Formatted Message {0}", 1);
			logger.Debug(new Exception("Exception"), "Exception Message");
			logger.Debug(new Exception("Exception"), "Formatted Exception Message {0}", 1);

			logger.Info("Single Message");
			logger.Info("Formatted Message {0}", 1);
			logger.Info(new Exception("Exception"), "Exception Message");
			logger.Info(new Exception("Exception"), "Formatted Exception Message {0}", 1);

			logger.Warn("Single Message");
			logger.Warn("Formatted Message {0}", 1);
			logger.Warn(new Exception("Exception"), "Exception Message");
			logger.Warn(new Exception("Exception"), "Formatted Exception Message {0}", 1);

			logger.Error("Single Message");
			logger.Error("Formatted Message {0}", 1);
			logger.Error(new Exception("Exception"), "Exception Message");
			logger.Error(new Exception("Exception"), "Formatted Exception Message {0}", 1);

			logger.Fatal("Single Message");
			logger.Fatal("Formatted Message {0}", 1);
			logger.Fatal(new Exception("Exception"), "Exception Message");
			logger.Fatal(new Exception("Exception"), "Formatted Exception Message {0}", 1);

			Console.WriteLine("-------------------------------------------------");

			Console.WriteLine();
			Console.WriteLine("Press any key to quit...");
			Console.ReadKey();
		}
	}
}
