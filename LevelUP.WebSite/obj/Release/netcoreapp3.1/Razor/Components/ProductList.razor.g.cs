#pragma checksum "E:\VSRepos\LevelUP\LevelUP.WebSite\Components\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5361f0486ce8e282fad4de7b7b18d209e3eae302"
// <auto-generated/>
#pragma warning disable 1591
namespace LevelUP.WebSite.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\VSRepos\LevelUP\LevelUP.WebSite\Components\ProductList.razor"
using LevelUP.WebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\VSRepos\LevelUP\LevelUP.WebSite\Components\ProductList.razor"
using ContosoCrafts.WebSite.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\VSRepos\LevelUP\LevelUP.WebSite\Components\ProductList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-columns");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 7 "E:\VSRepos\LevelUP\LevelUP.WebSite\Components\ProductList.razor"
     foreach (var product in ProductService.GetProducts())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-img");
            __builder.AddAttribute(9, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 10 "E:\VSRepos\LevelUP\LevelUP.WebSite\Components\ProductList.razor"
                                                                 product.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card-body");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "h5");
            __builder.AddAttribute(16, "class", "card-title");
            __builder.AddContent(17, 
#nullable restore
#line 13 "E:\VSRepos\LevelUP\LevelUP.WebSite\Components\ProductList.razor"
                                        product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "card-footer");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "small");
            __builder.AddAttribute(24, "class", "text-muted");
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "E:\VSRepos\LevelUP\LevelUP.WebSite\Components\ProductList.razor"
                                      (e => SelectProduct(product.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "data-toggle", "modal");
            __builder.AddAttribute(29, "data-target", "#productModal");
            __builder.AddAttribute(30, "class", "btn btn-primary");
            __builder.AddMarkupContent(31, "\r\n                        More Info\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 26 "E:\VSRepos\LevelUP\LevelUP.WebSite\Components\ProductList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n\r\n    ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "modal fade");
            __builder.AddAttribute(39, "id", "productModal");
            __builder.AddAttribute(40, "tabindex", "-1");
            __builder.AddAttribute(41, "role", "dialog");
            __builder.AddAttribute(42, "aria-labelledby", "productTitle");
            __builder.AddAttribute(43, "aria-hidden", "true");
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(47, "role", "document");
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "modal-content");
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 33 "E:\VSRepos\LevelUP\LevelUP.WebSite\Components\ProductList.razor"
                 if (selectedProduct != null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "                    ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "modal-header");
            __builder.AddMarkupContent(55, "\r\n                        ");
            __builder.OpenElement(56, "h5");
            __builder.AddAttribute(57, "class", "modal-title");
            __builder.AddAttribute(58, "id", "productTitle");
            __builder.AddContent(59, 
#nullable restore
#line 36 "E:\VSRepos\LevelUP\LevelUP.WebSite\Components\ProductList.razor"
                                                                   selectedProduct.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                        ");
            __builder.AddMarkupContent(61, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                            <span aria-hidden=\"true\">&times;</span>\r\n                        </button>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                    ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "modal-body");
            __builder.AddMarkupContent(65, "\r\n                        ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "card");
            __builder.AddMarkupContent(68, "\r\n                            ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "card-img");
            __builder.AddAttribute(71, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 43 "E:\VSRepos\LevelUP\LevelUP.WebSite\Components\ProductList.razor"
                                                                                 selectedProduct.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.AddMarkupContent(72, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                            ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "card-body");
            __builder.AddMarkupContent(76, "\r\n                                ");
            __builder.OpenElement(77, "p");
            __builder.AddAttribute(78, "class", "card-text");
            __builder.AddContent(79, 
#nullable restore
#line 46 "E:\VSRepos\LevelUP\LevelUP.WebSite\Components\ProductList.razor"
                                                      selectedProduct.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                    ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "modal-footer");
            __builder.AddMarkupContent(86, "\r\n");
#nullable restore
#line 51 "E:\VSRepos\LevelUP\LevelUP.WebSite\Components\ProductList.razor"
                         if (voteCount == 0)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(87, "                            ");
            __builder.AddMarkupContent(88, "<span>Be the first to vote!</span>\r\n");
#nullable restore
#line 54 "E:\VSRepos\LevelUP\LevelUP.WebSite\Components\ProductList.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(89, "                            ");
            __builder.OpenElement(90, "span");
            __builder.AddContent(91, 
#nullable restore
#line 57 "E:\VSRepos\LevelUP\LevelUP.WebSite\Components\ProductList.razor"
                                   voteCount

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(92, " ");
            __builder.AddContent(93, 
#nullable restore
#line 57 "E:\VSRepos\LevelUP\LevelUP.WebSite\Components\ProductList.razor"
                                              voteLabel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n");
#nullable restore
#line 58 "E:\VSRepos\LevelUP\LevelUP.WebSite\Components\ProductList.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "E:\VSRepos\LevelUP\LevelUP.WebSite\Components\ProductList.razor"
                         for (int i = 1; i < 6; i++)
                        {
                            var currentStar = i;
                            if (i <= currentRating)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(95, "                                ");
            __builder.OpenElement(96, "span");
            __builder.AddAttribute(97, "class", "fa fa-star checked");
            __builder.AddAttribute(98, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "E:\VSRepos\LevelUP\LevelUP.WebSite\Components\ProductList.razor"
                                                                           (e => SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n");
#nullable restore
#line 65 "E:\VSRepos\LevelUP\LevelUP.WebSite\Components\ProductList.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(100, "                                ");
            __builder.OpenElement(101, "span");
            __builder.AddAttribute(102, "class", "fa fa-star");
            __builder.AddAttribute(103, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "E:\VSRepos\LevelUP\LevelUP.WebSite\Components\ProductList.razor"
                                                                   (e => SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n");
#nullable restore
#line 69 "E:\VSRepos\LevelUP\LevelUP.WebSite\Components\ProductList.razor"
                            }
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(105, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n");
#nullable restore
#line 72 "E:\VSRepos\LevelUP\LevelUP.WebSite\Components\ProductList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(107, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n\r\n\r\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">");
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "E:\VSRepos\LevelUP\LevelUP.WebSite\Components\ProductList.razor"
 
    Product selectedProduct;
    string selectedProductId;

    void SelectProduct(string productId)
    {
        selectedProductId = productId;
        selectedProduct = ProductService.GetProducts().First(x => x.Id == productId);
        GetCurrentRating();
    }

    int currentRating = 0;
    int voteCount = 0;
    string voteLabel;

    void GetCurrentRating()
    {
        if (selectedProduct.Ratings == null)
        {
            currentRating = 0;
            voteCount = 0;
        }
        else
        {
            voteCount = selectedProduct.Ratings.Count();
            voteLabel = voteCount > 1 ? "Votes" : "Vote";
            currentRating = selectedProduct.Ratings.Sum() / voteCount;
        }

        System.Console.WriteLine($"Current rating for {selectedProduct.Id}: {currentRating}");
    }

    void SubmitRating(int rating)
    {
        System.Console.WriteLine($"Rating received for {selectedProduct.Id}: {rating}");
        ProductService.AddRating(selectedProductId, rating);
        SelectProduct(selectedProductId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
