using System.Collections.Generic;

namespace ClassLibrary1
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class vNextFeature : IvNextFeature
    {
        public vNextFeature()
        {
        }

        public IEnumerable<string> GetList()
        {
            return new string[]{
                "Cloud and server-optimized",
                "ASP.NET MVC and Web API have been unified into a single programming model",
                "No-compile developer experience",
                "Dependency injection out of the box",
                "Side by side - deploy the runtime and framework with your application",
                "NuGet everything - even the runtime itself",
                "All Open Source via the .NET Foundation and takes contributions"
                };
        }
    }


    public interface IvNextFeature
    {
        IEnumerable<string> GetList();
    }
}
