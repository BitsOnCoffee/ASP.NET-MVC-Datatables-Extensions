using System.Web.Mvc;
using System.Web.Routing;

namespace BitsOnCoffee.Datatables.Extensions
{
	public static class DatatablesExtensions
	{
		public static Datatable CreateDatatable(this Namespaces.Datatables datatable, string selector, string actionName, string controllerName)
		{
			return CreateDatatable(datatable, selector, actionName, controllerName, string.Empty);
		}

		public static Datatable CreateDatatable(this Namespaces.Datatables datatable, string selector, string actionName, string controllerName, string areaName, object routeParams = null)
		{
			RouteValueDictionary attributes = new RouteValueDictionary(routeParams);
			attributes.Add("area", areaName);
			var url = UrlHelper.GenerateUrl(null, actionName, controllerName, attributes, datatable.UrlHelper.RouteCollection, datatable.UrlHelper.RequestContext, true);

			return new Datatable(datatable, selector, url);
		}
	}
}
