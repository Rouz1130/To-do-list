using System.IO;
using Microsoft.AspNet.Builder;
using Nancy;
using Nancy.ViewEngines.Razor;
using System.Collections.Generic;

namespace ToDoList
{
  public class Startup
  {
    public void Configure(IApplicationBuilder app)
    {
      app.UseOwin(x => x.UseNancy());
     }
  }
   public class CustomRootPathProvider :  IRootPathProvider
   {
     public string GetRootPath()
     {
       return Directory.GetCurrentDirectory();
     }
   }
   public IEnumberable<string>GetDefaultNamespaces()
   {
     return null;
   }
   public bool AutoIncludeModelNamespace
   {
     get {return false;}
   }
  }
}
