#pragma checksum "C:\Users\Dimitris Selal\source\repos\SensorFusion\SensorFusion\Views\Home\NewOperation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1640442a15e598a7f46b040d0c647cad1b7c3663"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_NewOperation), @"mvc.1.0.view", @"/Views/Home/NewOperation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/NewOperation.cshtml", typeof(AspNetCore.Views_Home_NewOperation))]
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
#line 1 "C:\Users\Dimitris Selal\source\repos\SensorFusion\SensorFusion\Views\_ViewImports.cshtml"
using SensorFusion;

#line default
#line hidden
#line 2 "C:\Users\Dimitris Selal\source\repos\SensorFusion\SensorFusion\Views\_ViewImports.cshtml"
using SensorFusion.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1640442a15e598a7f46b040d0c647cad1b7c3663", @"/Views/Home/NewOperation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"944d1a9742005bc582025e03bac29fce319c9f03", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_NewOperation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SensorFusion.ViewModels.NewOperationFormModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("videoFiles"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "file", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "videoFiles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("audioFiles"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "audioFiles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("well form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewOperation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return validateForm();"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("NewOperationForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Dimitris Selal\source\repos\SensorFusion\SensorFusion\Views\Home\NewOperation.cshtml"
  
	ViewData["Title"] = "Add new Operation";

#line default
#line hidden
            BeginContext(106, 32, true);
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n\r\n\t");
            EndContext();
            BeginContext(138, 4317, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c164cbfa44ff406691a989ce43910b11", async() => {
                BeginContext(321, 385, true);
                WriteLiteral(@"
		<fieldset>

			<!-- Form Name -->
			<legend>Register a new Operation</legend>

			<!-- Select hospital -->

			<div class=""form-group"">
				<label class=""col-md-4 control-label"">Select Hospital</label>
				<div class=""col-md-4 selectContainer"">
					<div class=""input-group"">
						<span class=""input-group-addon""><i class=""glyphicon glyphicon-plus""></i></span>
						");
                EndContext();
                BeginContext(707, 179, false);
#line 23 "C:\Users\Dimitris Selal\source\repos\SensorFusion\SensorFusion\Views\Home\NewOperation.cshtml"
                   Write(Html.DropDownListFor(m => m.hospitalID, Model.hospitals,"Select a hospital...", new { id = "HospitalDropDown", @class = "form-control selectpicker", @onchange = "UpdateRooms()" }));

#line default
#line hidden
                EndContext();
                BeginContext(886, 330, true);
                WriteLiteral(@"
					</div>
				</div>
			</div>
			<!-- Select Room -->

			<div class=""form-group"">
				<label class=""col-md-4 control-label"">Operating Room</label>
				<div class=""col-md-4 selectContainer"">
					<div class=""input-group"">
						<span class=""input-group-addon""><i class=""glyphicon glyphicon-home""></i></span>
							");
                EndContext();
                BeginContext(1217, 115, false);
#line 34 "C:\Users\Dimitris Selal\source\repos\SensorFusion\SensorFusion\Views\Home\NewOperation.cshtml"
                       Write(Html.DropDownListFor(m => m.roomNo, Model.rooms, new { id = "RoomDropDown", @class = "form-control selectpicker" }));

#line default
#line hidden
                EndContext();
                BeginContext(1332, 340, true);
                WriteLiteral(@"
					</div>
				</div>
			</div>


			<!-- Select patient -->

			<div class=""form-group"">
				<label class=""col-md-4 control-label"">Select Patient</label>
				<div class=""col-md-4 selectContainer"">
					<div class=""input-group"">
						<span class=""input-group-addon""><i class=""glyphicon glyphicon-user""></i></span>


						");
                EndContext();
                BeginContext(1673, 147, false);
#line 49 "C:\Users\Dimitris Selal\source\repos\SensorFusion\SensorFusion\Views\Home\NewOperation.cshtml"
                   Write(Html.DropDownListFor(m => m.patientID, Model.patients, "Select a patient...", new { id = "PatientDropDown", @class = "form-control selectpicker" }));

#line default
#line hidden
                EndContext();
                BeginContext(1820, 332, true);
                WriteLiteral(@"
					</div>
				</div>
			</div>


			<!-- Select staff -->

			<div class=""form-group"">
				<label class=""col-md-4 control-label"">Select Staff</label>
				<div class=""col-md-7 selectContainer"">
					<div class=""input-group"">
						<span class=""input-group-addon""><i class=""glyphicon glyphicon-user""></i></span>
						");
                EndContext();
                BeginContext(2153, 111, false);
#line 62 "C:\Users\Dimitris Selal\source\repos\SensorFusion\SensorFusion\Views\Home\NewOperation.cshtml"
                   Write(Html.DropDownListFor(model => model.staffIDs, Model.staff, new { id = "StaffDropDown", multiple = "multiple" }));

#line default
#line hidden
                EndContext();
                BeginContext(2264, 347, true);
                WriteLiteral(@"
					</div>
				</div>
			</div>

			<!-- Select type of operation -->

			<div class=""form-group"">
				<label class=""col-md-4 control-label"">Type of Operation</label>
				<div class=""col-md-4 selectContainer"">
					<div class=""input-group"">
						<span class=""input-group-addon""><i class=""glyphicon glyphicon-list""></i></span>
						");
                EndContext();
                BeginContext(2612, 167, false);
#line 74 "C:\Users\Dimitris Selal\source\repos\SensorFusion\SensorFusion\Views\Home\NewOperation.cshtml"
                   Write(Html.DropDownListFor(m => m.operationTypeID, Model.typesOfOperation, "Select the operation type...", new { id = "TypeDropDown", @class = "form-control selectpicker" }));

#line default
#line hidden
                EndContext();
                BeginContext(2779, 361, true);
                WriteLiteral(@"
					</div>
				</div>
			</div>






			<!-- Video files upload-->
			<div class=""form-group"">
				<label class=""col-md-4 control-label"">Upload the video files</label>
				<div class=""col-md-2 inputGroupContainer"">
					<div class=""input-group"">
						<span class=""input-group-addon""><i class=""glyphicon glyphicon-upload""></i></span>

						");
                EndContext();
                BeginContext(3140, 85, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2cc4f4eb294244f1a99f6ca3fbb77d57", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 91 "C:\Users\Dimitris Selal\source\repos\SensorFusion\SensorFusion\Views\Home\NewOperation.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.videoFiles);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("multiple", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3225, 351, true);
                WriteLiteral(@"
					</div>
				</div>
			</div>

			<!-- Audio files upload-->
			<div class=""form-group"">
				<label class=""col-md-4 control-label"">Upload the audio files</label>
				<div class=""col-md-2 inputGroupContainer"">
					<div class=""input-group"">
						<span class=""input-group-addon""><i class=""glyphicon glyphicon-upload""></i></span>

						");
                EndContext();
                BeginContext(3576, 85, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5fc846ae17b24efbb866bba002aa6715", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 103 "C:\Users\Dimitris Selal\source\repos\SensorFusion\SensorFusion\Views\Home\NewOperation.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.audioFiles);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("multiple", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3661, 787, true);
                WriteLiteral(@"
					</div>
				</div>
			</div>

			<!-- Patients monitoring system upload-->
			<div class=""form-group"">
				<label class=""col-md-4 control-label"">Upload the patients monitoring system file</label>
				<div class=""col-md-2 inputGroupContainer"">
					<div class=""input-group"">
						<span class=""input-group-addon""><i class=""glyphicon glyphicon-upload""></i></span>

						<input id=""monitor"" type=""file"" name=""monitor"" multiple />
					</div>
				</div>
			</div>

			<!-- Submit Button -->
			<div class=""form-group"">
				<label class=""col-md-4 control-label""></label>
				<div class=""col-md-4"">
					<button type=""submit"" class=""btn btn-warning"">Submit and Upload <span class=""glyphicon glyphicon-send""></span></button>
				</div>
			</div>

		</fieldset>
	");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4455, 22, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4494, 1362, true);
                WriteLiteral(@"
	<script>
		$(function () {

			$(""#StaffDropDown"").chosen(
				{
					width: ""100%""
				});
			$(""#HospitalDropDown"").chosen();
			$(""#PatientDropDown"").chosen();
			$(""#TypeDropDown"").chosen();
		});
		function validateForm() {
			var e = document.getElementById(""HospitalDropDown"");
			var selected = e.options[e.selectedIndex].text;
			if (selected ==""Select a hospital..."") {
				alert(""Please select a hospital"");
				return false;
			}

			var e = document.getElementById(""RoomDropDown"");
			var selected = e.options[e.selectedIndex].value;
			if (selected==""error"") {
				alert(""Please select an operating room"");
				return false;
			}

			var e = document.getElementById(""PatientDropDown"");
			var selected = e.options[e.selectedIndex].text;
			if (selected == ""Select a patient..."") {
				alert(""Please select a patient"");
				return false;
			}
			var e = document.getElementById(""TypeDropDown"");
			var selected = e.options[e.selectedIndex].text;
			if (selected == ""Select t");
                WriteLiteral(@"he operation type..."") {
				alert(""Please select the type of the operation"");
				return false;
			}
			return true;







		}

		function UpdateRooms(val) {
			var hospitalID = document.getElementById('HospitalDropDown').value;
			$.ajax({
				type: 'GET',
				dataType: ""JSON"",
				data: { hospitalID },
				url: '");
                EndContext();
                BeginContext(5857, 36, false);
#line 192 "C:\Users\Dimitris Selal\source\repos\SensorFusion\SensorFusion\Views\Home\NewOperation.cshtml"
                 Write(Url.Action("UpdateRooms", "Dynamic"));

#line default
#line hidden
                EndContext();
                BeginContext(5893, 383, true);
                WriteLiteral(@"',
				success: function (result) {
					var dropdown = $('#RoomDropDown');
					dropdown.empty();
					dropdown.append($('<option></option>').val(""error"").html(""Please select a room...""));
					$.each(result, function (i, room) {
						dropdown.append($('<option></option>').val(room.roomNO).html(room.roomNO));
					});

				}
			});

			
		}




	</script>


");
                EndContext();
            }
            );
            BeginContext(6279, 50, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SensorFusion.ViewModels.NewOperationFormModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
