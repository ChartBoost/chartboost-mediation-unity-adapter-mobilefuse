using System.Runtime.CompilerServices;
using Chartboost.Mediation.MobileFuse;
using UnityEngine.Scripting;

[assembly: AlwaysLinkAssembly]
[assembly: InternalsVisibleTo(AssemblyInfo.MobileFuseAssemblyInfoAndroid)]
[assembly: InternalsVisibleTo(AssemblyInfo.MobileFuseAssemblyInfoIOS)]

namespace Chartboost.Mediation.MobileFuse
{
    internal class AssemblyInfo
    {
        public const string MobileFuseAssemblyInfoAndroid = "Chartboost.Mediation.MobileFuse.Android";
        public const string MobileFuseAssemblyInfoIOS = "Chartboost.Mediation.MobileFuse.IOS";
    }
}
