using System;
using System.Collections.Generic;
using System.Xml.Linq;

using R5T.T0132;


namespace R5T.O0029.O001
{
    /// <summary>
    /// Common-domain Visual Studio project file XElement operation sets.
    /// </summary>
    [FunctionalityMarker]
    public partial interface IProjectXElementOperationSets : IFunctionalityMarker
    {
        public IEnumerable<Action<XElement>> BlazorWebAssemblyClient_Net_8 => Instances.EnumerableOperator.From(
            Instances.ProjectXElementOperations.Set_SDK_BlazorWebAssembly,
            Instances.ProjectXElementOperations.In_NewPropertyGroupXElementContext(
                Instances.PropertyGroupXElementOperations.Set_TargetFramework_Net8,
                Instances.PropertyGroupXElementOperations.Enable_Nullable,
                Instances.PropertyGroupXElementOperations.Set_NoDefaultLaunchSettingsFile,
                Instances.PropertyGroupXElementOperations.Set_StaticWebAssetProjectMode_Default
            ),
            Instances.ProjectXElementOperations.In_NewItemGroupXElementContext(
                Instances.ItemGroupXElementOperations.Add_PackageReference(
                    Instances.PackageReferences.Microsoft_AspNetCore_Components_WebAssembly_8_0_0
                )
            )
        );

        public IEnumerable<Action<XElement>> Console_Net_8 => Instances.EnumerableOperator.From(
            Instances.ProjectXElementOperations.Set_SDK_NET,
            Instances.ProjectXElementOperations.In_NewPropertyGroupXElementContext(
                Instances.PropertyGroupXElementOperations.Set_OutputType_Exe,
                Instances.PropertyGroupXElementOperations.Set_TargetFramework_Default,
                Instances.PropertyGroupXElementOperations.Enable_ImplicitUsings,
                Instances.PropertyGroupXElementOperations.Enable_Nullable
            )
        );
    }
}
