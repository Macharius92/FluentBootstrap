using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBootstrap.Tests
{
    [TestFixture]
    public class NavbarsFixture
    {
        [Test]
        public void StandardNavbarProducesCorrectHtml()
        {
            TestHelper.AssertHtml<ASP._Views_Tests_Navbars_cshtml>("test-standard-navbar",
@"<nav role=""navigation"" id=""navbar"" class=""navbar navbar-default"">
   <div class=""container-fluid"">
    <div class=""navbar-header"">
     <a href=""/"" class=""navbar-brand"">MyApp</a>
     <button type=""button"" data-toggle=""collapse"" aria-expanded=""false"" data-target=""#navbar-collapse"" class=""navbar-toggle collapsed"">
      <span class=""sr-only"">Toggle Navigation</span>
      <span class=""icon-bar""></span>
      <span class=""icon-bar""></span>
      <span class=""icon-bar""></span>
     </button>
    </div>
    <div id=""navbar-collapse"" class=""navbar-collapse collapse"">
     <ul class=""nav navbar-nav navbar-left"">
      <li>
       <a href=""#"">A</a>
      </li>
      <li>
       <a href=""#"">B</a>
      </li>
     </ul>
    </div>
   </div>
  </nav>");
        }

        [Test]
        public void NonFluidNavbarProducesCorrectHtml()
        {
            TestHelper.AssertHtml<ASP._Views_Tests_Navbars_cshtml>("test-nonfluid-navbar",
@"<nav role=""navigation"" id=""nav2"" class=""navbar navbar-default"">
   <div class=""container-fluid"">
    <div class=""navbar-header"">
     <a href=""/"" class=""navbar-brand"">MyApp</a>
     <button type=""button"" data-toggle=""collapse"" aria-expanded=""false"" data-target=""#nav2-collapse"" class=""navbar-toggle collapsed"">
      <span class=""sr-only"">Toggle Navigation</span>
      <span class=""icon-bar""></span>
      <span class=""icon-bar""></span>
      <span class=""icon-bar""></span>
     </button>
    </div>
    <div id=""nav2-collapse"" class=""navbar-collapse collapse"">
     <ul class=""nav navbar-nav navbar-left"">
      <li>
       <a href=""#"">A</a>
      </li>
      <li>
       <a href=""#"">B</a>
      </li>
     </ul>
    </div>
   </div>
  </nav>");
        }

        [Test]
        public void FixedNavbarProducesCorrectHtml()
        {
            TestHelper.AssertHtml<ASP._Views_Tests_Navbars_cshtml>("test-fixed-navbar",
@"<nav role=""navigation"" id=""nav3"" class=""navbar navbar-default navbar-fixed-bottom"">
   <div class=""container-fluid"">
    <div class=""navbar-header"">
     <a href=""/"" class=""navbar-brand"">MyApp</a>
     <button type=""button"" data-toggle=""collapse"" aria-expanded=""false"" data-target=""#nav3-collapse"" class=""navbar-toggle collapsed"">
      <span class=""sr-only"">Toggle Navigation</span>
      <span class=""icon-bar""></span>
      <span class=""icon-bar""></span>
      <span class=""icon-bar""></span>
     </button>
    </div>
    <div id=""nav3-collapse"" class=""navbar-collapse collapse"">
     <ul class=""nav navbar-nav navbar-left"">
      <li>
       <a href=""#"">A</a>
      </li>
      <li>
       <a href=""#"">B</a>
      </li>
     </ul>
    </div>
   </div>
  </nav>");
        }

        [Test]
        public void StaticNavbarProducesCorrectHtml()
        {
            TestHelper.AssertHtml<ASP._Views_Tests_Navbars_cshtml>("test-static-navbar",
@"<nav role=""navigation"" id=""nav4"" class=""navbar navbar-default navbar-static-top"">
   <div class=""container-fluid"">
    <div class=""navbar-header"">
     <a href=""/"" class=""navbar-brand"">MyApp</a>
     <button type=""button"" data-toggle=""collapse"" aria-expanded=""false"" data-target=""#nav4-collapse"" class=""navbar-toggle collapsed"">
      <span class=""sr-only"">Toggle Navigation</span>
      <span class=""icon-bar""></span>
      <span class=""icon-bar""></span>
      <span class=""icon-bar""></span>
     </button>
    </div>
    <div id=""nav4-collapse"" class=""navbar-collapse collapse"">
     <ul class=""nav navbar-nav navbar-left"">
      <li>
       <a href=""#"">A</a>
      </li>
      <li>
       <a href=""#"">B</a>
      </li>
     </ul>
    </div>
   </div>
  </nav>");
        }

        [Test]
        public void InverseNavbarProducesCorrectHtml()
        {
            TestHelper.AssertHtml<ASP._Views_Tests_Navbars_cshtml>("test-inverse-navbar",
@"<nav role=""navigation"" id=""nav5"" class=""navbar navbar-default navbar-inverse"">
   <div class=""container-fluid"">
    <div class=""navbar-header"">
     <a href=""/"" class=""navbar-brand"">MyApp</a>
     <button type=""button"" data-toggle=""collapse"" aria-expanded=""false"" data-target=""#nav5-collapse"" class=""navbar-toggle collapsed"">
      <span class=""sr-only"">Toggle Navigation</span>
      <span class=""icon-bar""></span>
      <span class=""icon-bar""></span>
      <span class=""icon-bar""></span>
     </button>
    </div>
    <div id=""nav5-collapse"" class=""navbar-collapse collapse"">
     <ul class=""nav navbar-nav navbar-left"">
      <li>
       <a href=""#"">A</a>
      </li>
      <li>
       <a href=""#"">B</a>
      </li>
     </ul>
    </div>
   </div>
  </nav>");
        }

        [Test]
        public void ManualNavbarProducesCorrectHtml()
        {
            TestHelper.AssertHtml<ASP._Views_Tests_Navbars_cshtml>("test-manual-navbar",
@"<nav role=""navigation"" id=""nav6"" class=""navbar navbar-default"">
   <div class=""container-fluid"">
    <div class=""navbar-header"">
     <a href=""#"" class=""navbar-brand"">MyApp</a>
     <button type=""button"" data-toggle=""collapse"" aria-expanded=""false"" data-target=""#nav6-collapse"" class=""navbar-toggle collapsed"">
      <span class=""sr-only"">Toggle Navigation</span>
      <span class=""icon-bar""></span>
      <span class=""icon-bar""></span>
      <span class=""icon-bar""></span>
     </button>
    </div>
    <div id=""nav6-collapse"" class=""navbar-collapse collapse"">
     <ul class=""nav navbar-nav navbar-left"">
      <li>
       <a href=""#"">A</a>
      </li>
      <li class=""dropdown""><a href=""#"" data-toggle=""dropdown"" class=""dropdown-toggle navbar-link"">B 
       <span class=""caret""></span></a>
       <ul role=""menu"" class=""dropdown-menu"">
        <li role=""presentation"">
         <a role=""menuitem"" href=""#"">C</a>
        </li>
        <li role=""presentation"">
         <a role=""menuitem"" href=""#"">D</a>
        </li>
       </ul>
      </li>
     </ul>
     <form role=""form"" class=""navbar-form navbar-left"">
      <div class=""form-group"">
       <input type=""text"" name=""Search"" placeholder=""Search"" id=""Search"" class=""form-control"">
      </div>
      <div class=""form-group"">
       <button type=""submit"" class=""btn btn-primary"">Submit</button>
      </div>
      <div class=""form-group"">
       <div class=""form-control-static text-danger""></div>
      </div>
     </form>
     <ul class=""nav navbar-nav navbar-left"">
      <li>
       <a href=""#"">B</a>
      </li>
     </ul>
     <button type=""button"" class=""btn btn-warning navbar-btn navbar-left"">Warn</button>
     <p class=""navbar-text navbar-right"">                    Logged in as <a href=""#"" class=""navbar-link"">Dave</a>
</p>
     <ul class=""nav navbar-nav navbar-right"">
      <li>
       <a href=""#"">R</a>
      </li>
     </ul>
    </div>
   </div>
  </nav>");
        }

        [Test]
        public void ImplicitSectionsProducesCorrectHtml()
        {
            TestHelper.AssertHtml<ASP._Views_Tests_Navbars_cshtml>("test-implicit-sections",
@"<nav role=""navigation"" id=""nav7"" class=""navbar navbar-default"">
   <div class=""container-fluid"">
    <div class=""navbar-header"">
     <a href=""#"" class=""navbar-brand"">MyApp</a>
     <button type=""button"" data-toggle=""collapse"" aria-expanded=""false"" data-target=""#nav7-collapse"" class=""navbar-toggle collapsed"">
      <span class=""sr-only"">Toggle Navigation</span>
      <span class=""icon-bar""></span>
      <span class=""icon-bar""></span>
      <span class=""icon-bar""></span>
     </button>
    </div>
    <div id=""nav7-collapse"" class=""navbar-collapse collapse"">
     <ul class=""nav navbar-nav navbar-left"">
      <li>
       <a href=""#"">A</a>
      </li>
      <li class=""dropdown""><a href=""#"" data-toggle=""dropdown"" class=""dropdown-toggle navbar-link"">B 
       <span class=""caret""></span></a>
       <ul role=""menu"" class=""dropdown-menu"">
        <li role=""presentation"">
         <a role=""menuitem"" href=""#"">C</a>
        </li>
        <li role=""presentation"">
         <a role=""menuitem"" href=""#"">D</a>
        </li>
       </ul>
      </li>
     </ul>
     <form role=""form"" class=""navbar-form navbar-left"">
      <div class=""form-group"">
       <input type=""text"" name=""Search"" placeholder=""Search"" id=""Search"" class=""form-control"">
      </div>
      <div class=""form-group"">
       <button type=""submit"" class=""btn btn-primary"">Submit</button>
      </div>
      <div class=""form-group"">
       <div class=""form-control-static text-danger""></div>
      </div>
     </form>
     <ul class=""nav navbar-nav navbar-left"">
      <li>
       <a href=""#"">B</a>
      </li>
     </ul>
     <button type=""button"" class=""btn btn-warning navbar-btn navbar-left"">Warn</button>
     <p class=""navbar-text navbar-right"">                Logged in as <a href=""#"" class=""navbar-link"">Dave</a>
</p>
    </div>
   </div>
  </nav>");
        }

        [Test]
        public void StandardNavbarButtonProducesCorrectHtml()
        {
            TestHelper.AssertHtml<ASP._Views_Tests_Navbars_cshtml>("test-standard-navbar-button",
                @"<nav role=""navigation"" id=""nav8"" class=""navbar navbar-default"">
   <div class=""container-fluid"">
    <div class=""navbar-header"">
     <a href=""/"" class=""navbar-brand"">MyApp</a>
     <button type=""button"" data-toggle=""collapse"" aria-expanded=""false"" data-target=""#nav8-collapse"" class=""navbar-toggle collapsed"">
      <span class=""sr-only"">Toggle Navigation</span>
      <span class=""icon-bar""></span>
      <span class=""icon-bar""></span>
      <span class=""icon-bar""></span>
     </button>
    </div>
    <div id=""nav8-collapse"" class=""navbar-collapse collapse"">
     <button type=""button"" class=""btn btn-warning navbar-btn navbar-left"">Warn</button>
     <ul class=""nav navbar-nav navbar-left"">
      <li class=""active disabled"">
       <a href=""#"">B</a>
      </li>
     </ul>
    </div>
   </div>
  </nav>");
        }

        [Test]
        public void StandardNavbarTextProducesCorrectHtml()
        {
            TestHelper.AssertHtml<ASP._Views_Tests_Navbars_cshtml>("test-standard-navbar-text",
                @"<nav role=""navigation"" id=""nav9"" class=""navbar navbar-default"">
   <div class=""container-fluid"">
    <div class=""navbar-header"">
     <a href=""/"" class=""navbar-brand"">MyApp</a>
     <button type=""button"" data-toggle=""collapse"" aria-expanded=""false"" data-target=""#nav9-collapse"" class=""navbar-toggle collapsed"">
      <span class=""sr-only"">Toggle Navigation</span>
      <span class=""icon-bar""></span>
      <span class=""icon-bar""></span>
      <span class=""icon-bar""></span>
     </button>
    </div>
    <div id=""nav9-collapse"" class=""navbar-collapse collapse"">
     <p class=""navbar-text navbar-right"">                Logged in as <a href=""#"" class=""navbar-link"">Dave</a>
</p>
    </div>
   </div>
  </nav>");
        }

        [Test]
        public void StandardNavbarFormProducesCorrectHtml()
        {
            TestHelper.AssertHtml<ASP._Views_Tests_Navbars_cshtml>("test-standard-navbar-form",
                @"<nav role=""navigation"" id=""nav10"" class=""navbar navbar-default"">
   <div class=""container-fluid"">
    <div class=""navbar-header"">
     <a href=""/"" class=""navbar-brand"">MyApp</a>
     <button type=""button"" data-toggle=""collapse"" aria-expanded=""false"" data-target=""#nav10-collapse"" class=""navbar-toggle collapsed"">
      <span class=""sr-only"">Toggle Navigation</span>
      <span class=""icon-bar""></span>
      <span class=""icon-bar""></span>
      <span class=""icon-bar""></span>
     </button>
    </div>
    <div id=""nav10-collapse"" class=""navbar-collapse collapse"">
     <form role=""form"" class=""navbar-form navbar-left"">
      <div class=""form-group has-feedback"">
       <input type=""text"" name=""Search"" placeholder=""Search"" id=""Search"" class=""form-control"">
        <span class=""fa fa-facebook form-control-feedback""></span>
       
      </div>
      <div class=""form-group"">
       <button type=""submit"" class=""btn btn-primary"">Submit</button>
      </div>
      <fieldset></fieldset>
      <div class=""help-block""></div>
      <div class=""form-group"">
       <p class=""form-control-static"">
      </div>
      <div class=""form-group"">
       <div class=""form-control-static text-danger""></div>
      </div>
     </form>
    </div>
   </div>
  </nav>");
        }
        [Test]
        public void StandardNavbarToggleProducesCorrectHtml()
        {
            TestHelper.AssertHtml<ASP._Views_Tests_Navbars_cshtml>("test-standard-navbar-toggle",
                @"<nav role=""navigation"" id=""nav11"" class=""navbar navbar-default"">
   <div class=""container-fluid"">
    <div class=""navbar-header"">
     <button type=""button"" data-toggle=""collapse"" aria-expanded=""false"" data-target=""#nav11-collapse"" class=""navbar-toggle collapsed"">
      <span class=""sr-only"">Toggle Navigation</span>
      <span class=""icon-bar""></span>
      <span class=""icon-bar""></span>
      <span class=""icon-bar""></span>
     </button>
     <button type=""button"" data-toggle=""collapse"" aria-expanded=""false"" data-target=""#nav11-collapse"" class=""navbar-toggle collapsed"">
      <span class=""sr-only"">Toggle Navigation</span>
      <span class=""icon-bar""></span>
      <span class=""icon-bar""></span>
      <span class=""icon-bar""></span>
     </button>
    </div>
    <div id=""nav11-collapse"" class=""navbar-collapse collapse"">
     <ul class=""nav navbar-nav navbar-left"">
      <li>
       <a href=""#"">A</a>
      </li>
      <li>
       <a href=""#"">B</a>
      </li>
     </ul>
    </div>
   </div>
  </nav>");
        }
    }
}
