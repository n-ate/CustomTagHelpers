using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;

namespace CustomTagHelpers
{
    /// <summary>
    /// Extends the default asp-for attribute by adding description support.
    /// </summary>
    /// <example>
    /// Example _ViewImports.cshtml:
    ///     @namespace DefaultNamespace.Pages
    ///     @addTagHelper*, Microsoft.AspNetCore.Mvc.TagHelpers
    ///     @removeTagHelper Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper, Microsoft.AspNetCore.Mvc.TagHelpers
    ///     @addTagHelper CustomTagHelpers.CustomInputTagHelper, CustomTagHelpers
    ///     
    /// Example Markup Usage:
    ///     &lt;input asp-for="Property" class="form-control" />
    /// </example>
    [HtmlTargetElement("input", Attributes = FOR_ATTRIBUTE_NAME, TagStructure = TagStructure.WithoutEndTag)]
    public class CustomInputTagHelper : InputTagHelper
    {
        private const string FOR_ATTRIBUTE_NAME = "asp-for";

        public CustomInputTagHelper(IHtmlGenerator generator) : base(generator)
        {
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (output == null)
            {
                throw new ArgumentNullException(nameof(output));
            }

            var metadata = base.For.Metadata;

            if (metadata == null)
            {
                throw new InvalidOperationException(string.Format("No provided metadata " + FOR_ATTRIBUTE_NAME));
            }

            if (!string.IsNullOrWhiteSpace(metadata.Description))
            {
                output.Attributes.SetAttribute("title", metadata.Description);
            }
            base.Process(context, output);
        }
    }
}
