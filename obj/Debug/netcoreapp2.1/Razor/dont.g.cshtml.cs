#pragma checksum "C:\Users\Dimitris Selal\source\repos\SensorFusion\SensorFusion\dont.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "398c61aeb4265704479a2247fe82c185be684712"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.dont), @"mvc.1.0.view", @"/dont.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/dont.cshtml", typeof(AspNetCore.dont))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"398c61aeb4265704479a2247fe82c185be684712", @"/dont.cshtml")]
    public class dont : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Dimitris Selal\source\repos\SensorFusion\SensorFusion\dont.cshtml"
  
	ViewData["Title"] = "Add new Operation";

#line default
#line hidden
            BeginContext(50, 10218, true);
            WriteLiteral(@"
<div class=""container"">

	<form class=""well form-horizontal"" action="" "" method=""post"" id=""contact_form"">
		<fieldset>

			<!-- Form Name -->
			<legend>Contact Us Today!</legend>

			<!-- Text input-->

			<div class=""form-group"">
				<label class=""col-md-4 control-label"">First Name</label>
				<div class=""col-md-4 inputGroupContainer"">
					<div class=""input-group"">
						<span class=""input-group-addon""><i class=""glyphicon glyphicon-user""></i></span>
						<input name=""first_name"" placeholder=""First Name"" class=""form-control"" type=""text"">
					</div>
				</div>
			</div>

			<!-- Text input-->

			<div class=""form-group"">
				<label class=""col-md-4 control-label"">Last Name</label>
				<div class=""col-md-4 inputGroupContainer"">
					<div class=""input-group"">
						<span class=""input-group-addon""><i class=""glyphicon glyphicon-user""></i></span>
						<input name=""last_name"" placeholder=""Last Name"" class=""form-control"" type=""text"">
					</div>
				</div>
			</div>

			<!-- Text ");
            WriteLiteral(@"input-->
			<div class=""form-group"">
				<label class=""col-md-4 control-label"">E-Mail</label>
				<div class=""col-md-4 inputGroupContainer"">
					<div class=""input-group"">
						<span class=""input-group-addon""><i class=""glyphicon glyphicon-envelope""></i></span>
						<input name=""email"" placeholder=""E-Mail Address"" class=""form-control"" type=""text"">
					</div>
				</div>
			</div>


			<!-- Text input-->

			<div class=""form-group"">
				<label class=""col-md-4 control-label"">Phone #</label>
				<div class=""col-md-4 inputGroupContainer"">
					<div class=""input-group"">
						<span class=""input-group-addon""><i class=""glyphicon glyphicon-earphone""></i></span>
						<input name=""phone"" placeholder=""(845)555-1212"" class=""form-control"" type=""text"">
					</div>
				</div>
			</div>

			<!-- Text input-->

			<div class=""form-group"">
				<label class=""col-md-4 control-label"">Address</label>
				<div class=""col-md-4 inputGroupContainer"">
					<div class=""input-group"">
						<span class=""inp");
            WriteLiteral(@"ut-group-addon""><i class=""glyphicon glyphicon-home""></i></span>
						<input name=""address"" placeholder=""Address"" class=""form-control"" type=""text"">
					</div>
				</div>
			</div>

			<!-- Text input-->

			<div class=""form-group"">
				<label class=""col-md-4 control-label"">City</label>
				<div class=""col-md-4 inputGroupContainer"">
					<div class=""input-group"">
						<div class=""instructions"">(Click to expand and select states to filter)</div>
						<div class=""dropdown-container"">
							<div class=""dropdown-button noselect"">
								<div class=""dropdown-label"">States</div>
								<div class=""dropdown-quantity"">(<span class=""quantity"">Any</span>)</div>
								<i class=""fa fa-filter""></i>
							</div>
							<div class=""dropdown-list"" style=""display: none;"">
								<input type=""search"" placeholder=""Search states"" class=""dropdown-search"" />
								<ul></ul>
							</div>
						</div>








					</div>
				</div>
			</div>



			<!-- Select Hospital -->

			<div ");
            WriteLiteral(@"class=""form-group"">
				<label class=""col-md-4 control-label"">Hospital</label>
				<div class=""col-md-4 selectContainer"">
					<div class=""input-group"">
						<span class=""input-group-addon""><i class=""glyphicon glyphicon-list""></i></span>
						<select name=""hospital"" class=""form-control selectpicker"">
							<option value="" "">Select the hospital</option>

							<option>Alabama</option>
							<option>Alaska</option>
							<option>Arizona</option>
							<option>Arkansas</option>
							<option>California</option>
						</select>
					</div>
				</div>
			</div>

			<!-- Select Room -->

			<div class=""form-group"">
				<label class=""col-md-4 control-label"">Operating Room</label>
				<div class=""col-md-4 selectContainer"">
					<div class=""input-group"">
						<span class=""input-group-addon""><i class=""glyphicon glyphicon-list""></i></span>
						<select name=""room"" class=""form-control selectpicker"">
							<option value="" "">Select the Operating Room Number</option>

							<option>Al");
            WriteLiteral(@"abama</option>
							<option>Alaska</option>
							<option>Arizona</option>
							<option>Arkansas</option>
							<option>California</option>
						</select>
					</div>
				</div>
			</div>

			<!-- Select Room -->

			<div class=""form-group"">
				<label class=""col-md-4 control-label"">Type of Operation</label>
				<div class=""col-md-4 selectContainer"">
					<div class=""input-group"">
						<span class=""input-group-addon""><i class=""glyphicon glyphicon-list""></i></span>
						<select name=""type"" class=""form-control selectpicker"">
							<option value="" "">Select the type of the operation</option>

							<option>Alabama</option>
							<option>Alaska</option>
							<option>Arizona</option>
							<option>Arkansas</option>
							<option>California</option>
						</select>
					</div>
				</div>
			</div>

			<!-- Text input-->

			<div class=""form-group"">
				<label class=""col-md-4 control-label"">Zip Code</label>
				<div class=""col-md-4 inputGroupContainer"">
					<div cla");
            WriteLiteral(@"ss=""input-group"">
						<span class=""input-group-addon""><i class=""glyphicon glyphicon-home""></i></span>
						<input name=""zip"" placeholder=""Zip Code"" class=""form-control"" type=""text"">
					</div>
				</div>
			</div>

			<!-- Text input-->
			<div class=""form-group"">
				<label class=""col-md-4 control-label"">Website or domain name</label>
				<div class=""col-md-4 inputGroupContainer"">
					<div class=""input-group"">
						<span class=""input-group-addon""><i class=""glyphicon glyphicon-globe""></i></span>
						<input name=""website"" placeholder=""Website or domain name"" class=""form-control"" type=""text"">
					</div>
				</div>
			</div>


			<!-- Video files upload-->
			<div class=""form-group"">
				<label class=""col-md-4 control-label"">Upload the video files</label>
				<div class=""col-md-2 inputGroupContainer"">
					<div class=""input-group"">
						<span class=""input-group-addon""><i class=""glyphicon glyphicon-upload""></i></span>

						<input id=""videoFiles"" type=""file"" name=""videoFiles"" ");
            WriteLiteral(@"multiple />
					</div>
				</div>
			</div>

			<!-- Audio files upload-->
			<div class=""form-group"">
				<label class=""col-md-4 control-label"">Upload the audio files</label>
				<div class=""col-md-2 inputGroupContainer"">
					<div class=""input-group"">
						<span class=""input-group-addon""><i class=""glyphicon glyphicon-upload""></i></span>

						<input id=""videoFiles"" type=""file"" name=""videoFiles"" multiple />
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
				<label class=""col-md-4 control-label");
            WriteLiteral(@"""></label>
				<div class=""col-md-4"">
					<button type=""submit"" class=""btn btn-warning"">Submit and Upload <span class=""glyphicon glyphicon-send""></span></button>
				</div>
			</div>

		</fieldset>
	</form>
</div>



<script>
	$(document).ready(function () {
		$('#contact_form').bootstrapValidator({
			// To use feedback icons, ensure that you use Bootstrap v3.1.0 or later
			feedbackIcons: {
				valid: 'glyphicon glyphicon-ok',
				invalid: 'glyphicon glyphicon-remove',
				validating: 'glyphicon glyphicon-refresh'
			},
			fields: {
				first_name: {
					validators: {
						stringLength: {
							min: 2,
						},
						notEmpty: {
							message: 'Please supply your first name'
						}
					}
				},
				last_name: {
					validators: {
						stringLength: {
							min: 2,
						},
						notEmpty: {
							message: 'Please supply your last name'
						}
					}
				},
				email: {
					validators: {
						notEmpty: {
							message: 'Please supply your email addre");
            WriteLiteral(@"ss'
						},
						emailAddress: {
							message: 'Please supply a valid email address'
						}
					}
				},
				phone: {
					validators: {
						notEmpty: {
							message: 'Please supply your phone number'
						},
						phone: {
							country: 'US',
							message: 'Please supply a vaild phone number with area code'
						}
					}
				},
				address: {
					validators: {
						stringLength: {
							min: 8,
						},
						notEmpty: {
							message: 'Please supply your street address'
						}
					}
				},
				city: {
					validators: {
						stringLength: {
							min: 4,
						},
						notEmpty: {
							message: 'Please supply your city'
						}
					}
				},
				state: {
					validators: {
						notEmpty: {
							message: 'Please select your state'
						}
					}
				},
				zip: {
					validators: {
						notEmpty: {
							message: 'Please supply your zip code'
						},
						zipCode: {
							country: 'US',
							message: 'Please supply a vail");
            WriteLiteral(@"d zip code'
						}
					}
				},
				comment: {
					validators: {
						stringLength: {
							min: 10,
							max: 200,
							message: 'Please enter at least 10 characters and no more than 200'
						},
						notEmpty: {
							message: 'Please supply a description of your project'
						}
					}
				}
			}
		})
			.on('success.form.bv', function (e) {
				$('#success_message').slideDown({ opacity: ""show"" }, ""slow"") // Do something ...
				$('#contact_form').data('bootstrapValidator').resetForm();

				// Prevent form submission
				e.preventDefault();

				// Get the form instance
				var $form = $(e.target);

				// Get the BootstrapValidator instance
				var bv = $form.data('bootstrapValidator');

				// Use Ajax to submit form data
				$.post($form.attr('action'), $form.serialize(), function (result) {
					console.log(result);
				}, 'json');
			});
	});





</script>


































");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
