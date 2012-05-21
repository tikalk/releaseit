using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;

namespace ReleaseIt.Web.MVC.Bundling
{
    ///http://blog.kurtschindler.net/post/disabling-bundling-and-minification-in-aspnet-45mvc-4
    
    public static class CustomJsBundle
    {
        private static bool _debug;
        const string JsTemplate = "<script src=\"{0}\"></script>";

        public static void Init()
        {
#if DEBUG
            _debug = true;
#endif
            var bundle = new Bundle("~/js/app");

            bundle.AddDirectory("~/js/app", "*.js", true, true);

            BundleTable.Bundles.Add(bundle);
        }

        public static MvcHtmlString ResolveBundleUrl(string bundleUrl)
        {
            return _debug ? UnbundledFiles(bundleUrl) : BundledFiles(BundleTable.Bundles.ResolveBundleUrl(bundleUrl));
        }

        private static MvcHtmlString BundledFiles(string bundleVirtualPath)
        {
            //TODO this does not work so we need to debug if the routs are blocking this
            return new MvcHtmlString(string.Format(JsTemplate, bundleVirtualPath));
        }

        private static MvcHtmlString UnbundledFiles(string bundleUrl)
        {
            var bundle = BundleTable.Bundles.GetBundleFor(bundleUrl);

            StringBuilder sb = new StringBuilder();
            var urlHelper = new UrlHelper(HttpContext.Current.Request.RequestContext);

            foreach (var file in bundle.EnumerateFiles(new BundleContext(new HttpContextWrapper(HttpContext.Current), new BundleCollection(), bundleUrl)))
            {
                sb.AppendFormat(JsTemplate + Environment.NewLine, urlHelper.Content(ToVirtualPath(file.FullName)));
            }

            return new MvcHtmlString(sb.ToString());
        }

        private static string ToVirtualPath(string physicalPath)
        {
            var relativePath = physicalPath.Replace(HttpContext.Current.Request.ServerVariables["APPL_PHYSICAL_PATH"], "");
            return relativePath.Replace("\\", "/").Insert(0, "~/");
        }

        public static MvcHtmlString JsBundle(this HtmlHelper helper, string bundleUrl)
        {
            return ResolveBundleUrl(bundleUrl);
        }
    }
}