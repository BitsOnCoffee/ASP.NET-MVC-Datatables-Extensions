using System.Web.Mvc;

namespace BitsOnCoffee.Datatables.Extensions.Namespaces
{
	public static class NamespaceExtensions
	{
		#region Datatables (extension method making @Url.Datatables()...)
		public static Datatables Datatables(this UrlHelper helper)
		{
			return new Datatables(helper);
		}
		#endregion
	}
}
