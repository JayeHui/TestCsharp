using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestCsharp
{
    public partial class HelloWord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            welcome_div.InnerHtml="Hello! Welcome to my first test!^_^";
        }
    }
}