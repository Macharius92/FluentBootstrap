using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBootstrap.Tests
{
    [TestFixture]
    public class TablesFixture
    {
        [Test]
        public void StripedTableProducesCorrectHtml()
        {
            TestHelper.AssertHtml<ASP._Views_Tests_Tables_cshtml>("test-striped",
@"<table class=""table table-striped"">
   <thead>
    <tr>
     <th>#</th>
     <th>First Name</th>
     <th>Last Name</th>
     <th>Username</th>
    </tr>
   </thead>
   <tbody>
    <tr>
     <td>1</td>
     <td>Mark</td>
     <td>Otto</td>
     <td>mdo</td>
    </tr>
    <tr>
     <td>2</td>
     <td>Jacob</td>
     <td>Thornton</td>
     <td>fat</td>
    </tr>
   </tbody>
  </table>");
        }

        [Test]
        public void TableWithExplicitSectionsProducesCorrectHtml()
        {
            TestHelper.AssertHtml<ASP._Views_Tests_Tables_cshtml>("test-explicit-sections",
@"<table class=""table"">
   <thead>
    <tr>
     <th>#</th>
     <th>First Name</th>
     <th>Last Name</th>
     <th>Username</th>
    </tr>
    <tr>
     <td>1</td>
     <td>Mark</td>
     <td>Otto</td>
     <td>mdo</td>
    </tr>
   </thead>
   <tbody>
    <tr>
     <th>#</th>
     <th>First Name</th>
     <th>Last Name</th>
     <th>Username</th>
    </tr>
    <tr>
     <td>2</td>
     <td>Jacob</td>
     <td>Thornton</td>
     <td>fat</td>
    </tr>
   </tbody>
  </table>");
        }

        [Test]
        public void TableResponsiveProducesCorrectHtml()
        {
            TestHelper.AssertHtml<ASP._Views_Tests_Tables_cshtml>("test-responsive",
@"<div class=""table-responsive"">
   <table class=""table"">
    <thead>
     <tr>
      <th>#</th>
      <th>First Name</th>
      <th>Last Name</th>
      <th colspan=""2"">Username</th>
     </tr>
     <tr class=""warning"">
      <td>1</td>
      <td>Mark</td>
      <td>Otto</td>
      <td>mdo</td>
      <td>colspan</td>
     </tr>
    </thead>
    <tbody>
     <tr>
      <td>2</td>
      <td>Jacob</td>
      <td>Thornton</td>
      <td>fat</td>
      <td>colspan</td>
     </tr>
    </tbody>
    <tfoot>
     <tr>
      <td>3</td>
      <td>Matthieu</td>
      <td>Chomienne</td>
      <td>mch</td>
      <td>colspan</td>
     </tr>
     <tr>
      <td rowspan=""2"">1</td>
      <td>Mark</td>
      <td>Otto</td>
      <td>mdo</td>
      <td>colspan</td>
     </tr>
     <tr>
      <td>Jacob</td>
      <td>Thornton</td>
      <td>fat</td>
      <td>colspan</td>
     </tr>
    </tfoot>
   </table>
  </div>
  <table class=""table"">
   <thead>
    <tr>
     <th>#</th>
     <th>First Name</th>
     <th>Last Name</th>
     <th>Username</th>
    </tr>
   </thead>
   <tbody>
    <tr>
     <td>1</td>
     <td>Mark</td>
     <td>Otto</td>
     <td>mdo</td>
    </tr>
   </tbody>
  </table>");
        }
    }
}
