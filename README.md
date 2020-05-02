# CustomTagHelpers

<em>Extends the existing asp-for InputTagHelper to support the description value of the DisplayAttribute.</em><br />
<ul>
    <li>
        <h3>Example _ViewImports.cshtml:</h3>
        <code>
            @namespace DefaultNamespace.Pages
        <code>
        <br />
        </code>
            @addTagHelper*, Microsoft.AspNetCore.Mvc.TagHelpers
        <code>
        <br />
        </code>
            @removeTagHelper Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper, Microsoft.AspNetCore.Mvc.TagHelpers
        <code>
        <br />
        </code>
            @addTagHelper CustomTagHelpers.CustomInputTagHelper, CustomTagHelpers
        </code>
    </li>
    <li>
        <h3>Example Markup Usage:</h3>
        <code>
            &lt;input asp-for="Property" class="form-control" readonly />
        </code>
    </li>
</ul>
