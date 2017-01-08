using System.Web;
using System.Web.Optimization;

namespace ParelloZmorge
{
    public class BundleConfig
    {
        // Weitere Informationen zu Bundling finden Sie unter "http://go.microsoft.com/fwlink/?LinkId=301862"
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Verwenden Sie die Entwicklungsversion von Modernizr zum Entwickeln und Erweitern Ihrer Kenntnisse. Wenn Sie dann
            // für die Produktion bereit sind, verwenden Sie das Buildtool unter "http://modernizr.com", um nur die benötigten Tests auszuwählen.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

			bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
			"~/Scripts/kendo/2016.3.914/kendo.all.min.js",
			// "~/Scripts/kendo/kendo.timezones.min.js", // uncomment if using the Scheduler
			"~/Scripts/kendo/2016.3.914/kendo.aspnetmvc.min.js"));

			bundles.Add(new StyleBundle("~/Content/kendo/css").Include(
				"~/Content/kendo/2016.3.914/kendo.common.min.css",
				"~/Content/kendo/2016.3.914/kendo.office365.min.css"));

			bundles.IgnoreList.Clear();
		}
    }
}
