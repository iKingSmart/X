﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    
    #line 1 "..\..\Views\Shared\_Ace_Layout.cshtml"
    using NewLife.Common;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Ace_Layout.cshtml")]
    public partial class _Views_Shared__Ace_Layout_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Ace_Layout_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Shared\_Ace_Layout.cshtml"
  
    var menu = ManageProvider.Menu.Current;
    var set = NewLife.Cube.Setting.Current;

            
            #line default
            #line hidden
WriteLiteral("\r\n<!DOCTYPE html>\r\n<html");

WriteLiteral(" lang=\"zh-CN\"");

WriteLiteral(">\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" http-equiv=\"X-UA-Compatible\"");

WriteLiteral(" content=\"IE=edge\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"description\"");

WriteLiteral(" content=\"新生命团队,NewLife,魔方,Cube,XCode\"");

WriteLiteral(" />\r\n    ");

WriteLiteral("\r\n    <title>");

            
            #line 14 "..\..\Views\Shared\_Ace_Layout.cshtml"
      Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 14 "..\..\Views\Shared\_Ace_Layout.cshtml"
                       Write(SysConfig.Current.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 522), Tuple.Create("\"", 542)
, Tuple.Create(Tuple.Create("", 529), Tuple.Create<System.Object, System.Int32>(Href("~/favicon.ico")
, 529), false)
);

WriteLiteral(" rel=\"shortcut icon\"");

WriteLiteral(" type=\"image/x-icon\"");

WriteLiteral(">\r\n\r\n    <!-- 页面内联样式 -->\r\n");

WriteLiteral("    ");

            
            #line 18 "..\..\Views\Shared\_Ace_Layout.cshtml"
Write(RenderSection("css", required: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 20 "..\..\Views\Shared\_Ace_Layout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Shared\_Ace_Layout.cshtml"
     if (set.BootstrapSelect)
    {

            
            #line default
            #line hidden
WriteLiteral("        <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 723), Tuple.Create("\"", 779)
, Tuple.Create(Tuple.Create("", 730), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/css/bootstrap-multiselect.css")
, 730), false)
);

WriteLiteral(">\r\n");

            
            #line 23 "..\..\Views\Shared\_Ace_Layout.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 818), Tuple.Create("\"", 882)
, Tuple.Create(Tuple.Create("", 825), Tuple.Create<System.Object, System.Int32>(Href("~/Content/DateTimePicker/bootstrap-datetimepicker.min.css")
, 825), false)
);

WriteLiteral(">\r\n\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 914), Tuple.Create("\"", 972)
, Tuple.Create(Tuple.Create("", 921), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap-switch/bootstrap-switch.min.css")
, 921), false)
);

WriteLiteral(">\r\n\r\n    <!-- 最后引入基本样式 -->\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1027), Tuple.Create("\"", 1075)
, Tuple.Create(Tuple.Create("", 1034), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/css/bootstrap.min.css")
, 1034), false)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1105), Tuple.Create("\"", 1156)
, Tuple.Create(Tuple.Create("", 1112), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/css/font-awesome.min.css")
, 1112), false)
);

WriteLiteral(">\r\n\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1188), Tuple.Create("\"", 1242)
, Tuple.Create(Tuple.Create("", 1195), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/css/bootstrap-theme.min.css")
, 1195), false)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1272), Tuple.Create("\"", 1331)
, Tuple.Create(Tuple.Create("", 1279), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/css/bootstrap-responsive.min.css")
, 1279), false)
);

WriteLiteral(">\r\n\r\n    <!-- 文本字体 -->\r\n    ");

WriteLiteral("\r\n    <!-- ace 样式 -->\r\n    ");

WriteLiteral("\r\n\r\n    <!-- 自定义样式 -->\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1619), Tuple.Create("\"", 1644)
, Tuple.Create(Tuple.Create("", 1626), Tuple.Create<System.Object, System.Int32>(Href("~/Content/Cube.css")
, 1626), false)
);

