﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace csgo_tts_ui.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("csgo_tts_ui.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;!--Contains models for the following languages (by ISO 639-3): dan, deu, eng, fra, ita, jpn, kor, nld, nor, por, rus, spa, swe, zho--&gt;
        ///&lt;LanguageIdentificationProfile&gt;
        ///  &lt;Parameters&gt;
        ///    &lt;MaximumSizeOfDistribution&gt;4000&lt;/MaximumSizeOfDistribution&gt;
        ///    &lt;MaxNGramLength&gt;5&lt;/MaxNGramLength&gt;
        ///  &lt;/Parameters&gt;
        ///  &lt;LanguageModels&gt;
        ///    &lt;LanguageModel&gt;
        ///      &lt;Language ISO639-2T=&quot;dan&quot; ISO639-3=&quot;dan&quot; /&gt;
        ///      &lt;metadata /&gt;
        ///      &lt;ngrams totalNoiseCount=&quot;4208189&quot; distinctNoiseCount=&quot;114 [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Core14_profile {
            get {
                return ResourceManager.GetString("Core14_profile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        public static byte[] Newtonsoft_Json {
            get {
                object obj = ResourceManager.GetObject("Newtonsoft_Json", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        public static byte[] NTextCat {
            get {
                object obj = ResourceManager.GetObject("NTextCat", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;doc&gt;
        ///    &lt;assembly&gt;
        ///        &lt;name&gt;NTextCat&lt;/name&gt;
        ///    &lt;/assembly&gt;
        ///    &lt;members&gt;
        ///        &lt;member name=&quot;T:NTextCat.BagOfWordsFeatureExtractor&quot;&gt;
        ///            &lt;summary&gt;
        ///            This implementation is not robust or production ready.
        ///            &lt;/summary&gt;
        ///        &lt;/member&gt;
        ///        &lt;member name=&quot;P:NTextCat.BasicProfileFactoryBase`1.AllowUsingMultipleThreadsForTraining&quot;&gt;
        ///            &lt;summary&gt;
        ///            true if it is allowed to use more than one thread for training
        ///            &lt;/summary&gt; [rest of string was truncated]&quot;;.
        /// </summary>
        public static string NTextCat1 {
            get {
                return ResourceManager.GetString("NTextCat1", resourceCulture);
            }
        }
    }
}
