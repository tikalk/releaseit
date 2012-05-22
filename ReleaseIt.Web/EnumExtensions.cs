using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReleaseIt.Web
{
    public static class EnumExtensions
    {
        public static IEnumerable<SelectListItem> GetSelectListItem<T>() 
        {
            return System.Enum.GetValues(typeof(T)).Cast<T>().Select(x =>
                new SelectListItem
                {
                    Text = x.ToString(),
                    Value = Convert.ToInt32(x).ToString(),
                }

            );


        }
    }
}