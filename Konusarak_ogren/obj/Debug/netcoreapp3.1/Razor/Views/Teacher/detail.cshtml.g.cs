#pragma checksum "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dabf26fdd6a668ebcc28075d674b988d51d0918c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_detail), @"mvc.1.0.view", @"/Views/Teacher/detail.cshtml")]
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
#line 1 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml"
using Konusarak_ogren.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dabf26fdd6a668ebcc28075d674b988d51d0918c", @"/Views/Teacher/detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1aabdb70f4b9566f9fef95395639e13afd653c3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TeacherDetailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Teacher/createExam"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dabf26fdd6a668ebcc28075d674b988d51d0918c4814", async() => {
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

    <!-- Bootstrap CSS -->
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css"" integrity=""sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2"" crossorigin=""anonymous"">

    <title>Hello, world!</title>
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dabf26fdd6a668ebcc28075d674b988d51d0918c6228", async() => {
                WriteLiteral("\r\n\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dabf26fdd6a668ebcc28075d674b988d51d0918c6498", async() => {
                    WriteLiteral("\r\n        <br />\r\n        <br />\r\n        ");
#nullable restore
#line 25 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml"
   Write(Html.HiddenFor(m => m.tblArticle.ArticleTitle));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n        <h5 class=\"text-center\">  ");
#nullable restore
#line 26 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml"
                             Write(Html.DisplayTextFor(m => m.tblArticle.ArticleTitle));

#line default
#line hidden
#nullable disable
                    WriteLiteral(" </h5>\r\n\r\n        <br />\r\n        <br />\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-1\"> </div>\r\n            <div class=\"col-sm-10\">\r\n                <p style=\"text-indent:20px\">   ");
#nullable restore
#line 33 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml"
                                          Write(Html.DisplayTextFor(m => m.tblArticle.ArticleContent));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"col-sm-1\"> </div>\r\n        </div>\r\n        <br />\r\n\r\n        ");
#nullable restore
#line 39 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml"
   Write(Html.HiddenFor(m => m.tblArticle.Id));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n        <br />\r\n        <br />\r\n        <h5>SORU 1</h5>\r\n        ");
#nullable restore
#line 43 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml"
   Write(Html.TextBoxFor(m => m.question.Question1Text, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n        <br />\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-1\"><center>A</center></div>\r\n            <div class=\"col-sm-5\"> ");
#nullable restore
#line 47 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml"
                              Write(Html.TextBoxFor(m => m.question.Option1A, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n            <div class=\"col-sm-1\"><center>B</center></div>\r\n            <div class=\"col-sm-5\"> ");
#nullable restore
#line 49 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml"
                              Write(Html.TextBoxFor(m => m.question.Option1B, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-1\"><center>C</center></div>\r\n            <div class=\"col-sm-5\">");
#nullable restore
#line 53 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml"
                             Write(Html.TextBoxFor(m => m.question.Option1C, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n            <div class=\"col-sm-1\"><center>D</center></div>\r\n            <div class=\"col-sm-5\">");
#nullable restore
#line 55 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml"
                             Write(Html.TextBoxFor(m => m.question.Option1D, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n        </div>\r\n        <br />\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-3\"></div>\r\n            <div class=\"col-sm-6\">\r\n                ");
#nullable restore
#line 61 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml"
           Write(Html.DropDownListFor(m => m.question.CorrectAnswer1, (IEnumerable<SelectListItem>)ViewBag.choseList, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-sm-3\"></div>\r\n        </div>\r\n\r\n        <br />\r\n\r\n        <h5>SORU 2</h5>\r\n        ");
#nullable restore
#line 70 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml"
   Write(Html.TextBoxFor(m => m.question.Question2Text, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n        <br />\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-1\"><center>A</center></div>\r\n            <div class=\"col-sm-5\"> ");
#nullable restore
#line 74 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml"
                              Write(Html.TextBoxFor(m => m.question.Option2A, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n            <div class=\"col-sm-1\"><center>B</center></div>\r\n            <div class=\"col-sm-5\"> ");
#nullable restore
#line 76 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml"
                              Write(Html.TextBoxFor(m => m.question.Option2B, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-1\"><center>C</center></div>\r\n            <div class=\"col-sm-5\">");
#nullable restore
#line 80 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml"
                             Write(Html.TextBoxFor(m => m.question.Option2C, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n            <div class=\"col-sm-1\"><center>D</center></div>\r\n            <div class=\"col-sm-5\">");
#nullable restore
#line 82 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml"
                             Write(Html.TextBoxFor(m => m.question.Option2D, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n        </div>\r\n        <br />\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-3\"></div>\r\n            <div class=\"col-sm-6\">\r\n                ");
#nullable restore
#line 88 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml"
           Write(Html.DropDownListFor(m => m.question.CorrectAnswer2, (IEnumerable<SelectListItem>)ViewBag.choseList, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            </div>            <div class=\"col-sm-3\"></div>\r\n        </div>\r\n        <br />\r\n        <h5>SORU 3</h5>\r\n        ");
#nullable restore
#line 93 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml"
   Write(Html.TextBoxFor(m => m.question.Question3Text, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n        <br />\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-1\"><center>A</center></div>\r\n            <div class=\"col-sm-5\"> ");
#nullable restore
#line 97 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml"
                              Write(Html.TextBoxFor(m => m.question.Option3A, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n            <div class=\"col-sm-1\"><center>B</center></div>\r\n            <div class=\"col-sm-5\"> ");
#nullable restore
#line 99 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml"
                              Write(Html.TextBoxFor(m => m.question.Option3B, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-1\"><center>C</center></div>\r\n            <div class=\"col-sm-5\">");
#nullable restore
#line 103 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml"
                             Write(Html.TextBoxFor(m => m.question.Option3C, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n            <div class=\"col-sm-1\"><center>D</center></div>\r\n            <div class=\"col-sm-5\">");
#nullable restore
#line 105 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml"
                             Write(Html.TextBoxFor(m => m.question.Option3D, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n        </div>\r\n        <br />\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-3\"></div>\r\n            <div class=\"col-sm-6\">\r\n                ");
#nullable restore
#line 111 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml"
           Write(Html.DropDownListFor(m => m.question.CorrectAnswer3, (IEnumerable<SelectListItem>)ViewBag.choseList, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            </div>  <div class=\"col-sm-3\"></div>\r\n        </div>\r\n        <br />\r\n        <h5>SORU 4</h5>\r\n        ");
#nullable restore
#line 116 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml"
   Write(Html.TextBoxFor(m => m.question.Question4Text, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n        <br />\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-1\"><center>A</center></div>\r\n            <div class=\"col-sm-5\"> ");
#nullable restore
#line 120 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml"
                              Write(Html.TextBoxFor(m => m.question.Option4A, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n            <div class=\"col-sm-1\"><center>B</center></div>\r\n            <div class=\"col-sm-5\"> ");
#nullable restore
#line 122 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml"
                              Write(Html.TextBoxFor(m => m.question.Option4B, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-1\"><center>C</center></div>\r\n            <div class=\"col-sm-5\">");
#nullable restore
#line 126 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml"
                             Write(Html.TextBoxFor(m => m.question.Option4C, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n            <div class=\"col-sm-1\"><center>D</center></div>\r\n            <div class=\"col-sm-5\">");
#nullable restore
#line 128 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml"
                             Write(Html.TextBoxFor(m => m.question.Option4D, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</div>\r\n        </div>\r\n        <br />\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-3\"></div>\r\n            <div class=\"col-sm-6\">\r\n                ");
#nullable restore
#line 134 "E:\dotnet_projects\Konusarakogren\Konusarak_ogren\Konusarak_ogren\Views\Teacher\detail.cshtml"
           Write(Html.DropDownListFor(m => m.question.CorrectAnswer4, (IEnumerable<SelectListItem>)ViewBag.choseList, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            </div> <div class=\"col-sm-3\"></div>\r\n        </div>\r\n\r\n        <br />\r\n        <center>  <button type=\"submit\" class=\"btn btn-primary mb-4 \">SINAV OLUŞTUR</button></center>\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
    <script src=""https://cdn.jsdeliv");
                WriteLiteral("r.net/npm/bootstrap@4.5.3/dist/js/bootstrap.min.js\" integrity=\"sha384-w1Q4orYjBQndcko6MimVbzY0tgp4pWB4lZ7lr30WKz0vr/aWKhXdBNmNb5D92v7s\" crossorigin=\"anonymous\"></script>\r\n    -->\r\n");
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