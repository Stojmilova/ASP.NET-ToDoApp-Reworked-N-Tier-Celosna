#pragma checksum "C:\Users\Stojmilova\Desktop\KONECNA\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\DoneTasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cb4fc0c42094ac1775026925320d9077449c5ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_DoneTasks), @"mvc.1.0.view", @"/Views/Task/DoneTasks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Task/DoneTasks.cshtml", typeof(AspNetCore.Views_Task_DoneTasks))]
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
#line 1 "C:\Users\Stojmilova\Desktop\KONECNA\ToDoApp.Reworked\ToDoApp.WebApp\Views\_ViewImports.cshtml"
using ToDoApp.WebApp;

#line default
#line hidden
#line 2 "C:\Users\Stojmilova\Desktop\KONECNA\ToDoApp.Reworked\ToDoApp.WebApp\Views\_ViewImports.cshtml"
using ToDoApp.WebApp.Models;

#line default
#line hidden
#line 3 "C:\Users\Stojmilova\Desktop\KONECNA\ToDoApp.Reworked\ToDoApp.WebApp\Views\_ViewImports.cshtml"
using ToDoApp.Domain.Models;

#line default
#line hidden
#line 4 "C:\Users\Stojmilova\Desktop\KONECNA\ToDoApp.Reworked\ToDoApp.WebApp\Views\_ViewImports.cshtml"
using ToDoApp.Domain.Enums;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cb4fc0c42094ac1775026925320d9077449c5ff", @"/Views/Task/DoneTasks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"598b743e2b34c8c3c99520b14e78fb6cbc082dec", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_DoneTasks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoTaskViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Stojmilova\Desktop\KONECNA\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\DoneTasks.cshtml"
  
    ViewBag.Title = "DoneTasks";

#line default
#line hidden
            BeginContext(67, 26, true);
            WriteLiteral("\r\n<h1 style=\"color:green\">");
            EndContext();
            BeginContext(94, 13, false);
#line 6 "C:\Users\Stojmilova\Desktop\KONECNA\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\DoneTasks.cshtml"
                   Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(107, 614, true);
            WriteLiteral(@"</h1>
<br />
<div class=""jumbotron"">
    <table style=""border:5px  double grey; width:100%; margin-bottom:10px; padding:5px"">
        <thead>
            <tr>
                <th style=""border:1px solid black"">Title</th>
                <th style=""border:1px solid black"">Description</th>
                <th style=""border:1px solid black"">Priority </th>
                <th style=""border:1px solid black"">Status</th>
                <th style=""border:1px solid black"">TaskType</th>
                <th style=""border:1px solid black"">SubTasks</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 21 "C:\Users\Stojmilova\Desktop\KONECNA\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\DoneTasks.cshtml"
             foreach (var task in Model.Tasks)
            {

#line default
#line hidden
            BeginContext(784, 77, true);
            WriteLiteral("                <tr>\r\n                    <td style=\"border:1px solid black\">");
            EndContext();
            BeginContext(862, 10, false);
#line 24 "C:\Users\Stojmilova\Desktop\KONECNA\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\DoneTasks.cshtml"
                                                  Write(task.Title);

#line default
#line hidden
            EndContext();
            BeginContext(872, 62, true);
            WriteLiteral("</td>\r\n                    <td style=\"border:1px solid black\">");
            EndContext();
            BeginContext(935, 16, false);
#line 25 "C:\Users\Stojmilova\Desktop\KONECNA\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\DoneTasks.cshtml"
                                                  Write(task.Description);

#line default
#line hidden
            EndContext();
            BeginContext(951, 62, true);
            WriteLiteral("</td>\r\n                    <td style=\"border:1px solid black\">");
            EndContext();
            BeginContext(1014, 13, false);
#line 26 "C:\Users\Stojmilova\Desktop\KONECNA\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\DoneTasks.cshtml"
                                                  Write(task.Priority);

#line default
#line hidden
            EndContext();
            BeginContext(1027, 62, true);
            WriteLiteral("</td>\r\n                    <td style=\"border:1px solid black\">");
            EndContext();
            BeginContext(1090, 11, false);
#line 27 "C:\Users\Stojmilova\Desktop\KONECNA\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\DoneTasks.cshtml"
                                                  Write(task.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1101, 62, true);
            WriteLiteral("</td>\r\n                    <td style=\"border:1px solid black\">");
            EndContext();
            BeginContext(1164, 13, false);
#line 28 "C:\Users\Stojmilova\Desktop\KONECNA\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\DoneTasks.cshtml"
                                                  Write(task.TaskType);

#line default
#line hidden
            EndContext();
            BeginContext(1177, 94, true);
            WriteLiteral("</td>\r\n                    <td style=\"border:1px solid black\">\r\n                        <ul>\r\n");
            EndContext();
#line 31 "C:\Users\Stojmilova\Desktop\KONECNA\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\DoneTasks.cshtml"
                             foreach (var subTask in task.SubTasks)
                            {

#line default
#line hidden
            BeginContext(1371, 43, true);
            WriteLiteral("                                <li>Title: ");
            EndContext();
            BeginContext(1415, 13, false);
#line 33 "C:\Users\Stojmilova\Desktop\KONECNA\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\DoneTasks.cshtml"
                                      Write(subTask.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1428, 17, true);
            WriteLiteral(" => Description: ");
            EndContext();
            BeginContext(1446, 19, false);
#line 33 "C:\Users\Stojmilova\Desktop\KONECNA\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\DoneTasks.cshtml"
                                                                     Write(subTask.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1465, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 34 "C:\Users\Stojmilova\Desktop\KONECNA\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\DoneTasks.cshtml"
                            }

#line default
#line hidden
            BeginContext(1503, 128, true);
            WriteLiteral("                        </ul>\r\n                    </td>\r\n                    <td><button type=\"button\" class=\"btn btn-success\">");
            EndContext();
            BeginContext(1632, 76, false);
#line 37 "C:\Users\Stojmilova\Desktop\KONECNA\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\DoneTasks.cshtml"
                                                                 Write(Html.ActionLink("View DETAILS", "DetailsTask", "Task", new { id = task.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1708, 39, true);
            WriteLiteral("</button></td>\r\n                </tr>\r\n");
            EndContext();
#line 39 "C:\Users\Stojmilova\Desktop\KONECNA\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\DoneTasks.cshtml"
            }

#line default
#line hidden
            BeginContext(1762, 40, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoTaskViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
