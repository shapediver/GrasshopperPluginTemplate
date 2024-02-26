using Grasshopper;
using Grasshopper.Kernel;
using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;

namespace PluginTemplate.PluginGrasshopper
{
    public class PluginInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;
            }
        }

        public override Bitmap Icon => ResourceLoader.LoadBitmap("PluginGrasshopper_24.png");

        public override Bitmap AssemblyIcon => Icon;

        public override string Description
        {
            get
            {
                var description = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyDescriptionAttribute>().Description;
                var configuration = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyConfigurationAttribute>().Configuration;
                if (configuration.ToLowerInvariant().Contains("debug"))
                {
                    description = $"{description}, {Version} ({configuration})";
                }
                return description;
            }
        }

        public override string AssemblyDescription => Description;

        public override Guid Id
        {
            get
            {
                return new Guid(Assembly.GetExecutingAssembly().GetCustomAttribute<GuidAttribute>().Value);
            }
        }

        public override string AuthorName
        {
            get
            {
                var company = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyCompanyAttribute>().Company;

                var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes<AssemblyMetadataAttribute>();
                if (attributes != null)
                {
                    foreach (var attribute in attributes)
                    {
                        if (attribute.Key == "Authors")
                        {
                            return $"{attribute.Value}, {company}";
                        }
                    }
                }

                return company;
            }
        }

        public override string AuthorContact
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes<AssemblyMetadataAttribute>();
                if (attributes != null)
                {
                    foreach (var attribute in attributes)
                    {
                        if (attribute.Key == "AuthorContact")
                        {
                            return attribute.Value;
                        }
                    }
                }
                return "";
            }
        }

        public override string Version
        {
            get
            {
                var version = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
                return version.ToString();
            }
        }

        public override string AssemblyVersion
        {
            get
            {
                var version = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
                return version.ToString();
            }
        }
    }
}