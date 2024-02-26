using Rhino.Geometry;

namespace PluginTemplate.SharedRhino
{
    
    /// <summary>
    /// Example of a shared interface dependent on RhinoCommon.
    /// </summary>
    public interface ISharedRhinoExample {

        /// <summary>
        /// Intersect a plane with a line.
        /// </summary>
        /// <param name="plane"></param>
        /// <param name="line"></param>
        /// <returns></returns>
        Point3d PlaneLineIntersection(Plane plane, Line line);

        
    }
    
}