#pragma checksum "C:\Users\alway\Desktop\BuyFoodforGit\BuyFood_Template\Views\OrderDetail\ShowOrderDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6db881e058c9e1c6e4fd60e7e1fda4ff9a04975"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderDetail_ShowOrderDetail), @"mvc.1.0.view", @"/Views/OrderDetail/ShowOrderDetail.cshtml")]
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
#line 1 "C:\Users\alway\Desktop\BuyFoodforGit\BuyFood_Template\Views\_ViewImports.cshtml"
using BuyFood_Template;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alway\Desktop\BuyFoodforGit\BuyFood_Template\Views\_ViewImports.cshtml"
using BuyFood_Template.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6db881e058c9e1c6e4fd60e7e1fda4ff9a04975", @"/Views/OrderDetail/ShowOrderDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7063af1aed637f0edaf01ce998250970c36fbeb", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderDetail_ShowOrderDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/RatingStars.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\alway\Desktop\BuyFoodforGit\BuyFood_Template\Views\OrderDetail\ShowOrderDetail.cshtml"
  
    ViewData["Title"] = "ShowOrderDetail";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6db881e058c9e1c6e4fd60e7e1fda4ff9a049754255", async() => {
                WriteLiteral(@"
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-BmbxuPwQa2lc/FVzBcNJ7UAyJxM6wuqIj61tLrc4wSX0szH/Ev+nYRRuWlolflfl"" crossorigin=""anonymous"">
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-b5kHyXgcpbZJO/tY9Ul7kGkf1S0CWuKcCD38l8YkeH8z8QjE0GmW1gYU5S9FOnJ0"" crossorigin=""anonymous""></script>
    <script src=""https://code.jquery.com/jquery-1.12.4.min.js""></script>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a6db881e058c9e1c6e4fd60e7e1fda4ff9a049755171", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <style>
        .btn-primary {
            background-color: #7FAD39;
        }

        .table-package th, .table-package td {
            border-top: hidden;
        }
    </style>
    <style type=""text/css"">
        /*
            Use :not with impossible condition so inputs are only hidden
            if pseudo selectors are supported. Otherwise the user would see
            no inputs and no highlighted stars.
        */
        .rating input[type=""radio""]:not(:nth-of-type(0)) {
            /* hide visually */
            border: 0;
            clip: rect(0 0 0 0);
            height: 1px;
            margin: -1px;
            overflow: hidden;
            padding: 0;
            position: absolute;
            width: 1px;
        }

        .rating [type=""radio""]:not(:nth-of-type(0)) + label {
            display: none;
        }

        label[for]:hover {
            cursor: pointer;
        }

        .rating .stars label:before {
            content: ""★"";
 ");
                WriteLiteral(@"       }

        .stars label {
            color: lightgray;
        }

            .stars label:hover {
                text-shadow: 0 0 1px #000;
            }

        .rating [type=""radio""]:nth-of-type(1):checked ~ .stars label:nth-of-type(-n+1),
        .rating [type=""radio""]:nth-of-type(2):checked ~ .stars label:nth-of-type(-n+2),
        .rating [type=""radio""]:nth-of-type(3):checked ~ .stars label:nth-of-type(-n+3),
        .rating [type=""radio""]:nth-of-type(4):checked ~ .stars label:nth-of-type(-n+4),
        .rating [type=""radio""]:nth-of-type(5):checked ~ .stars label:nth-of-type(-n+5) {
            color: orange;
        }

        .rating [type=""radio""]:nth-of-type(1):focus ~ .stars label:nth-of-type(1),
        .rating [type=""radio""]:nth-of-type(2):focus ~ .stars label:nth-of-type(2),
        .rating [type=""radio""]:nth-of-type(3):focus ~ .stars label:nth-of-type(3),
        .rating [type=""radio""]:nth-of-type(4):focus ~ .stars label:nth-of-type(4),
        .rating [type=""rad");
                WriteLiteral("io\"]:nth-of-type(5):focus ~ .stars label:nth-of-type(5) {\r\n            color: darkorange;\r\n        }\r\n\r\n        .checked {\r\n            color: orange;\r\n        }\r\n    </style>\r\n");
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
            WriteLiteral(@"

<div id=""page-start"" class=""position-relative"">
    <div class=""position-relative m-4"">
        <div class=""progress"" style=""height: 1px;"">
            <div class=""progress-bar"" role=""progressbar"" style=""width: 50%;"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
        </div>");
            WriteLiteral(@"        <button type=""button"" class=""position-absolute top-0 start-0 translate-middle btn btn-sm btn-primary rounded-pill"" style=""width: 8rem; height:2rem;"">餐點製作</button>
        <button type=""button"" class=""position-absolute top-0 start-50 translate-middle btn btn-sm btn-primary rounded-pill"" style=""width: 8rem; height:2rem;"">運送餐點</button>
        <button type=""button"" class=""position-absolute top-0 start-100 translate-middle btn btn-sm btn-primary rounded-pill"" style=""width: 8rem; height:2rem;"">到達地點</button>
    </div>");
            WriteLiteral(@"    <div class=""position-relative m-4"" style=""top:10px"">
        <span class=""position-absolute top-0 start-0 translate-middle small"" style=""width: 7rem;"" id=""TimeOfPreparing"">2021/3/9 11:00</span>
        <span class=""position-absolute top-0 start-50 translate-middle small"" style=""width: 7rem;""id=""TimeOfTransportation"">2021/3/9 11:10</span>
        <span class=""position-absolute top-0 start-100 translate-middle small"" style=""width: 7rem;"" id=""TimeOfArrival"">2021/3/9 11:20</span>
    </div>");
            WriteLiteral("    <script>\r\n        $(function () {\r\n            $.ajax({\r\n                url: \"/OrderDetail/getOrderTime/\",\r\n                type:\"POST\",\r\n                data: { \"OrderID\":");
#nullable restore
#line 99 "C:\Users\alway\Desktop\BuyFoodforGit\BuyFood_Template\Views\OrderDetail\ShowOrderDetail.cshtml"
                             Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"},
                success: function (dataTimeOfPreparing) {
                    //console.log(dataTimeOfPreparing);
                    $(""#TimeOfPreparing"").html(dataTimeOfPreparing);
                    $.ajax({
                        url: ""/OrderDetail/getTimeForSalir/"",
                        type: ""POST"",
                        data: { ""dataTimeOfPreparing"": dataTimeOfPreparing,""OrderID"":");
#nullable restore
#line 106 "C:\Users\alway\Desktop\BuyFoodforGit\BuyFood_Template\Views\OrderDetail\ShowOrderDetail.cshtml"
                                                                                Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" },
                        success: function (dataTimeForSalir) {
                            //console.log(dataTimeForSalir);
                            $(""#TimeOfTransportation"").html(dataTimeForSalir);
                            $.ajax({
                                url: ""/OrderDetail/getTimeOfArrival/"",
                                type: ""POST"",
                                data: { ""dataTimeOfSalir"": dataTimeForSalir,""OrderID"":");
#nullable restore
#line 113 "C:\Users\alway\Desktop\BuyFoodforGit\BuyFood_Template\Views\OrderDetail\ShowOrderDetail.cshtml"
                                                                                 Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"},
                                success: function (dataTimeOfArrival) {
                                    //console.log(dataTimeOfArrival);
                                    $(""#TimeOfArrival"").html(dataTimeOfArrival);
                                }
                            })
                        }
                    })
                    



                }


            });


            



        })


    </script>

    <div class=""container"" style=""margin:50px;"" id=""AdressForDetail"">

    </div>
    <script>
        var text = """";
        $.ajax({
            url: ""/OrderDetail/getOrderAdress/"",
            type: ""POST"",
            data: { ""OrderID"":");
#nullable restore
#line 148 "C:\Users\alway\Desktop\BuyFoodforGit\BuyFood_Template\Views\OrderDetail\ShowOrderDetail.cshtml"
                         Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("},\r\n            success: function (data) {\r\n                $.ajax({\r\n                    url: \"/OrderDetail/getMember/\",\r\n                    type: \"POST\",\r\n                    data: { \"OrderID\":");
#nullable restore
#line 153 "C:\Users\alway\Desktop\BuyFoodforGit\BuyFood_Template\Views\OrderDetail\ShowOrderDetail.cshtml"
                                 Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"},
                    success: function (response) {
                        for (let i = 0; i < response.length; i++) {
                            text = `
                                            <h3>收件地址</h3>
                                            <p>${response[i].cName}</p>
                                            <p>${response[i].cPhone}</p>
                                            <p>${data[i].cArrivedAddress}</p>`;
                        }
                        $(""#AdressForDetail"").html(text);
                    }
                });
            }
        });
    </script>

    <div class=""container"" style=""margin:50px;"">
");
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-12"">
                <table class=""table table-image"">
                    <thead>
                        <tr>
                            <th scope=""col"">序號</th>
                            <th scope=""col"">照片</th>
                            <th scope=""col"">商品名稱</th>
                            <th scope=""col"">數量</th>
                            <th scope=""col"">訂單金額</th>
                            <th scope=""col"">訂單狀態</th>
                            <th scope=""col"">評分狀態</th>
                        </tr>
                    </thead>
                    <tbody id=""StartOfDetails"">
");
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\"></th>\r\n                            <td");
            BeginWriteAttribute("class", " class=\"", 7909, "\"", 7917, 0);
            EndWriteAttribute();
            WriteLiteral(@"></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td>
                                <table class=""table-package"">
                                    <tr>
                                        <th> </th>
                                        <td>
                                            小計
                                        </td>
                                    </tr>
                                    <tr>
                                        <th> </th>
                                        <td>
                                            折扣
                                        </td>
                                    </tr>
                                    <tr>
                                        <th> </th>
                                        <td>
                                            訂單金額
                                        </td>
         ");
            WriteLiteral(@"                           </tr>
                                    <tr>
                                        <th> </th>
                                        <td>
                                            付款方式
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td>
                                <table class=""table-package"" id=""howToPay"">
                                    <tr>
                                        <th> </th>
                                        <td>
                                            $500
                                        </td>
                                    </tr>
                                    <tr>
                                        <th> </th>
                                        <td>
                                            $0
                                        </td>
       ");
            WriteLiteral(@"                             </tr>
                                    <tr>
                                        <th> </th>
                                        <td>
                                            $500
                                        </td>
                                    </tr>
                                    <tr>
                                        <th> </th>
                                        <td>
                                            擺腹幣
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>


</div>
<script>

</script>
<script>

                            var text = """";
                            $.ajax({
                                url: ""/OrderDetail/getOrderDetail/"",
                  ");
            WriteLiteral("              type: \"POST\",\r\n                                data: { \"OrderID\":");
#nullable restore
#line 271 "C:\Users\alway\Desktop\BuyFoodforGit\BuyFood_Template\Views\OrderDetail\ShowOrderDetail.cshtml"
                                             Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"},
                                success: function (data) {
                                    //console.log(data[0]);

                                    for (let i = 0; i < data.length; i++) {
                                        var stars = """";
                                        var count = data[i].cScores;
                                        var oDetailID = data[i].cOrderDetailId;
                                        var Scorebutton = `ScoreIt${oDetailID}`;

                                        for (let i = 0; i < count; i++)
                                        {
                                            stars += `<span class=""fa fa-star checked""></span>`;
                                        }
                                        if (count == null) {
                                            data[i].cReview = ""尚未評分"";
                                        }
                                        if (data[i].cFeedBackStatus == 0)
                    ");
            WriteLiteral(@"                    {
                                            data[i].cReview = ""該則評論已被管制"";
                                            stars = `<p>評分不列入計算</p>`;
                                        }

                                        text += `<tr>
                                                        <th scope=""row"">1</th>
                                                        <td class=""w-25"">
                                                        <img src=""${data[i].cPicture.replace(""~"", """")}"" class=""img-fluid img-thumbnail"" alt=""Sheep"">
                                                        </td>
                                                        <td>${data[i].cProductName}</td>
                                                        <td>${data[i].cQuantity}</td>
                                                        <td>$${data[i].cLittlePrice}</td>
                                                        <td>${data[i].cOrderStatusName}</td>
                         ");
            WriteLiteral(@"                               <td id=""ScoreStatus${oDetailID}"">${stars}<p>${data[i].cReview}</p></td>
                                                        </tr>`;

                                        text +=`<tr>
                                                       <th scope=""row""></th>
                                                       <td class="""">
                                                       </td>
                                                       <td></td>
                                                       <td></td>
                                                       <td></td>
                                                       <td><button type=""button"" class=""btn btn-outline-success"" onclick=""window.location='/ProductDetail/ProductData?id=${data[i].cProductId}';"">回到產品</button></td>`

                                        if (count == null) {
                                            if (data[i].cOrderStatusName != ""已結單"") {
                          ");
            WriteLiteral(@"                      text += `<td><button type=""button"" class=""btn btn-outline-success"" id=""ScoreIt${data[i].cOrderDetailId}"" onclick=""StartScore('ScoreStatus${oDetailID}')"" disabled>進行評分</button></td>`;
                                                $('#' + Scorebutton).prop('disabled', true);
                                            }
                                            else {
                                                text += `<td><button type=""button"" class=""btn btn-outline-success"" id=""ScoreIt${data[i].cOrderDetailId}"" onclick=""StartScore('ScoreStatus${oDetailID}')"">進行評分</button></td>`;
                                            }
                                            
                                        }
                                        else {
                                            text += `<td><button type=""button"" class=""btn btn-outline-success"" id=""ScoreIt${data[i].cOrderDetailId}"" disabled>完成評分</button></td>`;
                                      ");
            WriteLiteral(@"      /*$(`#${Scorebutton}`).prop('disabled', true);*/
                                            $('#' + Scorebutton).prop('disabled', true);
                                        }

                                        text += `</tr>`;



                                        //===========   For迴圈結尾
                                    }
                                    $(""#StartOfDetails"").prepend(text);

                                                                                //結帳方式
                                    var ltTotal = 0;

                                    for (let i = 0; i < data.length; i++) {
                                        ltTotal += data[i].cLittlePrice;
                                    }



                                        var HowToPayText = """";
                                        $.ajax({
                                            url:""/OrderDetail/getHowToPay/"",
                                            type: ""POST"",");
            WriteLiteral("\n                                            data: {\"OrderID\":");
#nullable restore
#line 352 "C:\Users\alway\Desktop\BuyFoodforGit\BuyFood_Template\Views\OrderDetail\ShowOrderDetail.cshtml"
                                                        Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"},
                                            success: function (response) {
                                                HowToPayText = `<tr>
                                                                                <th> </th>
                                                                                <td>
                                                                                    $${ltTotal}
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <th> </th>
                                                                                <td>
                                                                                    $${response.cCutPrice}
                                                             ");
            WriteLiteral(@"                   </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <th> </th>
                                                                                <td>
                                                                                    $${ltTotal - response.cCutPrice}
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <th> </th>
                                                                                <td>
                                                                                    ${response.cPayType}
 ");
            WriteLiteral(@"                                                                               </td>
                                                                            </tr>`;

                                                $(""#howToPay"").html(HowToPayText);

                                            }
                                        });

                                }
                            });
                            //===========
                            //===========轉換成評分輸入

                            //====================onclick=""AddScores(${data[i].cProductId})""
                            //儲存評分
                            $(""#ScoreIt"").click(function () {
                                $(""#ScoreStatus"").html(giveAScore);

                                (function () {
                                    var rating = document.querySelector('.rating');
                                    var handle = document.getElementById('toggle-rating');
                   ");
            WriteLiteral(@"                 handle.onchange = function (event) {
                                        rating.classList.toggle('rating', handle.checked);
                                    };
                                });

                            });


                            //變化成評分頁面
                            function StartScore(OrderDetailID) {




                                var giveAScore = `<fieldset class='rating'><legend>請評價</legend >
                            <input id='${OrderDetailID}demo-1' type='radio' name='${OrderDetailID}demo' value='1'>
                            <label for='${OrderDetailID}demo-1'>1 star</label>
                            <input id='${OrderDetailID}demo-2' type='radio' name='${OrderDetailID}demo' value='2'>
                            <label for='${OrderDetailID}demo-2'>2 stars</label>
                            <input id='${OrderDetailID}demo-3' type='radio' name='${OrderDetailID}demo' value='3'>
                            <label for='$");
            WriteLiteral(@"{OrderDetailID}demo-3'>3 stars</label>
                            <input id='${OrderDetailID}demo-4' type='radio' name='${OrderDetailID}demo' value='4'>
                            <label for='${OrderDetailID}demo-4'>4 stars</label>
                            <input id='${OrderDetailID}demo-5' type='radio' name='${OrderDetailID}demo' value='5'>
                            <label for='${OrderDetailID}demo-5'>5 stars</label>
                            <div class='stars'>
                            <label for='${OrderDetailID}demo-1' aria-label='1 star' title='1 star'></label>
                            <label for='${OrderDetailID}demo-2' aria-label='2 stars' title='2 stars'></label>
                            <label for='${OrderDetailID}demo-3' aria-label='3 stars' title='3 stars'></label>
                            <label for='${OrderDetailID}demo-4' aria-label='4 stars' title='4 stars'></label>
                            <label for='${OrderDetailID}demo-5' aria-label='5 stars' title='5 stars");
            WriteLiteral(@"'></label>
                            </div>
                            </fieldset>


                             <input type='text' class='form-control' id='${OrderDetailID}inputComment' placeholder='輸入您的評語'>
                             <input class='btn btn-primary' type='button' value='評分' onclick=""AddScores('${OrderDetailID}')"">`;
                                $('#' + OrderDetailID).html(giveAScore);


                                (function () {
                                    var rating = document.querySelector('.rating');
                                    var handle = document.getElementById('toggle-rating');
                                    handle.onchange = function (event) {
                                        rating.classList.toggle('rating', handle.checked);
                                    };
                                });





                            }

                            function AddScores(id) {
                                v");
            WriteLiteral(@"ar names = id + 'demo';
                                var InputID = id + 'inputComment';
                                //console.log(names);//ScoreStatus80demo
                                //console.log(`${id}demo`);//ScoreStatus80demo
                                //console.log(id);//ScoreStatus80

                                var starValue = $(`input[name='${names}']:checked`).val();

                                var reviewValue = $('#' + InputID).val();

                                var detailID = id.substr(11);


                                $.ajax({
                                    url: ""/OrderDetail/getDetailValue/"",
                                    type: ""POST"",
                                    data: { ""StarValue"": starValue, ""ReviewInput"": reviewValue, ""orderdetailID"": detailID},
                                    success: function (ratingData)
                                    {

                                        var ReScorebutton = `ScoreIt$");
            WriteLiteral(@"{detailID}`;
                                        var Restars = """";
                                        for (let i = 0; i < starValue; i++)
                                        {
                                            Restars += `<span class=""fa fa-star checked""></span>`;
                                        }
                                        Restars += `<p>${reviewValue}</p>`;

                                        //刷新評價
                                        $('#' + id).html(Restars);
                                        //disable按鈕
                                        $('#' + ReScorebutton).prop('disabled', true);
                                        $('#' + ReScorebutton).html('完成評分');
                                    }
                                });



                            }
</script>
<script type=""text/javascript"">

</script>
<script>

</script>");
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
