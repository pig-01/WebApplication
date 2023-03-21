using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Extensions
{
    public static class UrlHelperExtension
    {
        public static string GetLocalUrl(this IUrlHelper urlHelper, string localUrl)
        {
            if (!urlHelper.IsLocalUrl(localUrl))
            {
                return urlHelper!.Page("/Index");
            }

            return localUrl;
        }
    }
}
