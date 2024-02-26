using Grasshopper;
using Grasshopper.Kernel;
using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;

namespace PluginTemplate.PluginGrasshopper
{
    public class PluginLoader : GH_AssemblyPriority
    {
        public override GH_LoadingInstruction PriorityLoad()
        {
            Instances.ComponentServer.AddCategoryIcon("PluginTemplate", ResourceLoader.LoadBitmap("PluginGrasshopper_16.png"));
            Instances.ComponentServer.AddCategorySymbolName("PluginTemplate", 'P');
            return GH_LoadingInstruction.Proceed;
        }
    }
}