WriteLiteral(">\r\n    <!-- JQuery作为一等公民，页面内部随时可能使用 -->\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1697), Tuple.Create("\"", 1735)
, Tuple.Create(Tuple.Create("", 1703), Tuple.Create<System.Object, System.Int32>(Href("~/Content/js/jquery-2.1.3.min.js")
, 1703), false)
);

WriteLiteral("></script>\r\n</head>\r\n<body>\r\n    <div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"breadcrumbs\"");

WriteLiteral(" id=\"breadcrumbs\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 50 "..\..\Views\Shared\_Ace_Layout.cshtml"
           Write(Html.Partial("_Ace_Layout_Nav"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </ul>\r\n            <div");

WriteLiteral(" style=\"float: right; margin-left: 40px;\"");

WriteLiteral(">");

            
            #line 52 "..\..\Views\Shared\_Ace_Layout.cshtml"
                                                     Write(ViewBag.HeaderContent);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"page-content\"");

WriteLiteral(">\r\n            <section");

WriteLiteral(" class=\"content-wrapper main-content clear-fix\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 56 "..\..\Views\Shared\_Ace_Layout.cshtml"
           Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n            </section>\r\n        </div>\r\n");

            
            #line 59 "..\..\Views\Shared\_Ace_Layout.cshtml"
        
            
            #line default
            #line hidden
            
            #line 59 "..\..\Views\Shared\_Ace_Layout.cshtml"
         if (DbRunTimeModule.Enable)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"panel-footer\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 62 "..\..\Views\Shared\_Ace_Layout.cshtml"
           Write(Html.Raw(DbRunTimeModule.GetInfo()));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 64 "..\..\Views\Shared\_Ace_Layout.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n    <!-- 最早引入基本脚本 -->\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2463), Tuple.Create("\"", 2508)
, Tuple.Create(Tuple.Create("", 2469), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/js/bootstrap.min.js")
, 2469), false)
);

WriteLiteral("></script>\r\n");

            
            #line 68 "..\..\Views\Shared\_Ace_Layout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 68 "..\..\Views\Shared\_Ace_Layout.cshtml"
     if (set.BootstrapSelect)
    {

            
            #line default
            #line hidden
WriteLiteral("        <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2574), Tuple.Create("\"", 2631)
, Tuple.Create(Tuple.Create("", 2580), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/js/bootstrap-multiselect.min.js")
, 2580), false)
);

WriteLiteral("></script>\r\n");

            
            #line 71 "..\..\Views\Shared\_Ace_Layout.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 73 "..\..\Views\Shared\_Ace_Layout.cshtml"
Write(RenderSection("scripts", required: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <!--日历控件支持-->\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2733), Tuple.Create("\"", 2795)
, Tuple.Create(Tuple.Create("", 2739), Tuple.Create<System.Object, System.Int32>(Href("~/Content/DateTimePicker/bootstrap-datetimepicker.min.js")
, 2739), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2819), Tuple.Create("\"", 2891)
, Tuple.Create(Tuple.Create("", 2825), Tuple.Create<System.Object, System.Int32>(Href("~/Content/DateTimePicker/locales/bootstrap-datetimepicker.zh-CN.js")
, 2825), false)
);

