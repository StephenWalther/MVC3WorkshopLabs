using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections;
using System.Text;

namespace CustomDatagridHelper.Helpers
{
    public static class GridHelper
    {        

        public static MvcHtmlString CustomGrid(this HtmlHelper htmlHelper, String Id, IList Items, IList<string> Attributes)
        {

            if (Items == null || Items.Count == 0 || string.IsNullOrEmpty(Id))
                return MvcHtmlString.Empty;

            return BuildGrid(Items, Id, Attributes);

        }

        public static MvcHtmlString BuildGrid(IList Items, string Id, IList<string> attributes)
        {
            StringBuilder sb = new StringBuilder();
            BuildHeader(sb, Items[0].GetType());

            foreach (var item in Items)
            {
                BuildTableRow(sb, item);
            }

            TagBuilder builder = new TagBuilder("table");           
            builder.MergeAttribute("name", Id);
            builder.InnerHtml = sb.ToString();
            var Tag = builder.ToString(TagRenderMode.Normal);
            return MvcHtmlString.Create(Tag);
        }

        public static void BuildTableRow(StringBuilder sb, object obj)
        {
            Type objType = obj.GetType();
            sb.AppendLine("\t<tr>");           
                sb.AppendFormat("\t\t<td>{0}</td>\n", obj);            
            sb.AppendLine("\t</tr>");
        }

        public static void BuildHeader(StringBuilder row, Type p)
        {
            row.AppendLine("\t<tr>");           
                row.AppendFormat("\t\t<th>{0}</th>\n", p.Name);           
            row.AppendLine("\t</tr>");
        }
    }
}