#pragma checksum "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f6e3828a408481f9bcb8bd21808c884f0709053"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_student_Index), @"mvc.1.0.view", @"/Views/student/Index.cshtml")]
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
#line 1 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\_ViewImports.cshtml"
using Konusarak_ogren;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml"
using Konusarak_ogren.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f6e3828a408481f9bcb8bd21808c884f0709053", @"/Views/student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1aabdb70f4b9566f9fef95395639e13afd653c3a", @"/Views/_ViewImports.cshtml")]
    public class Views_student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TeacherDetailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f6e3828a408481f9bcb8bd21808c884f07090534148", async() => {
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <!-- Bootstrap CSS -->
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css"" integrity=""sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2"" crossorigin=""anonymous"">

    <title>Öğrenci</title>

    <script>
        $(document).ready(function () {
            $('#LblOption1A').click(function () {
                //Change the label text here
                $('#LblOption1A').css({ ""background-color"": ""yellow"" });
                $('#LblOption1B').css({ ""background-color"": ""white"" });
                $('#LblOption1C').css({ ""background-color"": ""white"" });
                $('#LblOption1D').css({ ""background-color"": ""white"" });
                return false;
            });

    ");
                WriteLiteral(@"        $('#LblOption1B').click(function () {
                //Change the label text here
                $('#LblOption1A').css({ ""background-color"": ""white"" });
                $('#LblOption1B').css({ ""background-color"": ""yellow"" });
                $('#LblOption1C').css({ ""background-color"": ""white"" });
                $('#LblOption1D').css({ ""background-color"": ""white"" });
                return false;
            });

            $('#LblOption1C').click(function () {
                //Change the label text here
                $('#LblOption1A').css({ ""background-color"": ""white"" });
                $('#LblOption1B').css({ ""background-color"": ""white"" });
                $('#LblOption1C').css({ ""background-color"": ""yellow"" });
                $('#LblOption1D').css({ ""background-color"": ""white"" });
                return false;
            });

            $('#LblOption1D').click(function () {
                //Change the label text here
                $('#LblOption1A').css({ ""background");
                WriteLiteral(@"-color"": ""white"" });
                $('#LblOption1B').css({ ""background-color"": ""white"" });
                $('#LblOption1C').css({ ""background-color"": ""white"" });
                $('#LblOption1D').css({ ""background-color"": ""yellow"" });
                return false;
            });

            $('#LblOption2A').click(function () {
                //Change the label text here
                $('#LblOption2A').css({ ""background-color"": ""yellow"" });
                $('#LblOption2B').css({ ""background-color"": ""white"" });
                $('#LblOption2C').css({ ""background-color"": ""white"" });
                $('#LblOption2D').css({ ""background-color"": ""white"" });
                return false;
            });

            $('#LblOption2B').click(function () {
                //Change the label text here
                $('#LblOption2A').css({ ""background-color"": ""white"" });
                $('#LblOption2B').css({ ""background-color"": ""yellow"" });
                $('#LblOption2C').css({ ""backgro");
                WriteLiteral(@"und-color"": ""white"" });
                $('#LblOption2D').css({ ""background-color"": ""white"" });
                return false;
            });

            $('#LblOption2C').click(function () {
                //Change the label text here
                $('#LblOption2A').css({ ""background-color"": ""white"" });
                $('#LblOption2B').css({ ""background-color"": ""white"" });
                $('#LblOption2C').css({ ""background-color"": ""yellow"" });
                $('#LblOption2D').css({ ""background-color"": ""white"" });
                return false;
            });

            $('#LblOption2D').click(function () {
                //Change the label text here
                $('#LblOption2A').css({ ""background-color"": ""white"" });
                $('#LblOption2B').css({ ""background-color"": ""white"" });
                $('#LblOption2C').css({ ""background-color"": ""white"" });
                $('#LblOption2D').css({ ""background-color"": ""yellow"" });
                return false;
            });");
                WriteLiteral(@"



            $('#LblOption3A').click(function () {
                //Change the label text here
                $('#LblOption3A').css({ ""background-color"": ""yellow"" });
                $('#LblOption3B').css({ ""background-color"": ""white"" });
                $('#LblOption3C').css({ ""background-color"": ""white"" });
                $('#LblOption3D').css({ ""background-color"": ""white"" });
                return false;
            });

            $('#LblOption3B').click(function () {
                //Change the label text here
                $('#LblOption3A').css({ ""background-color"": ""white"" });
                $('#LblOption3B').css({ ""background-color"": ""yellow"" });
                $('#LblOption3C').css({ ""background-color"": ""white"" });
                $('#LblOption3D').css({ ""background-color"": ""white"" });
                return false;
            });

            $('#LblOption3C').click(function () {
                //Change the label text here
                $('#LblOption3A').css({");
                WriteLiteral(@" ""background-color"": ""white"" });
                $('#LblOption3B').css({ ""background-color"": ""white"" });
                $('#LblOption3C').css({ ""background-color"": ""yellow"" });
                $('#LblOption3D').css({ ""background-color"": ""white"" });
                return false;
            });

            $('#LblOption3D').click(function () {
                //Change the label text here
                $('#LblOption3A').css({ ""background-color"": ""white"" });
                $('#LblOption3B').css({ ""background-color"": ""white"" });
                $('#LblOption3C').css({ ""background-color"": ""white"" });
                $('#LblOption3D').css({ ""background-color"": ""yellow"" });
                return false;
            });




            $('#LblOption4A').click(function () {
                //Change the label text here
                $('#LblOption4A').css({ ""background-color"": ""yellow"" });
                $('#LblOption4B').css({ ""background-color"": ""white"" });
                $('#LblOption4");
                WriteLiteral(@"C').css({ ""background-color"": ""white"" });
                $('#LblOption4D').css({ ""background-color"": ""white"" });
                return false;
            });

            $('#LblOption4B').click(function () {
                //Change the label text here
                $('#LblOption4A').css({ ""background-color"": ""white"" });
                $('#LblOption4B').css({ ""background-color"": ""yellow"" });
                $('#LblOption4C').css({ ""background-color"": ""white"" });
                $('#LblOption4D').css({ ""background-color"": ""white"" });
                return false;
            });

            $('#LblOption4C').click(function () {
                //Change the label text here
                $('#LblOption4A').css({ ""background-color"": ""white"" });
                $('#LblOption4B').css({ ""background-color"": ""white"" });
                $('#LblOption4C').css({ ""background-color"": ""yellow"" });
                $('#LblOption4D').css({ ""background-color"": ""white"" });
                return false");
                WriteLiteral(@";
            });

            $('#LblOption4D').click(function () {
                //Change the label text here
                $('#LblOption4A').css({ ""background-color"": ""white"" });
                $('#LblOption4B').css({ ""background-color"": ""white"" });
                $('#LblOption4C').css({ ""background-color"": ""white"" });
                $('#LblOption4D').css({ ""background-color"": ""yellow"" });
                return false;
            });


            $('#completeExam').click(function () {
                var question1Val = $('#Question1CorectAnswer').val();
                var question1Va2 = $('#Question2CorectAnswer').val();
                var question1Va3 = $('#Question3CorectAnswer').val();
                var question1Va4 = $('#Question4CorectAnswer').val();

                var question1AColor = $('#LblOption1A').css(""background-color"");
                var question1BColor = $('#LblOption1B').css(""background-color"");
                var question1CColor = $('#LblOption1C').cs");
                WriteLiteral(@"s(""background-color"");
                var question1DColor = $('#LblOption1D').css(""background-color"");
                debugger;
                if (question1AColor == 'yellow') {
                    if (question1Val == 'A') {
                        $('#LblOption1A').css({ ""background-color"": ""green"" });
                    }
                    else {
                        $('#LblOption1A').css({ ""background-color"": ""red"" });
                    }
                }

                //if (question1Val == 'D') {
                //    var question1Color = $('#LblOption1D').css(""background-color"");
                //    if (question1Color == 'yellow') {
                //        $('#LblOption1D').css({ ""background-color"": ""green"" });
                //    }
                //    else {
                //        $('#LblOption1D').css({ ""background-color"": ""red"" });
                //    }
                //}
               

                return false;
            });
        });
 ");
                WriteLiteral("   </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f6e3828a408481f9bcb8bd21808c884f070905314964", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f6e3828a408481f9bcb8bd21808c884f070905315227", async() => {
                    WriteLiteral("\r\n        <br />\r\n        <br />\r\n        ");
#nullable restore
#line 210 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml"
   Write(Html.HiddenFor(m => m.tblArticle.ArticleTitle));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n        <h5 class=\"text-center\">  ");
#nullable restore
#line 211 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml"
                             Write(Html.DisplayTextFor(m => m.tblArticle.ArticleTitle));

#line default
#line hidden
#nullable disable
                    WriteLiteral(" </h5>\r\n\r\n        <br />\r\n        <br />\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-1\"> </div>\r\n            <div class=\"col-sm-10\">\r\n                <p style=\"text-indent:20px\">   ");
#nullable restore
#line 218 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml"
                                          Write(Html.DisplayTextFor(m => m.tblArticle.ArticleContent));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"col-sm-1\"> </div>\r\n        </div>\r\n        <br />\r\n\r\n        ");
#nullable restore
#line 224 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml"
   Write(Html.HiddenFor(m => m.tblArticle.Id));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n        <br />\r\n        <br />\r\n        <h5>SORU 1</h5>\r\n        ");
#nullable restore
#line 228 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml"
   Write(Html.TextBoxFor(m => m.question.Question1Text, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n        <br />\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-1\"><center>A</center></div>\r\n                <div class=\"col-sm-5\"> ");
#nullable restore
#line 232 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml"
                                  Write(Html.LabelFor(m => m.question.Option1A, new { @class = "form-control", @id = "LblOption1A" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n                <div class=\"col-sm-1\"><center>B</center></div>\r\n                <div class=\"col-sm-5\"> ");
#nullable restore
#line 234 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml"
                                  Write(Html.LabelFor(m => m.question.Option1B, new { @class = "form-control", @id = "LblOption1B" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-1\"><center>C</center></div>\r\n                <div class=\"col-sm-5\">");
#nullable restore
#line 238 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml"
                                 Write(Html.LabelFor(m => m.question.Option1C, new { @class = "form-control", @id = "LblOption1C" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n                <div class=\"col-sm-1\"><center>D</center></div>\r\n                <div class=\"col-sm-5\">");
#nullable restore
#line 240 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml"
                                 Write(Html.LabelFor(m => m.question.Option1D, new { @class = "form-control", @id = "LblOption1D" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n            </div>\r\n\r\n            <br />\r\n\r\n            <h5>SORU 2</h5>\r\n            ");
#nullable restore
#line 246 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml"
       Write(Html.TextBoxFor(m => m.question.Question2Text, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            <br />\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-1\"><center>A</center></div>\r\n                <div class=\"col-sm-5\"> ");
#nullable restore
#line 250 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml"
                                  Write(Html.LabelFor(m => m.question.Option2A, new { @class = "form-control", @id = "LblOption2A" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n                <div class=\"col-sm-1\"><center>B</center></div>\r\n                <div class=\"col-sm-5\"> ");
#nullable restore
#line 252 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml"
                                  Write(Html.LabelFor(m => m.question.Option2B, new { @class = "form-control", @id = "LblOption2B" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-1\"><center>C</center></div>\r\n                <div class=\"col-sm-5\">");
#nullable restore
#line 256 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml"
                                 Write(Html.LabelFor(m => m.question.Option2C, new { @class = "form-control", @id = "LblOption2C" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n                <div class=\"col-sm-1\"><center>D</center></div>\r\n                <div class=\"col-sm-5\">");
#nullable restore
#line 258 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml"
                                 Write(Html.LabelFor(m => m.question.Option2D, new { @class = "form-control", @id = "LblOption2D" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n            </div>\r\n\r\n            <br />\r\n            <h5>SORU 3</h5>\r\n            ");
#nullable restore
#line 263 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml"
       Write(Html.TextBoxFor(m => m.question.Question3Text, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            <br />\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-1\"><center>A</center></div>\r\n                <div class=\"col-sm-5\"> ");
#nullable restore
#line 267 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml"
                                  Write(Html.LabelFor(m => m.question.Option3A, new { @class = "form-control", @id = "LblOption3A" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n                <div class=\"col-sm-1\"><center>B</center></div>\r\n                <div class=\"col-sm-5\"> ");
#nullable restore
#line 269 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml"
                                  Write(Html.LabelFor(m => m.question.Option3B, new { @class = "form-control", @id = "LblOption3B" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n                ");
#nullable restore
#line 270 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml"
           Write(Html.HiddenFor(m => m.question.CorrectAnswer4, new { @id = "Question1CorectAnswer" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-1\"><center>C</center></div>\r\n                <div class=\"col-sm-5\">");
#nullable restore
#line 274 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml"
                                 Write(Html.LabelFor(m => m.question.Option3C, new { @class = "form-control", @id = "LblOption3C" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n                <div class=\"col-sm-1\"><center>D</center></div>\r\n                <div class=\"col-sm-5\">");
#nullable restore
#line 276 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml"
                                 Write(Html.LabelFor(m => m.question.Option3D, new { @class = "form-control", @id = "LblOption3D" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n                ");
#nullable restore
#line 277 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml"
           Write(Html.HiddenFor(m => m.question.CorrectAnswer4, new { @id = "Question2CorectAnswer" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            </div>\r\n\r\n            <br />\r\n            <h5>SORU 4</h5>\r\n            ");
#nullable restore
#line 282 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml"
       Write(Html.TextBoxFor(m => m.question.Question4Text, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            <br />\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-1\"><center>A</center></div>\r\n                <div class=\"col-sm-5\"> ");
#nullable restore
#line 286 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml"
                                  Write(Html.LabelFor(m => m.question.Option4A, new { @class = "form-control", @id = "LblOption4A" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n                <div class=\"col-sm-1\"><center>B</center></div>\r\n                <div class=\"col-sm-5\"> ");
#nullable restore
#line 288 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml"
                                  Write(Html.LabelFor(m => m.question.Option4B, new { @class = "form-control", @id = "LblOption4B" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n                ");
#nullable restore
#line 289 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml"
           Write(Html.HiddenFor(m => m.question.CorrectAnswer4, new { @id = "Question3CorectAnswer" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-1\"><center>C</center></div>\r\n                <div class=\"col-sm-5\">");
#nullable restore
#line 293 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml"
                                 Write(Html.LabelFor(m => m.question.Option4C, new { @class = "form-control", @id = "LblOption4C" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n                <div class=\"col-sm-1\"><center>D</center></div>\r\n                <div class=\"col-sm-5\">");
#nullable restore
#line 295 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml"
                                 Write(Html.LabelFor(m => m.question.Option4D, new { @class = "form-control", @id = "LblOption4D" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n                ");
#nullable restore
#line 296 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\student\Index.cshtml"
           Write(Html.HiddenFor(m => m.question.CorrectAnswer4 , new { @id="Question4CorectAnswer"}));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            </div>\r\n\r\n            <br />\r\n            <center>  <button type=\"button\" id=\"completeExam\" class=\"btn btn-primary mb-4 \">SINAVI TAMAMLA</button></center>\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"


    <!-- Optional JavaScript; choose one of the two! -->
    <!-- Option 1: jQuery and Bootstrap Bundle (includes Popper) -->
    <script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js"" integrity=""sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-ho+j7jyWK8fNQe+A12Hb8AhRq26LrZ/JpcUGGOn+Y7RsweNrtN/tE3MoK7ZeZDyx"" crossorigin=""anonymous""></script>


    <!-- Option 2: jQuery, Popper.js, and Bootstrap JS
    <script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js"" integrity=""sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"" integrity=""sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.");
                WriteLiteral("net/npm/bootstrap@4.5.3/dist/js/bootstrap.min.js\" integrity=\"sha384-w1Q4orYjBQndcko6MimVbzY0tgp4pWB4lZ7lr30WKz0vr/aWKhXdBNmNb5D92v7s\" crossorigin=\"anonymous\"></script>\r\n    -->\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeacherDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
