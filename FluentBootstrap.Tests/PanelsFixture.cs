using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBootstrap.Tests
{
    [TestFixture]
    public class PanelsFixture
    {
        [Test]
        public void SimplePanelProducesCorrectHtml()
        {
            TestHelper.AssertHtml<ASP._Views_Tests_Panels_cshtml>("test-simple-panel",
@"<div class=""panel panel-success"">
   <div class=""panel-heading"">
    <h3 class=""panel-title"">My Test Title</h3>
   </div>
   <div class=""panel-body"">My Test Body</div>
   <div class=""table"">My Test Panel Table</div>
   <div class=""panel-footer"">My Test Footer</div>
  </div>");
        }
    }
}
