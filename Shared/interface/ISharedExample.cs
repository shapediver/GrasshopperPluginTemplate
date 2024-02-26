
namespace PluginTemplate.Shared
{
    
    /// <summary>
    /// Example of a shared interface not dependent on RhinoCommon.
    /// </summary>
    public interface ISharedExample {

        /// <summary>
        /// Compute the sum of two integers.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int Add(int a, int b);
        
    }
    
}