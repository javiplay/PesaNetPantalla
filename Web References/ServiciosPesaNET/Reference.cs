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
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("ServiciosPesaNET/IServiciosDePantalla/IniciarProceso", RequestNamespace="ServiciosPesaNET", ResponseNamespace="ServiciosPesaNET", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public RespuestaDeIniciarProceso IniciarProceso(PeticionParaIniciarProceso peticion) {
            object[] results = this.Invoke("IniciarProceso", new object[] {
                        peticion});
            return ((RespuestaDeIniciarProceso)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginIniciarProceso(PeticionParaIniciarProceso peticion, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("IniciarProceso", new object[] {
                        peticion}, callback, asyncState);
        }
        
        /// <remarks/>
        public RespuestaDeIniciarProceso EndIniciarProceso(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((RespuestaDeIniciarProceso)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("ServiciosPesaNET/IServiciosDePantalla/ActualizarProceso", RequestNamespace="ServiciosPesaNET", ResponseNamespace="ServiciosPesaNET", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public RespuestaDeActualizarProceso ActualizarProceso(PeticionParaActualizarProceso peticion) {
            object[] results = this.Invoke("ActualizarProceso", new object[] {
                        peticion});
            return ((RespuestaDeActualizarProceso)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginActualizarProceso(PeticionParaActualizarProceso peticion, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ActualizarProceso", new object[] {
                        peticion}, callback, asyncState);
        }
        
        /// <remarks/>
        public RespuestaDeActualizarProceso EndActualizarProceso(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((RespuestaDeActualizarProceso)(results[0]));
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="ServiciosPesaNET")]
    public partial class PeticionParaComprobarProductor {
        
        private int lineaField;
        
        private System.Nullable<int> codigoField;
        
        private System.Nullable<int> tagField;
        
        /// <remarks/>
        public int Linea {
            get {
                return this.lineaField;
            }
            set {
                this.lineaField = value;
            }
        }
        
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
    public partial class TimeSpan {
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="ServiciosPesaNET")]
    public partial class RespuestaDeActualizarProceso {
        
        private bool finalizadoField;
        
        private double parcialField;
        
        private double totalField;
        
        private TimeSpan duracionField;
        
        /// <remarks/>
        public bool Finalizado {
            get {
                return this.finalizadoField;
            }
            set {
                this.finalizadoField = value;
            }
        }
        
        /// <remarks/>
        public double Parcial {
            get {
                return this.parcialField;
            }
            set {
                this.parcialField = value;
            }
        }
        
        /// <remarks/>
        public double Total {
            get {
                return this.totalField;
            }
            set {
                this.totalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public TimeSpan Duracion {
            get {
                return this.duracionField;
            }
            set {
                this.duracionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="ServiciosPesaNET")]
    public partial class PeticionParaActualizarProceso {
        
        private int lineaField;
        
        /// <remarks/>
        public int Linea {
            get {
                return this.lineaField;
            }
            set {
                this.lineaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="ServiciosPesaNET")]
    public partial class RespuestaDeIniciarProceso {
        
        private bool procesoIniciadoField;
        
        /// <remarks/>
        public bool ProcesoIniciado {
            get {
                return this.procesoIniciadoField;
            }
            set {
                this.procesoIniciadoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="ServiciosPesaNET")]
    public partial class PeticionParaIniciarProceso {
        
        private ProductorWCF productorField;
        
        private PlantacionWCF plantacionField;
        
        private VehiculoWCF vehiculoField;
        
        private MedianeriaWCF medianeriaField;
        
        private CalidadWCF calidadField;
        
        private VariedadWCF variedadField;
        
        private int lineaField;
        
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
        public PlantacionWCF Plantacion {
            get {
                return this.plantacionField;
            }
            set {
                this.plantacionField = value;
            }
        }
        
        /// <remarks/>
        public VehiculoWCF Vehiculo {
            get {
                return this.vehiculoField;
            }
            set {
                this.vehiculoField = value;
            }
        }
        
        /// <remarks/>
        public MedianeriaWCF Medianeria {
            get {
                return this.medianeriaField;
            }
            set {
                this.medianeriaField = value;
            }
        }
        
        /// <remarks/>
        public CalidadWCF Calidad {
            get {
                return this.calidadField;
            }
            set {
                this.calidadField = value;
            }
        }
        
        /// <remarks/>
        public VariedadWCF Variedad {
            get {
                return this.variedadField;
            }
            set {
                this.variedadField = value;
            }
        }
        
        /// <remarks/>
        public int Linea {
            get {
                return this.lineaField;
            }
            set {
                this.lineaField = value;
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
        
        private string mostrarField;
        
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
        
        /// <remarks/>
        public string Mostrar {
            get {
                return this.mostrarField;
            }
            set {
                this.mostrarField = value;
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
        
        private string mostrarField;
        
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
        
        /// <remarks/>
        public string Mostrar {
            get {
                return this.mostrarField;
            }
            set {
                this.mostrarField = value;
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
        
        private string mostrarField;
        
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
        public string Mostrar {
            get {
                return this.mostrarField;
            }
            set {
                this.mostrarField = value;
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
        
        private string mostrarField;
        
        private MedianeroWCF[] medianerosField;
        
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
        public string Mostrar {
            get {
                return this.mostrarField;
            }
            set {
                this.mostrarField = value;
            }
        }
        
        /// <remarks/>
        public MedianeroWCF[] Medianeros {
            get {
                return this.medianerosField;
            }
            set {
                this.medianerosField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="ServiciosPesaNET")]
    public partial class MedianeroWCF {
        
        private ProductorWCF productorField;
        
        private double porcentajeField;
        
        private string mostrarField;
        
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
        public double Porcentaje {
            get {
                return this.porcentajeField;
            }
            set {
                this.porcentajeField = value;
            }
        }
        
        /// <remarks/>
        public string Mostrar {
            get {
                return this.mostrarField;
            }
            set {
                this.mostrarField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="ServiciosPesaNET")]
    public partial class CalidadWCF {
        
        private System.Nullable<int> idField;
        
        private string nombreField;
        
        private string mostrarField;
        
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
        public string Mostrar {
            get {
                return this.mostrarField;
            }
            set {
                this.mostrarField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="ServiciosPesaNET")]
    public partial class VariedadWCF {
        
        private System.Nullable<int> idField;
        
        private string nombreField;
        
        private string mostrarField;
        
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
        public string Mostrar {
            get {
                return this.mostrarField;
            }
            set {
                this.mostrarField = value;
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
        
        private CalidadWCF[] calidadesField;
        
        private VariedadWCF[] variedadesField;
        
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
        
        /// <remarks/>
        public CalidadWCF[] Calidades {
            get {
                return this.calidadesField;
            }
            set {
                this.calidadesField = value;
            }
        }
        
        /// <remarks/>
        public VariedadWCF[] Variedades {
            get {
                return this.variedadesField;
            }
            set {
                this.variedadesField = value;
            }
        }
    }
}
