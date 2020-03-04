using System.Web;
using System.Web.Optimization;

namespace ReportingOnline
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       
                        "~/Scripts/plugins/jquery/jquery.min.js",
                        "~/Scripts/plugins/vectormap/jquery-jvectormap-2.0.2.min.js",
                        "~/Scripts/plugins/vectormap/jvectormap-world-mill-en.js",
                        "~/Scripts/plugins/sparkline/jquery.sparkline.min.js",
                        "~/Scripts/plugins/chartist-js/dist/chartist.min.js",
                        "~/Scripts/plugins/chartist-plugin-tooltip-master/dist/chartist-plugin-tooltip.min.js",
                        "~/Scripts/javascripts/perfect-scrollbar.jquery.min.js",
                        "~/Scripts/javascripts/waves.js",
                        "~/Scripts/javascripts/sidebarmenu.js",
                        "~/Scripts/javascripts/custom.min.js",
                        "~/Scripts/javascripts/dashboard4.js",
                        "~/Scripts/plugins/styleswitcher/jQuery.style.switcher.js"));




           

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                          "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/assets/plugins/bootstrap/js/popper.min.js",
                      "~/assets/plugins/bootstrap/js/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      
                      "~/Content/css/animate.css",
                     "~/Content/css/spinners.css",
                     "~/Content/css/style.css",
                     "~/Content/css/colors/default.css",
                     "~/Content/css/colors/default-dark.css",
                     "~/Content/css/pages/dashboard4.css",
                     "~/assets/plugins/bootstrap/css/bootstrap.min.css",
                     "~/Content/css/pages/login-register-lock.css",
                     "~/Scripts/plugins/bootstrap/css/bootstrap.min.css",
                     "~/Scripts/plugins/perfect-scrollbar/dist/css/perfect-scrollbar.min.css",
                     "~/Scripts/plugins/vectormap/jquery-jvectormap-2.0.2.css",
                     "~/Scripts/plugins/chartist-js/dist/chartist.min.css",
                     "~/Scripts/plugins/chartist-plugin-tooltip-master/dist/chartist-plugin-tooltip.css"));



        }
    }
}
