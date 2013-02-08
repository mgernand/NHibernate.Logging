namespace NHibernate.Logging.NLog
{
	internal static class StringExtensions
	{
		internal static string ToStringSafe(this object obj)
		{
			object aux = obj ?? string.Empty;
			return aux.ToString();
		}
	}
}