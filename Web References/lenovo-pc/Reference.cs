﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.8009
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.CompactFramework.Design.Data, Version 2.0.50727.8009.
// 
namespace SolucionPesaNetPantalla.lenovo_pc {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IHelloWorldService", Namespace="http://tempuri.org/")]
    public partial class HelloWorldService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public HelloWorldService() {
            this.Url = "http://localhost:8000/Test";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("TestWCF/IHelloWorldService/SayHello", RequestNamespace="TestWCF", ResponseNamespace="TestWCF", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SayHello(string name) {
            object[] results = this.Invoke("SayHello", new object[] {
                        name});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginSayHello(string name, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("SayHello", new object[] {
                        name}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndSayHello(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
    }
}
