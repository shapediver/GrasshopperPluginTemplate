
namespace PluginTemplate.Shared
{

    /// <summary>
    /// Example implementation of a shared interface not dependent on RhinoCommon.
    /// </summary>
    public class SharedExample : ISharedExample
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

}