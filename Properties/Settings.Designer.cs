﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Tento kód byl generován nástrojem.
//     Verze modulu runtime:4.0.30319.42000
//
//     Změny tohoto souboru mohou způsobit nesprávné chování a budou ztraceny,
//     dojde-li k novému generování kódu.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AntiIniUI.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"; ConsoleVariables.ini
;
; This file allows to set console variables on engine startup (In undefined order).
; Console variables also can be set in engine ini files (e.g. BaseEngine.ini, DefaultEngine.ini) in the [SystemSettings] section.
; This file should be in the source control database (for the comments and to know where to find it)
; but kept empty from variables.
; A developer can change it locally to save time not having to type repetitive
; console variable settings. The variables need to be in the section called [Startup].
; Later on we might have multiple named sections referenced by the section name.
; This would allow platform specific or level specific overrides.
; The name comparison is not case sensitive and if the variable doesn't exists it's silently ignored.
;
; Example file content:
;
; [Startup]
; FogDensity = 0.9
; ImageGrain = 0.5
; FreezeAtPosition = 2819.5520 416.2633 75.1500 65378 -25879 0

[Startup]

; Uncomment to get detailed logs on shader compiles and the opportunity to retry on errors
;r.ShaderDevelopmentMode=1
; Uncomment to dump shaders in the Saved folder
; Warning: leaving this on for a while will fill your hard drive with many small files and folders
;r.DumpShaderDebugInfo=1
; Uncomment to enable parallel rendering at startup
;r.RHICmdBypass=0
; Uncomment to enable nvidia aftermath to help track down GPU/driver crashes
r.GPUCrashDebugging=1
")]
        public string DefaultData {
            get {
                return ((string)(this["DefaultData"]));
            }
        }
    }
}
