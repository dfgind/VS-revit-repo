#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;

#endregion

namespace RevitAddin5
{
    internal class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication a)
        {
            TaskDialog.Show("welcome", "you just started revit");
            return Result.Succeeded;

        }
        
        public Result OnShutdown(UIControlledApplication a)
        {
            TaskDialog.Show("byebye", "closing");
            return Result.Succeeded;
        }
    }
}
