#pragma checksum "C:\Users\Phuong\source\repos\UserSolution\User.UI\Views\User\DeleteUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4eeebefb850dd63f6f11a08edc5b15e4f25aa7e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_DeleteUser), @"mvc.1.0.view", @"/Views/User/DeleteUser.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Phuong\source\repos\UserSolution\User.UI\Views\_ViewImports.cshtml"
using User.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Phuong\source\repos\UserSolution\User.UI\Views\_ViewImports.cshtml"
using User.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eeebefb850dd63f6f11a08edc5b15e4f25aa7e3", @"/Views/User/DeleteUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8aa0cdd312ef9671dbaea577fbe7f911259bb34c", @"/Views/_ViewImports.cshtml")]
    public class Views_User_DeleteUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User.App.ViewModel.GetUserVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Phuong\source\repos\UserSolution\User.UI\Views\User\DeleteUser.cshtml"
  
    ViewBag.Title = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>MonAn</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 15 "C:\Users\Phuong\source\repos\UserSolution\User.UI\Views\User\DeleteUser.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 19 "C:\Users\Phuong\source\repos\UserSolution\User.UI\Views\User\DeleteUser.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 23 "C:\Users\Phuong\source\repos\UserSolution\User.UI\Views\User\DeleteUser.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 27 "C:\Users\Phuong\source\repos\UserSolution\User.UI\Views\User\DeleteUser.cshtml"
       Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n\r\n");
#nullable restore
#line 32 "C:\Users\Phuong\source\repos\UserSolution\User.UI\Views\User\DeleteUser.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Phuong\source\repos\UserSolution\User.UI\Views\User\DeleteUser.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-actions no-color\">\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n            ");
#nullable restore
#line 38 "C:\Users\Phuong\source\repos\UserSolution\User.UI\Views\User\DeleteUser.cshtml"
       Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 40 "C:\Users\Phuong\source\repos\UserSolution\User.UI\Views\User\DeleteUser.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User.App.ViewModel.GetUserVM> Html { get; private set; }
    }
}
#pragma warning restore 1591