WriteLiteral(@"></script>
    <script>
        $(function () {
            $('.form_datetime').each(function () {
                var df = $(this).attr('dateformat');
                if (!df) {
                    $(this).attr('dateformat', 'yyyy-mm-dd hh:ii:ss');
                    $(this).width(140);
                }
                else {
                    // 把C#标准格式化替换为控件格式
                    df = df.replace('mm', 'ii').replace('MM', 'mm').replace('HH', 'hh');
                    $(this).attr('dateformat', df);

                    // 根据时间日期格式，锁定日期输入框宽度
                    if (df.indexOf('hh') >= 0)
                        $(this).width(140);
                    else
                        $(this).width(80);
                }
            });
            $(""[dateformat]"").each(function () {
                $(this).datetimepicker({
                    format: $(this).attr(""dateformat""),
                    autoclose: true,
                    language: ""zh-CN"",
                    forceParse: false,
                    startView: 2,
                    minView: 2
                });
            });
");

            
            #line 108 "..\..\Views\Shared\_Ace_Layout.cshtml"
            
            
            #line default
            #line hidden
            
            #line 108 "..\..\Views\Shared\_Ace_Layout.cshtml"
             if (set.BootstrapSelect) {
            
            #line default
            #line hidden
WriteLiteral(@"
            $('.multiselect').each(function () {
                $(this).multiselect({
                    // 下拉列表仅在列表项比较多时显示过滤框
                    enableFiltering: $(this).children().length > 10,
                    buttonClass: 'btn btn-white btn-primary',
                    templates: {
                        button: '<button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"multiselect dropdown-toggle\"");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteLiteral("></button>\',\r\n                        ul: \'<ul");

WriteLiteral(" class=\"multiselect-container dropdown-menu\"");

WriteLiteral("></ul>\',\r\n                        filter: \'<li");

WriteLiteral(" class=\"multiselect-item filter\"");

WriteLiteral("><div");

WriteLiteral(" class=\"input-group\"");

WriteLiteral("><span");

WriteLiteral(" class=\"input-group-addon\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-search\"");

WriteLiteral("></i></span><input");

WriteLiteral(" class=\"form-control multiselect-search\"");

WriteLiteral(" type=\"text\"");

WriteLiteral("></div></li>\',\r\n                        filterClearBtn: \'<span");

WriteLiteral(" class=\"input-group-btn\"");

WriteLiteral("><button");

WriteLiteral(" class=\"btn btn-default btn-white btn-grey multiselect-clear-filter\"");

WriteLiteral(" type=\"button\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-times-circle red2\"");

WriteLiteral("></i></button></span>\',\r\n                        li: \'<li><a");

WriteLiteral(" href=\"javascript:void(0);\"");

WriteLiteral("><label></label></a></li>\',\r\n                        divider: \'<li");

WriteLiteral(" class=\"multiselect-item divider\"");

WriteLiteral("></li>\',\r\n                        liGroup: \'<li");

WriteLiteral(" class=\"multiselect-item group\"");

WriteLiteral("><label");

WriteLiteral(" class=\"multiselect-group\"");

WriteLiteral("></label></li>\'\r\n                    },\r\n                    filterPlaceholder: \'" +
"搜索\',\r\n                    nonSelectedText: \'无\',\r\n                    allSelected" +
"Text: \'全选\'\r\n                });\r\n            });\r\n            ");

            
            #line 128 "..\..\Views\Shared\_Ace_Layout.cshtml"
                   }
            
            
            #line default
            #line hidden
            
            #line 131 "..\..\Views\Shared\_Ace_Layout.cshtml"
                                                                                        

            
            #line default
            #line hidden
WriteLiteral(@"            $('tr').dblclick(function () {
                var $this = $(this);
                var row = $this.closest(""tr"");
                var findcell = row.find('.editcell');
                if (findcell.length > 0) window.location.href = findcell.attr(""href"");
            });
        });
    </script>

    <!--开关插件-->
    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 6054), Tuple.Create("\"", 6110)
, Tuple.Create(Tuple.Create("", 6060), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap-switch/bootstrap-switch.min.js")
, 6060), false)
);

WriteLiteral("></script>\r\n    <script>\r\n        $(function () {\r\n            $(\"input[type=chec" +
"kbox]\").bootstrapSwitch();\r\n        })\r\n    </script>\r\n\r\n    ");

WriteLiteral("\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 6281), Tuple.Create("\"", 6304)
, Tuple.Create(Tuple.Create("", 6287), Tuple.Create<System.Object, System.Int32>(Href("~/Content/Cube.js")
, 6287), false)
);

WriteLiteral("></script>\r\n</body>\r\n</html>");

        }
    }
}
#pragma warning restore 1591
