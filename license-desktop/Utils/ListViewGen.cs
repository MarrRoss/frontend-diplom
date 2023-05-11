using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace license_desktop.Utils
{
    internal static class ListViewGen
    {
        /// <summary>
        /// TAKE CARE
        /// <br/>THIS IS REFLECTION
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static ListViewItem GetLV<T>(this T t) where T : class
        {
            var item = new List<string>();
            foreach (var prop in typeof(T).GetProperties())
            {
                item.Add(prop.GetValue(t).ToString());
            }
            return new ListViewItem(item.ToArray());
        }
    }
}
