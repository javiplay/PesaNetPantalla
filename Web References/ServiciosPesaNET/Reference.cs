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
namespace SolucionPesaNetPantalla.ServiciosPesaNET {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IServiciosDePantalla", Namespace="http://tempuri.org/")]
    public partial class ServiciosDePantalla : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public ServiciosDePantalla() {
            this.Url = "http://localhost:8000/ServiciosPesaNET";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("ServiciosPesaNET/IServiciosDePantalla/ComprobarProductor", RequestNamespace="ServiciosPesaNET", ResponseNamespace="ServiciosPesaNET", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public RespuestaDeComprobarProductor ComprobarProductor(PeticionParaComprobarProductor peticion) {
            object[] results = this.Invoke("ComprobarProductor", new object[] {
                        peticion});
            return ((RespuestaDeComprobarProductor)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginComprobarProductor(PeticionParaComprobarProductor peticion, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ComprobarProductor", new object[] {
                        peticion}, callback, asyncState);
        }
        
        /// <remarks/>
        public RespuestaDeComprobarProductor EndComprobarProductor(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((RespuestaDeComprobarProductor)(results[0]));
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="ServiciosPesaNET")]
    public partial class PeticionParaComprobarProductor {
        
        private System.Nullable<int> codigoField;
        
        private System.Nullable<int> tagField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> Codigo {
            get {
                return this.codigoField;
            }
            set {
                this.codigoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> Tag {
            get {
                return this.tagField;
            }
            set {
                this.tagField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="ServiciosPesaNET")]
    public partial class VehiculoWCF {
        
        private System.Nullable<int> idField;
        
        private string nombreField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string Nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="ServiciosPesaNET")]
    public partial class MedianeriaWCF {
        
        private System.Nullable<int> idField;
        
        private string nombreField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string Nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="ServiciosPesaNET")]
    public partial class PlantacionWCF {
        
        private System.Nullable<int> idField;
        
        private string nombreField;
        
        private string terminoField;
        
        private string codigoField;
        
        private string poligonoField;
        
        private string parcelaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string Nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
            }
        }
        
        /// <remarks/>
        public string Termino {
            get {
                return this.terminoField;
            }
            set {
                this.terminoField = value;
            }
        }
        
        /// <remarks/>
        public string Codigo {
            get {
                return this.codigoField;
            }
            set {
                this.codigoField = value;
            }
        }
        
        /// <remarks/>
        public string Poligono {
            get {
                return this.poligonoField;
            }
            set {
                this.poligonoField = value;
            }
        }
        
        /// <remarks/>
        public string Parcela {
            get {
                return this.parcelaField;
            }
            set {
                this.parcelaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="ServiciosPesaNET")]
    public partial class ProductorWCF {
        
        private System.Nullable<int> idField;
        
        private int codigoField;
        
        private string nombreField;
        
        private string apellidosField;
        
        private string nIFField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public int Codigo {
            get {
                return this.codigoField;
            }
            set {
                this.codigoField = value;
            }
        }
        
        /// <remarks/>
        public string Nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
            }
        }
        
        /// <remarks/>
        public string Apellidos {
            get {
                return this.apellidosField;
            }
            set {
                this.apellidosField = value;
            }
        }
        
        /// <remarks/>
        public string NIF {
            get {
                return this.nIFField;
            }
            set {
                this.nIFField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="ServiciosPesaNET")]
    public partial class RespuestaDeComprobarProductor {
        
        private bool existeField;
        
        private ProductorWCF productorField;
        
        private PlantacionWCF[] plantacionesField;
        
        private MedianeriaWCF[] medianeriasField;
        
        private VehiculoWCF[] vehiculosField;
        
        /// <remarks/>
        public bool Existe {
            get {
                return this.existeField;
            }
            set {
                this.existeField = value;
            }
        }
        
        /// <remarks/>
        public ProductorWCF Productor {
            get {
                return this.productorField;
            }
            set {
                this.productorField = value;
            }
        }
        
        /// <remarks/>
        public PlantacionWCF[] Plantaciones {
            get {
                return this.plantacionesField;
            }
            set {
                this.plantacionesField = value;
            }
        }
        
        /// <remarks/>
        public MedianeriaWCF[] Medianerias {
            get {
                return this.medianeriasField;
            }
            set {
                this.medianeriasField = value;
            }
        }
        
        /// <remarks/>
        public VehiculoWCF[] Vehiculos {
            get {
                return this.vehiculosField;
            }
            set {
                this.vehiculosField = value;
            }
        }
    }
}