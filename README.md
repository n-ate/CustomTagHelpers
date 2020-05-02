# CustomTagHelpers

<em>Extends the existing asp-for InputTagHelper to support the description value of the DisplayAttribute.</em><br />
<ul>
    <li>
        <h3>Example _ViewImports.cshtml:</h3>
        <pre>
 @namespace DefaultNamespace.Pages
 @addTagHelper*, Microsoft.AspNetCore.Mvc.TagHelpers
 @removeTagHelper Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper, Microsoft.AspNetCore.Mvc.TagHelpers
 @addTagHelper CustomTagHelpers.CustomInputTagHelper, CustomTagHelpers</pre>
    </li>
    <li>
        <h3>Example Markup Usage:</h3>
        <pre>
 &lt;input asp-for="Property" class="form-control" readonly /></pre>
    </li>
</ul>
