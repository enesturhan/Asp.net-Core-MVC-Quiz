#pragma checksum "C:\Users\TULPAR\source\repos\sınav\sınav\Views\Listeleme\GetQuestion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "766477731419de343f93b5b2dd6c6faf882aca81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Listeleme_GetQuestion), @"mvc.1.0.view", @"/Views/Listeleme/GetQuestion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Listeleme/GetQuestion.cshtml", typeof(AspNetCore.Views_Listeleme_GetQuestion))]
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
#line 1 "C:\Users\TULPAR\source\repos\sınav\sınav\Views\_ViewImports.cshtml"
using sınav;

#line default
#line hidden
#line 2 "C:\Users\TULPAR\source\repos\sınav\sınav\Views\_ViewImports.cshtml"
using sınav.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"766477731419de343f93b5b2dd6c6faf882aca81", @"/Views/Listeleme/GetQuestion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2f6c272c147c0913d260505bb210e4d01d2f43b", @"/Views/_ViewImports.cshtml")]
    public class Views_Listeleme_GetQuestion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sınav.Data.Model.Question>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\TULPAR\source\repos\sınav\sınav\Views\Listeleme\GetQuestion.cshtml"
  
    ViewData["Title"] = "GetQuestion";

#line default
#line hidden
            BeginContext(81, 2063, true);
            WriteLiteral(@"

<div id=""clear-alt3lu"">
    <div id=""alt2li"">
        <div id=""2lisol""></div>
        <div id=""2lisag""></div>
    </div>
    <div id=""clear-alt2li""></div>
    <div id=""footer></div>
    #clear-alt3lu {
    clear: both;
    }

    #alt2li {
    height: 300px;
    width: 980px;
    margin-top: 10px;
    }

    #2lisol {
    float: left;
    height: 280px;
    width: 310px;
    border: 1px solid #000;
    }

    #2lisag {
    height: 280px;
    width: 643px;
    border: 1px solid #000;
    float: left;
    margin-left: 22px;
    }





    -












    <script>
        $(""#Button1"").click(function () {
            if (QueIdAndAnswer.length != 4) {
                $(""#answerAlert"").show();
            }
            else {
                $(""#answerAlert"").hide(function () {
                    var data = QueIdAndAnswer.toString();

                    $.ajax({
                        url: ""//CheckAnswer"" + ""?QueIdAndAnswer="" + data + ""&questionID");
            WriteLiteral(@"="" + questionID,
                        type: ""GET"",
                        dataType: ""json"",
                        contentType: ""application/json"",
                        success: function (answer) {
                            var jsonObj = $.parseJSON(answer);

                            $.each(jsonObj, function (i, item) {
                                console.log(item.IsTrue)
                                if (item.IsTrue)
                                    $(""#"" + item.QuestionId.toString() + item.TrueAnswer.toString()).css('background-color', '#009900');
                                else
                                    $(""#"" + item.QuestionId.toString() + item.TrueAnswer.toString()).css('background-color', '#FF0000');

                            })
                        },
                        error: function () {
                            alert(""Hata.."");
                        }
                    });


                });
            }
        });
");
            WriteLiteral("    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sınav.Data.Model.Question> Html { get; private set; }
    }
}
#pragma warning restore 1591
