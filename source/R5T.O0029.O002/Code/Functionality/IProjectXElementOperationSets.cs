using System;
using System.Collections.Generic;
using System.Xml.Linq;

using R5T.T0132;


namespace R5T.O0029.O002
{
    /// <summary>
    /// Rivet-domain Visual Studio project file XElement operation sets.
    /// </summary>
    [FunctionalityMarker]
    public partial interface IProjectXElementOperationSets : IFunctionalityMarker
    {
        public IEnumerable<Action<XElement>> BlazorWebAssemblyClient_Net_8(
            string projectDescription,
            string author,
            Action<XElement> setRepositoryUrl = default
        )
            => Instances.EnumerableOperator.From(
                Instances.ProjectXElementOperations.Set_SDK_BlazorWebAssembly,
                Instances.ProjectXElementOperations.In_NewPropertyGroupXElementContext(
                    Instances.PropertyGroupXElementOperations.Set_Label_Main,
                    Instances.PropertyGroupXElementOperations.Set_TargetFramework_Net8,
                    Instances.PropertyGroupXElementOperations.Enable_Nullable,
                    Instances.PropertyGroupXElementOperations.Set_NoDefaultLaunchSettingsFile,
                    Instances.PropertyGroupXElementOperations.Set_StaticWebAssetProjectMode_Default
                ),
                Instances.ProjectXElementOperations.In_NewPropertyGroupXElementContext(
                        Instances.PropertyGroupXElementOperations.Set_Label_Package,
                        Instances.PropertyGroupXElementOperations.Set_Version_Initial_Default,
                        Instances.PropertyGroupXElementOperations.Set_Authors(
                            author
                        ),
                        Instances.PropertyGroupXElementOperations.Set_Company_Rivet,
                        Instances.PropertyGroupXElementOperations.Set_Copyright_Rivet,
                        Instances.PropertyGroupXElementOperations.Set_Description(projectDescription),
                        Instances.PropertyGroupXElementOperations.Set_PackageLicenseExpression_MIT,
                        Instances.PropertyGroupXElementOperations.Set_PackageRequireLicenseAcceptance,
                        setRepositoryUrl
                    ),
                Instances.ProjectXElementOperations.In_NewItemGroupXElementContext(
                    Instances.PropertyGroupXElementOperations.Set_Label_PackageReferences,
                    Instances.ItemGroupXElementOperations.Add_PackageReference(
                        Instances.PackageReferences.Microsoft_AspNetCore_Components_WebAssembly_8_0_0
                    )
                )
            );

        public IEnumerable<Action<XElement>> Console_Net_8(
            string expectedProjectFilePath,
            string projectDescription,
            string author,
            IEnumerable<string> referenceProjectFilePaths,
            Action<XElement> setRepositoryUrl = default
        )
            => Instances.EnumerableOperator.From(
                Instances.ProjectXElementOperations.Set_SDK_NET,
                Instances.ProjectXElementOperations.In_NewPropertyGroupXElementContext(
                    Instances.PropertyGroupXElementOperations.Set_Label_Main,
                    Instances.PropertyGroupXElementOperations.Set_OutputType_Exe,
                    Instances.PropertyGroupXElementOperations.Set_TargetFramework_Default,
                    Instances.PropertyGroupXElementOperations.Enable_ImplicitUsings,
                    Instances.PropertyGroupXElementOperations.Enable_Nullable
                ),
                Instances.ProjectXElementOperations.In_NewPropertyGroupXElementContext(
                    Instances.PropertyGroupXElementOperations.Set_Label_Package,
                    Instances.PropertyGroupXElementOperations.Set_Version_Initial_Default,
                    Instances.PropertyGroupXElementOperations.Set_Authors(
                        author
                    ),
                    Instances.PropertyGroupXElementOperations.Set_Company_Rivet,
                    Instances.PropertyGroupXElementOperations.Set_Copyright_Rivet,
                    Instances.PropertyGroupXElementOperations.Set_Description(projectDescription),
                    Instances.PropertyGroupXElementOperations.Set_PackageLicenseExpression_MIT,
                    Instances.PropertyGroupXElementOperations.Set_PackageRequireLicenseAcceptance,
                    setRepositoryUrl
                ),
                Instances.ProjectXElementOperations.In_NewItemGroupXElementContext(
                    Instances.ItemGroupXElementOperations.Set_Label_ProjectReferences,
                    Instances.ItemGroupXElementOperations.Add_ProjectReferences(
                        expectedProjectFilePath,
                        referenceProjectFilePaths)
                )
            );

        public IEnumerable<Action<XElement>> Console_WithCOMReference(
            string expectedProjectFilePath,
            string projectDescription,
            string author,
            IEnumerable<string> referenceProjectFilePaths,
            Action<XElement> setRepositoryUrl = default
        )
            => Instances.EnumerableOperator.From(
                Instances.ProjectXElementOperations.Set_SDK_NET,
                Instances.ProjectXElementOperations.In_NewPropertyGroupXElementContext(
                    Instances.PropertyGroupXElementOperations.Set_Label_Main,
                    Instances.PropertyGroupXElementOperations.Set_OutputType_Exe,
                    Instances.PropertyGroupXElementOperations.Set_TargetFramework_Default,
                    Instances.PropertyGroupXElementOperations.Enable_ImplicitUsings,
                    Instances.PropertyGroupXElementOperations.Enable_Nullable
                ),
                Instances.ProjectXElementOperations.In_NewPropertyGroupXElementContext(
                    Instances.PropertyGroupXElementOperations.Set_Label_Package,
                    Instances.PropertyGroupXElementOperations.Set_Version_Initial_Default,
                    Instances.PropertyGroupXElementOperations.Set_Authors(
                        author
                    ),
                    Instances.PropertyGroupXElementOperations.Set_Company_Rivet,
                    Instances.PropertyGroupXElementOperations.Set_Copyright_Rivet,
                    Instances.PropertyGroupXElementOperations.Set_Description(projectDescription),
                    Instances.PropertyGroupXElementOperations.Set_PackageLicenseExpression_MIT,
                    Instances.PropertyGroupXElementOperations.Set_PackageRequireLicenseAcceptance,
                    setRepositoryUrl
                ),
                Instances.ProjectXElementOperations.In_NewItemGroupXElementContext(
                    Instances.ItemGroupXElementOperations.Set_Label_ProjectReferences,
                    Instances.ItemGroupXElementOperations.Add_ProjectReferences(
                        expectedProjectFilePath,
                        referenceProjectFilePaths)
                ),
                Instances.ProjectXElementOperations.In_NewItemGroupXElementContext(
                    Instances.ItemGroupXElementOperations.Set_Label_COMReferences,
                    Instances.ItemGroupXElementOperations.Add_COMReference(
                        Instances.COMReferences.Microsoft_Office_Interop_Excel)
                )
            );
    }
}
