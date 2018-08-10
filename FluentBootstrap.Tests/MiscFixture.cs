using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBootstrap.Tests
{
    [TestFixture]
    public class MiscFixture
    {
        [Test]
        public void FullWidthJumbotronProducesCorrectHtml()
        {
            TestHelper.AssertHtml<ASP._Views_Tests_Misc_cshtml>("test-fullwidth-jumbotron",
@"<div class=""jumbotron"">
  <div class=""container"">
   <h1>Heading</h1>
   <p>Some text.</p>
  </div>
 </div>");
        }

        [Test]
        public void JumbotronProducesCorrectHtml()
        {
            TestHelper.AssertHtml<ASP._Views_Tests_Misc_cshtml>("test-jumbotron",
@"<div class=""jumbotron"">
   <h1>Heading</h1>
   <p>Some text.</p>
  </div>");
        }

        [Test]
        public void SimplePageHeaderProducesCorrectHtml()
        {
            TestHelper.AssertHtml<ASP._Views_Tests_Misc_cshtml>("test-simple-pageheader",
@"<div class=""page-header"">
   <h1>Header
    <small>Small Text</small>
   </h1>
  </div>");
        }

        [Test]
        public void ComplexPageHeaderProducesCorrectHtml()
        {
            TestHelper.AssertHtml<ASP._Views_Tests_Misc_cshtml>("test-complex-pageheader",
@"<div class=""page-header"">
   <h1>            Header

    <small>Some small text</small>
    <span class=""label label-default"">A label</span>
   </h1>
  </div>");
        }

        [Test]
        public void NavbarWithItems1ProducesCorrectHtml()
        {
            TestHelper.AssertHtml<ASP._Views_Tests_Misc_cshtml>("test-navbar-with-items1",
            @"<nav role=""navigation"" id=""navbar"" class=""navbar navbar-default"">
   <div class=""container-fluid"">
    <div id=""navbar-collapse"" class=""navbar-collapse collapse"">
     <ul class=""nav navbar-nav navbar-left"">
      <li class=""dropdown""><a href=""#"" data-toggle=""dropdown"" class=""dropdown-toggle navbar-link"">Dropdown 
       <span class=""caret""></span></a>
       <ul role=""menu"" class=""dropdown-menu"">
        <li role=""presentation"">
         <a role=""menuitem"" href=""#"">A</a>
        </li>
        <li role=""presentation"">
         <a role=""menuitem"" href=""#"">B</a>
        </li>
       </ul>
      </li>
      <li>
       <a href=""#"">A</a>
      </li>
      <li>
       <a href=""#"">B</a>
      </li>
     </ul>
    </div>
   </div>
   <div class=""navbar-header"">
    <button type=""button"" data-toggle=""collapse"" aria-expanded=""false"" data-target=""#navbar-collapse"" class=""navbar-toggle collapsed"">
     <span class=""sr-only"">Toggle Navigation</span>
     <span class=""icon-bar""></span>
     <span class=""icon-bar""></span>
     <span class=""icon-bar""></span>
    </button>
   </div>
  </nav>");
        }
    }
}
