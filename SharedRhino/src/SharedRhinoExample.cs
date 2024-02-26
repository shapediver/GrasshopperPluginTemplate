using System;
using Rhino.Geometry;

namespace PluginTemplate.SharedRhino
{

    /// <summary>
    /// Example implementation of a shared interface dependent on RhinoCommon.
    /// </summary>
    public class SharedRhinoExample : ISharedRhinoExample
    {
        public Point3d PlaneLineIntersection(Plane plane, Line line)
        {
            if (Rhino.Geometry.Intersect.Intersection.LinePlane(line, plane, out double lineParameter))
            {
                return line.PointAt(lineParameter);
            }
            throw new Exception("Line does not intersect plane.");
        }
    }

}
