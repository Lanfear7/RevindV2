#pragma checksum "C:\Users\stell\OneDrive\Desktop\REWIND\RewindV2\rolesDemoSSD\Views\Shared\_Paypal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee8c49c9555c0e078b20acd3281dc8109700e2dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Paypal), @"mvc.1.0.view", @"/Views/Shared/_Paypal.cshtml")]
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
#line 1 "C:\Users\stell\OneDrive\Desktop\REWIND\RewindV2\rolesDemoSSD\Views\_ViewImports.cshtml"
using rolesDemoSSD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\stell\OneDrive\Desktop\REWIND\RewindV2\rolesDemoSSD\Views\_ViewImports.cshtml"
using rolesDemoSSD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee8c49c9555c0e078b20acd3281dc8109700e2dc", @"/Views/Shared/_Paypal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"076307135dc47d879fc427f06362ff74e4928b74", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Paypal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""paypal-button""></div>
<script src=""https://www.paypalobjects.com/api/checkout.js""></script>
<script>
    paypal.Button.render({
        env: 'sandbox', // Or ' production '
        style: { // You can customize your button here.
            size: 'small',
            color: 'gold',
            shape: 'pill',
            label: 'checkout'
        },
        client: {
            // You need to change this to your client ID
            sandbox: 'AdWdXFWXAFyPZsxcT9hkF37fdvfsfa9CPfU8PjqlLB52v9b0Cx3WpgClj15u8NtxK4kVQPJhXOnmb70Y',
            // production: '3W8F5EEJKUJP4KSY'  // Switch to ‘production’ when live.
        },

        commit: true, // Show a 'Pay Now' button

        payment: function (data, actions) {
            return actions.payment.create({
                payment: {
                    transactions: [{
                        // The 'custom' field helps you to link the paypal request
                        // with paypal's response which is important.

      ");
            WriteLiteral(@"                  // You may want use a 'custom' field to send an accountID from
                        // your site so you can uniquely identify the person making the
                        // payment when Paypal notifies you.

                        // Sometimes a person at your site will pay at Paypal with
                        // an entirely different set of credentials. They may pay with
                        // a credit card or account which belongs to their spouse or
                        // another family member. In situations like these, relating
                        // payments to accounts on your site can be difficult.

                        // The custom property value that you send to Paypal for a
                        // payment request is returned in Paypal's reponse.
                        custom: 'Custom data goes here!',
                        amount: { total: ");
#nullable restore
#line 45 "C:\Users\stell\OneDrive\Desktop\REWIND\RewindV2\rolesDemoSSD\Views\Shared\_Paypal.cshtml"
                                    Write(ViewBag.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@", currency: 'USD' }
                    }
                    ]
                }
            });
        },

        onAuthorize: function (data, actions) {
            return actions.payment.execute().then(function (payment) {
                console.log(""This is what comes back from Paypal: "")
                console.log(payment);
                alert(""This JSON is from Paypal: "" + JSON.stringify(payment));
                console.log(""-------------------------------------"")
                var dataObject = {
                    ""cart"":             payment.cart,
                    ""intent"":           payment.intent,
                    ""paymentID"":        payment.id,
                    ""create_time"":      payment.create_time,
                    ""paymentState"":     payment.state,
                    ""payerEmail"":       payment.payer.payer_info.email,
                    ""payerID"":          payment.payer.payer_info.payer_id,
                    ""payerFirstName"":   payment.payer.payer");
            WriteLiteral(@"_info.first_name,
                    ""payerLastName"":    payment.payer.payer_info.last_name,
                    ""payerMiddleName"":  payment.payer.payer_info.middle_name,
                    ""payerCountryCode"": payment.payer.payer_info.country_code,
                    ""paymentMethod"":    payment.payer.payment_method,
                    ""payerStatus"":      payment.payer.status,
                    ""amount"":           payment.transactions[0].amount.total,
                    ""currency"":         payment.transactions[0].amount.currency,
                    ""custom"":           payment.transactions[0].custom
                }

                // The payment is complete!
                // You can now show a confirmation message to the customer
                $.ajax({
                    type: ""post"",
                    url: ""/Paypal/PaySuccess"",
                    data: JSON.stringify(dataObject),
                    contentType: ""application/json; charset=utf-8"",
                    dataTyp");
            WriteLiteral(@"e: ""json"",

                    //after success
                    success: function (msg) {
                        console.log(""Data: "" + JSON.stringify(data));
                        window.location.href
                        =""/Paypal/FinishShopping?paymentID="" + data.paymentID;
                    },
                    //after fail
                    error: function (msg) {
                        alert(""fail: "" + JSON.stringify(msg));
                    }
                });
            })
        },

        onCancel: function (data, actions) {
            /*
            * Buyer cancelled the payment
            */
        },
    }, '#paypal-button');
</script>
");
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
