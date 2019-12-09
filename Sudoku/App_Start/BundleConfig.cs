using System.Web;
using System.Web.Optimization;

namespace Sudoku
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-2.2.3.min.js",
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/fastclick.js",
                        "~/Scripts/app.min.js",
                        "~/Scripts/jquery.validate.min.js",
                        "~/Scripts/jquery.validate.unobtrusive.min.js",
                        "~/Scripts/adminlte.js",
                        "~/Scripts/bootstrap-datepicker.js",
                        "~/Scripts/jquery.dataTables.min.js",
                        "~/Scripts/dataTables.bootstrap.min.js",
                        "~/Scripts/bootstrap-multiselect.min.js",
                        "~/Scripts/jquery.bootstrap-duallistbox.min.js",
                        "~/Scripts/demo.js",
                        "~/Scripts/Common.js"));


            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate.min.js",
                        "~/Scripts/jquery.validate.unobtrusive.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/AdminLTE.min.css",
                      "~/Content/datepicker3.css",
                      "~/Content/dataTables.bootstrap.css",
                      "~/Content/jquery.dataTables.min.css",
                      "~/Content/Site.css",
                      "~/Content/bootstrap-multiselect.min.css",
                      "~/Content/bootstrap-duallistbox.min.css",
                      "~/Content/_all-skins.min.css"));
            
        }
    }
}
