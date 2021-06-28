#pragma checksum "G:\KEKChat\KEKChat\Pages\ChatRoom.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d20ac171c912a1485e92bfdfe08a7a5216ce146"
// <auto-generated/>
#pragma warning disable 1591
namespace KEKChat.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\KEKChat\KEKChat\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\KEKChat\KEKChat\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\KEKChat\KEKChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\KEKChat\KEKChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\KEKChat\KEKChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\KEKChat\KEKChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\KEKChat\KEKChat\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\KEKChat\KEKChat\_Imports.razor"
using KEKChat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\KEKChat\KEKChat\_Imports.razor"
using KEKChat.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
using BlazorChat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
using KEKChat.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chatroom")]
    public partial class ChatRoom : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>KEKChat</h1>\r\n<hr>\r\n\r\n\r\n");
#nullable restore
#line 12 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
 if (!_isChatting)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p>\r\n        Enter your name to start chatting:\r\n    </p>\r\n");
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "maxlength", "32");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
                                              _username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _username = __value, _username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "type", "button");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
                                     Chat

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "<span class=\"oi oi-chat\" aria-hidden=\"true\"></span> Chat!");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 20 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"

    // Error messages
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
     if (_message != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "invalid-feedback");
            __builder.AddContent(18, 
#nullable restore
#line 24 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
                                       _message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "small");
            __builder.AddAttribute(21, "id", "emailHelp");
            __builder.AddAttribute(22, "class", "form-text text-muted");
            __builder.AddContent(23, 
#nullable restore
#line 25 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
                                                            _message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 26 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
     
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "alert alert-secondary mt-4");
            __builder.AddAttribute(28, "role", "alert");
            __builder.AddMarkupContent(29, "\r\n        <span class=\"oi oi-person mr-2\" aria-hidden=\"true\"></span>\r\n        ");
            __builder.OpenElement(30, "span");
            __builder.AddContent(31, "You are connected as ");
            __builder.OpenElement(32, "b");
            __builder.AddContent(33, 
#nullable restore
#line 32 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
                                       _username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "class", "btn btn-sm btn-warning ml-md-auto");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
                                                                     DisconnectAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, "Disconnect");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
            __builder.AddContent(41, "    ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "id", "scrollbox");
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 37 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
         foreach (var item in _messages)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
             if (item.IsNotice)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "                ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "alert alert-info");
            __builder.AddContent(48, 
#nullable restore
#line 41 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
                                               item.Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 42 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "                ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", 
#nullable restore
#line 45 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
                             item.CSS

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "user");
            __builder.AddContent(56, 
#nullable restore
#line 46 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
                                       item.Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n\r\n\r\n\r\n");
#nullable restore
#line 50 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
                     if (item.Body == imageDataUri)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, "                        ");
            __builder.OpenElement(59, "img");
            __builder.AddAttribute(60, "src", 
#nullable restore
#line 52 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
                                  item.Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
#nullable restore
#line 53 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(62, "                        ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "msg");
            __builder.AddContent(65, 
#nullable restore
#line 56 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
                                          item.Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
#nullable restore
#line 57 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(67, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n");
#nullable restore
#line 59 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(69, "        <hr>\r\n        ");
            __builder.OpenElement(70, "textarea");
            __builder.AddAttribute(71, "class", "input-lg");
            __builder.AddAttribute(72, "placeholder", "enter your comment");
            __builder.AddAttribute(73, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 63 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
                                                                            _newMessage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _newMessage = __value, _newMessage));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n        ");
            __builder.OpenElement(76, "button");
            __builder.AddAttribute(77, "class", "btn btn-default");
            __builder.AddAttribute(78, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
                                                    () => SendAsync(_newMessage)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(79, "Send");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n\r\n");
#nullable restore
#line 66 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
         if (Toggle)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(81, "            ");
            __builder.OpenComponent<BlazorInputFile.InputFile>(82);
            __builder.AddAttribute(83, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 68 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
                                 HandleSelection

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(84, "\r\n");
#nullable restore
#line 69 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(85, "            ");
            __builder.OpenComponent<BlazorInputFile.InputFile>(86);
            __builder.AddAttribute(87, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 72 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
                                 HandleSelection

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(88, "\r\n");
#nullable restore
#line 73 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(89, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n");
#nullable restore
#line 76 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "G:\KEKChat\KEKChat\Pages\ChatRoom.razor"
       



    string status;
    string imageDataUri;

    private bool Toggle { get; set; }

    async Task HandleSelection(IFileListEntry[] files)
    {
        var rawFile = files.FirstOrDefault();
        if (rawFile != null)
        {
            // Load as an image file in memory
            var format = "image/jpeg";

            var imageFile = await rawFile.ToImageFileAsync(format, 640, 480);
            var ms = new MemoryStream();
            await imageFile.Data.CopyToAsync(ms);

            // Make a data URL so we can display it
            imageDataUri = $"data:{format};base64,{Convert.ToBase64String(ms.ToArray())}";
            status = $"Finished loading {ms.Length} bytes from {imageFile.Name}";

            Toggle = !Toggle;



            await SendAsync(imageDataUri);
        }
    }

    // flag to indicate chat status
    private bool _isChatting = false;

    // name of the user who will be chatting
    private string _username = Login.Username;

    // on-screen message
    private string _message;

    // new message input
    private string _newMessage;

    // list of messages in chat
    private List<Message> _messages = new List<Message>();

    private string _hubUrl;
    private HubConnection _hubConnection;



    public async Task Chat()
    {
        // check username is valid
        if (string.IsNullOrWhiteSpace(_username))
        {
            _message = "Please enter a name";
            return;
        };

        try
        {
            // Start chatting and force refresh UI, ref: https://github.com/dotnet/aspnetcore/issues/22159
            _isChatting = true;
            await Task.Delay(1);

            // remove old messages if any
            _messages.Clear();

            // Create the chat client
            string baseUrl = navigationManager.BaseUri;

            _hubUrl = baseUrl.TrimEnd('/') + ChatHub.HubUrl;

            _hubConnection = new HubConnectionBuilder()
                .WithUrl(_hubUrl)
                .Build();

            _hubConnection.On<string, string>("Broadcast", BroadcastMessage);

            await _hubConnection.StartAsync();

            await SendAsync($"[Notice] {_username} joined chat room.");
        }
        catch (Exception e)
        {
            _message = $"ERROR: Failed to start chat client: {e.Message}";
            _isChatting = false;
        }
    }

    private void BroadcastMessage(string name, string message)
    {
        bool isMine = name.Equals(_username, StringComparison.OrdinalIgnoreCase);

        _messages.Add(new Message(name, message, isMine));


        // Inform blazor the UI needs updating
        StateHasChanged();
    }

    private async Task DisconnectAsync()
    {
        if (_isChatting)
        {
            await SendAsync($"[Notice] {_username} left chat room.");

            await _hubConnection.StopAsync();
            await _hubConnection.DisposeAsync();

            _hubConnection = null;
            _isChatting = false;
        }
    }

    private async Task SendAsync(string message)
    {
        if (_isChatting && !string.IsNullOrWhiteSpace(message))
        {
            await _hubConnection.SendAsync("Broadcast", _username, message);

            _newMessage = string.Empty;
        }
    }



    private class Message
    {
        public Message(string username, string body, bool mine)
        {
            Username = username;
            Body = body;
            Mine = mine;
        }

        public string Username { get; set; }
        public string Body { get; set; }
        public bool Mine { get; set; }

        public bool IsNotice => Body.StartsWith("[Notice]");

        public string CSS => Mine ? "sent" : "received";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591