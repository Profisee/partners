//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XamlStaticHelperNamespace {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "17.0.0.0")]
    internal class _XamlStaticHelper {
        
        private static System.WeakReference schemaContextField;
        
        private static System.Collections.Generic.IList<System.Reflection.Assembly> assemblyListField;
        
        internal static System.Xaml.XamlSchemaContext SchemaContext {
            get {
                System.Xaml.XamlSchemaContext xsc = null;
                if ((schemaContextField != null)) {
                    xsc = ((System.Xaml.XamlSchemaContext)(schemaContextField.Target));
                    if ((xsc != null)) {
                        return xsc;
                    }
                }
                if ((AssemblyList.Count > 0)) {
                    xsc = new System.Xaml.XamlSchemaContext(AssemblyList);
                }
                else {
                    xsc = new System.Xaml.XamlSchemaContext();
                }
                schemaContextField = new System.WeakReference(xsc);
                return xsc;
            }
        }
        
        internal static System.Collections.Generic.IList<System.Reflection.Assembly> AssemblyList {
            get {
                if ((assemblyListField == null)) {
                    assemblyListField = LoadAssemblies();
                }
                return assemblyListField;
            }
        }
        
        private static System.Collections.Generic.IList<System.Reflection.Assembly> LoadAssemblies() {
            System.Collections.Generic.IList<System.Reflection.Assembly> assemblyList = new System.Collections.Generic.List<System.Reflection.Assembly>();
            assemblyList.Add(Load("Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a" +
                        "3a"));
            assemblyList.Add(Load("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
            assemblyList.Add(Load("netstandard, Version=2.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51"));
            assemblyList.Add(Load("PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e" +
                        "35"));
            assemblyList.Add(Load("PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856a" +
                        "d364e35"));
            assemblyList.Add(Load("System.Activities, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364" +
                        "e35"));
            assemblyList.Add(Load("System.Activities.Presentation, Version=4.0.0.0, Culture=neutral, PublicKeyToken=" +
                        "31bf3856ad364e35"));
            assemblyList.Add(Load("System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
            assemblyList.Add(Load("System.Data.DataSetExtensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b" +
                        "77a5c561934e089"));
            assemblyList.Add(Load("System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
            assemblyList.Add(Load("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
            assemblyList.Add(Load("System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" +
                        ""));
            assemblyList.Add(Load("System.Runtime.Serialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b7" +
                        "7a5c561934e089"));
            assemblyList.Add(Load("System.ServiceModel.Activities, Version=4.0.0.0, Culture=neutral, PublicKeyToken=" +
                        "31bf3856ad364e35"));
            assemblyList.Add(Load("System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c56193" +
                        "4e089"));
            assemblyList.Add(Load("System.Workflow.Activities, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf" +
                        "3856ad364e35"));
            assemblyList.Add(Load("System.Workflow.ComponentModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=" +
                        "31bf3856ad364e35"));
            assemblyList.Add(Load("System.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
            assemblyList.Add(Load("System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
            assemblyList.Add(Load("System.Xml.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e08" +
                        "9"));
            assemblyList.Add(Load("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"));
            assemblyList.Add(Load("Profisee.Platform.CoreData.Contracts, Version=1.0.0.1, Culture=neutral, PublicKey" +
                        "Token=74ffafc013917215"));
            assemblyList.Add(Load("Profisee.Platform.Services.AddressVerification.Contracts, Version=1.0.0.1, Cultur" +
                        "e=neutral, PublicKeyToken=74ffafc013917215"));
            assemblyList.Add(Load("Profisee.Platform.Services.Matching.Contracts, Version=1.0.0.1, Culture=neutral, " +
                        "PublicKeyToken=74ffafc013917215"));
            assemblyList.Add(Load("Profisee.Platform.Workflow.Activities, Version=3.2.1.0, Culture=neutral, PublicKe" +
                        "yToken=74ffafc013917215"));
            assemblyList.Add(Load("Profisee.Platform.Workflow.Common, Version=3.2.1.0, Culture=neutral, PublicKeyTok" +
                        "en=74ffafc013917215"));
            assemblyList.Add(Load("Profisee.Platform.Workflow.Contracts, Version=3.2.1.0, Culture=neutral, PublicKey" +
                        "Token=74ffafc013917215"));
            assemblyList.Add(System.Reflection.Assembly.GetExecutingAssembly());
            return assemblyList;
        }
        
        private static System.Reflection.Assembly Load(string assemblyNameVal) {
            System.Reflection.AssemblyName assemblyName = new System.Reflection.AssemblyName(assemblyNameVal);
            byte[] publicKeyToken = assemblyName.GetPublicKeyToken();
            System.Reflection.Assembly asm = null;
            try {
                asm = System.Reflection.Assembly.Load(assemblyName.FullName);
            }
            catch (System.Exception ) {
                System.Reflection.AssemblyName shortName = new System.Reflection.AssemblyName(assemblyName.Name);
                if ((publicKeyToken != null)) {
                    shortName.SetPublicKeyToken(publicKeyToken);
                }
                asm = System.Reflection.Assembly.Load(shortName);
            }
            return asm;
        }
    }
}
