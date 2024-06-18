using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using StoreApp.Web.Models;

namespace StoreApp.Web.TagHelpers;

[HtmlTargetElement("div", Attributes = "page-model")]
public class PageLinkTagHelper : TagHelper
{
    private IUrlHelperFactory _urlHelperFactory;
    public PageLinkTagHelper(IUrlHelperFactory urlHelperFactory){
        _urlHelperFactory = urlHelperFactory;
    }

    [ViewContext]
    public ViewContext? ViewContext { get; set; }
    public PageInfo? PageModel { get; set; }
    public string? PageAction { get; set; }
    override public void Process(TagHelperContext context, TagHelperOutput output){

        if(ViewContext != null && PageModel != null){
            IUrlHelper urlHelper = _urlHelperFactory.GetUrlHelper(ViewContext);
            TagBuilder tag = new TagBuilder("div");
            for(var i = 1; i <= PageModel.TotalPages; i++){
                TagBuilder link = new TagBuilder("a");
                link.Attributes["href"] = urlHelper.Action(PageAction, new {page = i});
                link.InnerHtml.Append(i.ToString());
                link.InnerHtml.AppendHtml(link);
            }
            output.Content.AppendHtml(tag);
        }
        
    }
}