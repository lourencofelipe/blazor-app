#pragma checksum "A:\src\blazor-app\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d46c051f904e82c0315dbc8e24afa4147f785489"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace todo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "A:\src\blazor-app\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "A:\src\blazor-app\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "A:\src\blazor-app\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "A:\src\blazor-app\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "A:\src\blazor-app\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "A:\src\blazor-app\_Imports.razor"
using todo;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "A:\src\blazor-app\Pages\Index.razor"
       
    public class TodoItem
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }

    private string newTodo = "";
    private List<TodoItem> todos = new List<TodoItem>();

    void AddNewTask(){
       
        if(!string.IsNullOrWhiteSpace(newTodo)){
            todos.Add(new TodoItem {Title = newTodo });
            newTodo = "";
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
