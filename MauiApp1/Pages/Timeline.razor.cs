using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Pages
{
    public partial class Timeline
    {
        [CascadingParameter]
        public string Color { get; set; }
    }
}
