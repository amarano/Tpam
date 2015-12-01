using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tpam.Domain;
using Xunit;

namespace Tpam.Tests
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class Class1
    {

        public class TestClass : EntityBase
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }


        [Fact]
        public void UniTest1()
        {
            var view = new ReadOnlyView<TestClass>();
        }
    }
}
