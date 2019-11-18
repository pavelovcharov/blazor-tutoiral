using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.UIInterfaces {
    public interface ITab {
        RenderFragment ChildContent { get; }
    }
}
