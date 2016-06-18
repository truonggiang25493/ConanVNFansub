using System.Web;
using System.Web.Optimization;

namespace MVCBlog.Website
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts")
                .Include(
                    "~/Scripts/jquery-{version}.js",
                    "~/Scripts/jquery.validate*",
                    "~/Scripts/bootstrap.js",
                    "~/Scripts/jquery.lightbox.js",
                    "~/Scripts/jquery.autocomplete.pack.js",
                    "~/Scripts/SyntaxHighlighter/shCore.js",
                    "~/Scripts/SyntaxHighlighter/shAutoloader.js",
                    "~/Scripts/respond.js",
                    "~/Scripts/custom.js"));

            bundles.Add(new StyleBundle("~/css/combined")
                .Include(
                    "~/Content/bootstrap.css",
                    "~/Content/custom.css",
                    "~/Content/lightbox.css",
                    "~/Content/jquery.autocomplete.css",
                    "~/Content/shCoreDefault.css"));

            bundles.Add(new StyleBundle("~/css/rebound")
                .Include(
                    "~/Content/rebound/bootstrap.css",
                    "~/Content/rebound/font-awesome.css",
                    "~/Content/rebound/style.css"));

            bundles.Add(new ScriptBundle("~/scripts/rebound")
                .Include(
                    "~/Scripts/rebound/rebound.js",
                    "~/Scripts/rebound/jquery.isotope.min.js",
                    "~/Scripts/rebound/bootstrap.js"));
        }
    }
}
