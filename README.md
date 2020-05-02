# CustomTagHelpers

<em>Extends the existing</em> "asp-for" <strong>InputTagHelper</strong> <em>to support the description value of the</em> <strong>DisplayAttribute</strong><em>.</em><br />
<ul>
    <li>
        <h3>Example _ViewImports.cshtml:</h3>
        <pre>
@namespace DefaultNamespace.Pages
@addTagHelper*, Microsoft.AspNetCore.Mvc.TagHelpers  

 
@removeTagHelper Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper, Microsoft.AspNetCore.Mvc.TagHelpers
@addTagHelper CustomTagHelpers.CustomInputTagHelper, CustomTagHelpers

@removeTagHelper Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper, Microsoft.AspNetCore.Mvc.TagHelpers
@addTagHelper CustomTagHelpers.CustomTextAreaTagHelper, CustomTagHelpers

@removeTagHelper Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper, Microsoft.AspNetCore.Mvc.TagHelpers
@addTagHelper CustomTagHelpers.CustomSelectTagHelper, CustomTagHelpers</pre>
    </li>
    <li>
        <h3>Example Markup Usages:</h3>
        <pre>
&lt;input asp-for="Property" class="form-control" /></pre>
        <pre> 
&lt;textarea asp-for="Property" class="form-control">&lt;/textarea></pre>
        <pre>
&lt;select asp-for="Property" asp-items="Model.ProertyOptions" class="form-control">
 &nbsp; &nbsp; &lt;option selected hidden>- Select -&lt;/option>
&lt;/select></pre>
    </li>
</ul>
