#pragma checksum "D:\Users\pbiradar\source\repos\TaskManagementProject\Views\Task\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86f70c9712303f4780f5591c029fbc56df01fe6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_Edit), @"mvc.1.0.view", @"/Views/Task/Edit.cshtml")]
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
#line 1 "D:\Users\pbiradar\source\repos\TaskManagementProject\Views\_ViewImports.cshtml"
using TaskManagementProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\pbiradar\source\repos\TaskManagementProject\Views\_ViewImports.cshtml"
using TaskManagementProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86f70c9712303f4780f5591c029fbc56df01fe6b", @"/Views/Task/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1478d89f4a483cd4e888f1775abf7d376a7f796e", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaskManagementProject.Models.Task>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n");
#nullable restore
#line 6 "D:\Users\pbiradar\source\repos\TaskManagementProject\Views\Task\Edit.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <style>
        td {
            text-align: left;
            width:200px;
        }
       table{
           border-width:20px;
           margin-left: auto;
           margin-right: auto;
       }
        .head {
            text-align: Center;
        }
    </style>
");
            WriteLiteral("    <div class=\"head\"><h3>Update Task</h3></div>\r\n          <table>\r\n             <tr>\r\n                  <td> \r\n                      ");
#nullable restore
#line 27 "D:\Users\pbiradar\source\repos\TaskManagementProject\Views\Task\Edit.cshtml"
                 Write(Html.LabelFor(t => t.TaskId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </td>\r\n                  <td>\r\n                      ");
#nullable restore
#line 30 "D:\Users\pbiradar\source\repos\TaskManagementProject\Views\Task\Edit.cshtml"
                 Write(Html.HiddenFor(t => t.TaskId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                  </td>\r\n               </tr>\r\n\r\n              <tr>\r\n                  <td>\r\n                      ");
#nullable restore
#line 37 "D:\Users\pbiradar\source\repos\TaskManagementProject\Views\Task\Edit.cshtml"
                 Write(Html.LabelFor(t => t.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </td>\r\n                  <td> \r\n                      ");
#nullable restore
#line 40 "D:\Users\pbiradar\source\repos\TaskManagementProject\Views\Task\Edit.cshtml"
                 Write(Html.TextBoxFor(t => t.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                  </td>\r\n              </tr>\r\n\r\n              <tr>\r\n                  <td>\r\n                      ");
#nullable restore
#line 46 "D:\Users\pbiradar\source\repos\TaskManagementProject\Views\Task\Edit.cshtml"
                 Write(Html.LabelFor(t => t.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </td>\r\n                  <td>  \r\n                      ");
#nullable restore
#line 49 "D:\Users\pbiradar\source\repos\TaskManagementProject\Views\Task\Edit.cshtml"
                 Write(Html.TextAreaFor(t => t.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                  </td>\r\n              </tr>\r\n\r\n              <tr>\r\n                  <td>\r\n                      ");
#nullable restore
#line 55 "D:\Users\pbiradar\source\repos\TaskManagementProject\Views\Task\Edit.cshtml"
                 Write(Html.LabelFor(t => t.Assignee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </td>\r\n                  <td> \r\n                       ");
#nullable restore
#line 58 "D:\Users\pbiradar\source\repos\TaskManagementProject\Views\Task\Edit.cshtml"
                  Write(Html.TextBoxFor(t => t.Assignee));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                  </td>\r\n              </tr>\r\n\r\n              <tr>\r\n                  <td>\r\n                      ");
#nullable restore
#line 64 "D:\Users\pbiradar\source\repos\TaskManagementProject\Views\Task\Edit.cshtml"
                 Write(Html.LabelFor(t => t.Due_Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </td>\r\n                  <td>  \r\n                      ");
#nullable restore
#line 67 "D:\Users\pbiradar\source\repos\TaskManagementProject\Views\Task\Edit.cshtml"
                 Write(Html.TextBoxFor(t => t.Due_Date));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                  </td>\r\n              </tr>\r\n\r\n              <tr>\r\n                  <td> </td>\r\n                  <td><input type=\"submit\" /> </td>\r\n              </tr>\r\n          </table>\r\n");
#nullable restore
#line 76 "D:\Users\pbiradar\source\repos\TaskManagementProject\Views\Task\Edit.cshtml"
 
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TaskManagementProject.Models.Task> Html { get; private set; }
    }
}
#pragma warning restore 1591
