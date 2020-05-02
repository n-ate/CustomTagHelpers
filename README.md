# CustomTagHelpers

Extends the existing asp-for InputTagHelper to support the description value of the DisplayAttribute. 

Example _ViewImports.cshtml:
    @namespace DefaultNamespace.Pages
    @addTagHelper*, Microsoft.AspNetCore.Mvc.TagHelpers
    @removeTagHelper Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper, Microsoft.AspNetCore.Mvc.TagHelpers
    @addTagHelper CustomTagHelpers.CustomInputTagHelper, CustomTagHelpers
 
Example Markup Usage:
    <input asp-for="Property" class="form-control" readonly />
