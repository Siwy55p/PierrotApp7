﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PierrotApp7.ServiceReference1DEMO {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ParametryWyszukiwania", Namespace="http://CIS/BIR/PUBL/2014/07/DataContract")]
    [System.SerializableAttribute()]
    public partial class ParametryWyszukiwania : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KrsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KrsyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NipField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NipyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RegonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Regony14znField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Regony9znField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Krs {
            get {
                return this.KrsField;
            }
            set {
                if ((object.ReferenceEquals(this.KrsField, value) != true)) {
                    this.KrsField = value;
                    this.RaisePropertyChanged("Krs");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Krsy {
            get {
                return this.KrsyField;
            }
            set {
                if ((object.ReferenceEquals(this.KrsyField, value) != true)) {
                    this.KrsyField = value;
                    this.RaisePropertyChanged("Krsy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nip {
            get {
                return this.NipField;
            }
            set {
                if ((object.ReferenceEquals(this.NipField, value) != true)) {
                    this.NipField = value;
                    this.RaisePropertyChanged("Nip");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nipy {
            get {
                return this.NipyField;
            }
            set {
                if ((object.ReferenceEquals(this.NipyField, value) != true)) {
                    this.NipyField = value;
                    this.RaisePropertyChanged("Nipy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Regon {
            get {
                return this.RegonField;
            }
            set {
                if ((object.ReferenceEquals(this.RegonField, value) != true)) {
                    this.RegonField = value;
                    this.RaisePropertyChanged("Regon");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Regony14zn {
            get {
                return this.Regony14znField;
            }
            set {
                if ((object.ReferenceEquals(this.Regony14znField, value) != true)) {
                    this.Regony14znField = value;
                    this.RaisePropertyChanged("Regony14zn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Regony9zn {
            get {
                return this.Regony9znField;
            }
            set {
                if ((object.ReferenceEquals(this.Regony9znField, value) != true)) {
                    this.Regony9znField = value;
                    this.RaisePropertyChanged("Regony9zn");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1DEMO.IUslugaBIRzewnPubl")]
    public interface IUslugaBIRzewnPubl {
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ przestrzeń nazw otoki (http://CIS/BIR/2014/07) komunikatu GetValueRequest nie pasuje do domyślnej wartości (http://tempuri.org/).
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/2014/07/IUslugaBIR/GetValue", ReplyAction="http://CIS/BIR/2014/07/IUslugaBIR/GetValueResponse")]
        PierrotApp7.ServiceReference1DEMO.GetValueResponse GetValue(PierrotApp7.ServiceReference1DEMO.GetValueRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/2014/07/IUslugaBIR/GetValue", ReplyAction="http://CIS/BIR/2014/07/IUslugaBIR/GetValueResponse")]
        System.Threading.Tasks.Task<PierrotApp7.ServiceReference1DEMO.GetValueResponse> GetValueAsync(PierrotApp7.ServiceReference1DEMO.GetValueRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ przestrzeń nazw otoki (http://CIS/BIR/PUBL/2014/07) komunikatu ZalogujRequest nie pasuje do domyślnej wartości (http://tempuri.org/).
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/Zaloguj", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/ZalogujResponse")]
        PierrotApp7.ServiceReference1DEMO.ZalogujResponse Zaloguj(PierrotApp7.ServiceReference1DEMO.ZalogujRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/Zaloguj", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/ZalogujResponse")]
        System.Threading.Tasks.Task<PierrotApp7.ServiceReference1DEMO.ZalogujResponse> ZalogujAsync(PierrotApp7.ServiceReference1DEMO.ZalogujRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ przestrzeń nazw otoki (http://CIS/BIR/PUBL/2014/07) komunikatu WylogujRequest nie pasuje do domyślnej wartości (http://tempuri.org/).
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/Wyloguj", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/WylogujResponse")]
        PierrotApp7.ServiceReference1DEMO.WylogujResponse Wyloguj(PierrotApp7.ServiceReference1DEMO.WylogujRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/Wyloguj", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/WylogujResponse")]
        System.Threading.Tasks.Task<PierrotApp7.ServiceReference1DEMO.WylogujResponse> WylogujAsync(PierrotApp7.ServiceReference1DEMO.WylogujRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ przestrzeń nazw otoki (http://CIS/BIR/PUBL/2014/07) komunikatu DaneSzukajPodmiotyRequest nie pasuje do domyślnej wartości (http://tempuri.org/).
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DaneSzukajPodmioty", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DaneSzukajPodmiotyResponse")]
        PierrotApp7.ServiceReference1DEMO.DaneSzukajPodmiotyResponse DaneSzukajPodmioty(PierrotApp7.ServiceReference1DEMO.DaneSzukajPodmiotyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DaneSzukajPodmioty", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DaneSzukajPodmiotyResponse")]
        System.Threading.Tasks.Task<PierrotApp7.ServiceReference1DEMO.DaneSzukajPodmiotyResponse> DaneSzukajPodmiotyAsync(PierrotApp7.ServiceReference1DEMO.DaneSzukajPodmiotyRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ przestrzeń nazw otoki (http://CIS/BIR/PUBL/2014/07) komunikatu DanePobierzPelnyRaportRequest nie pasuje do domyślnej wartości (http://tempuri.org/).
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzPelnyRaport", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzPelnyRaportResponse")]
        PierrotApp7.ServiceReference1DEMO.DanePobierzPelnyRaportResponse DanePobierzPelnyRaport(PierrotApp7.ServiceReference1DEMO.DanePobierzPelnyRaportRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzPelnyRaport", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzPelnyRaportResponse")]
        System.Threading.Tasks.Task<PierrotApp7.ServiceReference1DEMO.DanePobierzPelnyRaportResponse> DanePobierzPelnyRaportAsync(PierrotApp7.ServiceReference1DEMO.DanePobierzPelnyRaportRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ przestrzeń nazw otoki (http://CIS/BIR/PUBL/2014/07) komunikatu DanePobierzRaportZbiorczyRequest nie pasuje do domyślnej wartości (http://tempuri.org/).
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzRaportZbiorczy", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzRaportZbiorczyResponse")]
        PierrotApp7.ServiceReference1DEMO.DanePobierzRaportZbiorczyResponse DanePobierzRaportZbiorczy(PierrotApp7.ServiceReference1DEMO.DanePobierzRaportZbiorczyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzRaportZbiorczy", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzRaportZbiorczyResponse")]
        System.Threading.Tasks.Task<PierrotApp7.ServiceReference1DEMO.DanePobierzRaportZbiorczyResponse> DanePobierzRaportZbiorczyAsync(PierrotApp7.ServiceReference1DEMO.DanePobierzRaportZbiorczyRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetValue", WrapperNamespace="http://CIS/BIR/2014/07", IsWrapped=true)]
    public partial class GetValueRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/2014/07", Order=0)]
        public string pNazwaParametru;
        
        public GetValueRequest() {
        }
        
        public GetValueRequest(string pNazwaParametru) {
            this.pNazwaParametru = pNazwaParametru;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetValueResponse", WrapperNamespace="http://CIS/BIR/2014/07", IsWrapped=true)]
    public partial class GetValueResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/2014/07", Order=0)]
        public string GetValueResult;
        
        public GetValueResponse() {
        }
        
        public GetValueResponse(string GetValueResult) {
            this.GetValueResult = GetValueResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Zaloguj", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class ZalogujRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string pKluczUzytkownika;
        
        public ZalogujRequest() {
        }
        
        public ZalogujRequest(string pKluczUzytkownika) {
            this.pKluczUzytkownika = pKluczUzytkownika;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ZalogujResponse", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class ZalogujResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string ZalogujResult;
        
        public ZalogujResponse() {
        }
        
        public ZalogujResponse(string ZalogujResult) {
            this.ZalogujResult = ZalogujResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Wyloguj", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class WylogujRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string pIdentyfikatorSesji;
        
        public WylogujRequest() {
        }
        
        public WylogujRequest(string pIdentyfikatorSesji) {
            this.pIdentyfikatorSesji = pIdentyfikatorSesji;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WylogujResponse", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class WylogujResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public bool WylogujResult;
        
        public WylogujResponse() {
        }
        
        public WylogujResponse(bool WylogujResult) {
            this.WylogujResult = WylogujResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DaneSzukajPodmioty", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class DaneSzukajPodmiotyRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public PierrotApp7.ServiceReference1DEMO.ParametryWyszukiwania pParametryWyszukiwania;
        
        public DaneSzukajPodmiotyRequest() {
        }
        
        public DaneSzukajPodmiotyRequest(PierrotApp7.ServiceReference1DEMO.ParametryWyszukiwania pParametryWyszukiwania) {
            this.pParametryWyszukiwania = pParametryWyszukiwania;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DaneSzukajPodmiotyResponse", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class DaneSzukajPodmiotyResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string DaneSzukajPodmiotyResult;
        
        public DaneSzukajPodmiotyResponse() {
        }
        
        public DaneSzukajPodmiotyResponse(string DaneSzukajPodmiotyResult) {
            this.DaneSzukajPodmiotyResult = DaneSzukajPodmiotyResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DanePobierzPelnyRaport", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class DanePobierzPelnyRaportRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string pRegon;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=1)]
        public string pNazwaRaportu;
        
        public DanePobierzPelnyRaportRequest() {
        }
        
        public DanePobierzPelnyRaportRequest(string pRegon, string pNazwaRaportu) {
            this.pRegon = pRegon;
            this.pNazwaRaportu = pNazwaRaportu;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DanePobierzPelnyRaportResponse", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class DanePobierzPelnyRaportResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string DanePobierzPelnyRaportResult;
        
        public DanePobierzPelnyRaportResponse() {
        }
        
        public DanePobierzPelnyRaportResponse(string DanePobierzPelnyRaportResult) {
            this.DanePobierzPelnyRaportResult = DanePobierzPelnyRaportResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DanePobierzRaportZbiorczy", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class DanePobierzRaportZbiorczyRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string pDataRaportu;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=1)]
        public string pNazwaRaportu;
        
        public DanePobierzRaportZbiorczyRequest() {
        }
        
        public DanePobierzRaportZbiorczyRequest(string pDataRaportu, string pNazwaRaportu) {
            this.pDataRaportu = pDataRaportu;
            this.pNazwaRaportu = pNazwaRaportu;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DanePobierzRaportZbiorczyResponse", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class DanePobierzRaportZbiorczyResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string DanePobierzRaportZbiorczyResult;
        
        public DanePobierzRaportZbiorczyResponse() {
        }
        
        public DanePobierzRaportZbiorczyResponse(string DanePobierzRaportZbiorczyResult) {
            this.DanePobierzRaportZbiorczyResult = DanePobierzRaportZbiorczyResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUslugaBIRzewnPublChannel : PierrotApp7.ServiceReference1DEMO.IUslugaBIRzewnPubl, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UslugaBIRzewnPublClient : System.ServiceModel.ClientBase<PierrotApp7.ServiceReference1DEMO.IUslugaBIRzewnPubl>, PierrotApp7.ServiceReference1DEMO.IUslugaBIRzewnPubl {
        
        public UslugaBIRzewnPublClient(System.ServiceModel.WSHttpBinding myBinding) {
        }
        
        public UslugaBIRzewnPublClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UslugaBIRzewnPublClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UslugaBIRzewnPublClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UslugaBIRzewnPublClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PierrotApp7.ServiceReference1DEMO.GetValueResponse PierrotApp7.ServiceReference1DEMO.IUslugaBIRzewnPubl.GetValue(PierrotApp7.ServiceReference1DEMO.GetValueRequest request) {
            return base.Channel.GetValue(request);
        }
        
        public string GetValue(string pNazwaParametru) {
            PierrotApp7.ServiceReference1DEMO.GetValueRequest inValue = new PierrotApp7.ServiceReference1DEMO.GetValueRequest();
            inValue.pNazwaParametru = pNazwaParametru;
            PierrotApp7.ServiceReference1DEMO.GetValueResponse retVal = ((PierrotApp7.ServiceReference1DEMO.IUslugaBIRzewnPubl)(this)).GetValue(inValue);
            return retVal.GetValueResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PierrotApp7.ServiceReference1DEMO.GetValueResponse> PierrotApp7.ServiceReference1DEMO.IUslugaBIRzewnPubl.GetValueAsync(PierrotApp7.ServiceReference1DEMO.GetValueRequest request) {
            return base.Channel.GetValueAsync(request);
        }
        
        public System.Threading.Tasks.Task<PierrotApp7.ServiceReference1DEMO.GetValueResponse> GetValueAsync(string pNazwaParametru) {
            PierrotApp7.ServiceReference1DEMO.GetValueRequest inValue = new PierrotApp7.ServiceReference1DEMO.GetValueRequest();
            inValue.pNazwaParametru = pNazwaParametru;
            return ((PierrotApp7.ServiceReference1DEMO.IUslugaBIRzewnPubl)(this)).GetValueAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PierrotApp7.ServiceReference1DEMO.ZalogujResponse PierrotApp7.ServiceReference1DEMO.IUslugaBIRzewnPubl.Zaloguj(PierrotApp7.ServiceReference1DEMO.ZalogujRequest request) {
            return base.Channel.Zaloguj(request);
        }
        
        public string Zaloguj(string pKluczUzytkownika) {
            PierrotApp7.ServiceReference1DEMO.ZalogujRequest inValue = new PierrotApp7.ServiceReference1DEMO.ZalogujRequest();
            inValue.pKluczUzytkownika = pKluczUzytkownika;
            PierrotApp7.ServiceReference1DEMO.ZalogujResponse retVal = ((PierrotApp7.ServiceReference1DEMO.IUslugaBIRzewnPubl)(this)).Zaloguj(inValue);
            return retVal.ZalogujResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PierrotApp7.ServiceReference1DEMO.ZalogujResponse> PierrotApp7.ServiceReference1DEMO.IUslugaBIRzewnPubl.ZalogujAsync(PierrotApp7.ServiceReference1DEMO.ZalogujRequest request) {
            return base.Channel.ZalogujAsync(request);
        }
        
        public System.Threading.Tasks.Task<PierrotApp7.ServiceReference1DEMO.ZalogujResponse> ZalogujAsync(string pKluczUzytkownika) {
            PierrotApp7.ServiceReference1DEMO.ZalogujRequest inValue = new PierrotApp7.ServiceReference1DEMO.ZalogujRequest();
            inValue.pKluczUzytkownika = pKluczUzytkownika;
            return ((PierrotApp7.ServiceReference1DEMO.IUslugaBIRzewnPubl)(this)).ZalogujAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PierrotApp7.ServiceReference1DEMO.WylogujResponse PierrotApp7.ServiceReference1DEMO.IUslugaBIRzewnPubl.Wyloguj(PierrotApp7.ServiceReference1DEMO.WylogujRequest request) {
            return base.Channel.Wyloguj(request);
        }
        
        public bool Wyloguj(string pIdentyfikatorSesji) {
            PierrotApp7.ServiceReference1DEMO.WylogujRequest inValue = new PierrotApp7.ServiceReference1DEMO.WylogujRequest();
            inValue.pIdentyfikatorSesji = pIdentyfikatorSesji;
            PierrotApp7.ServiceReference1DEMO.WylogujResponse retVal = ((PierrotApp7.ServiceReference1DEMO.IUslugaBIRzewnPubl)(this)).Wyloguj(inValue);
            return retVal.WylogujResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PierrotApp7.ServiceReference1DEMO.WylogujResponse> PierrotApp7.ServiceReference1DEMO.IUslugaBIRzewnPubl.WylogujAsync(PierrotApp7.ServiceReference1DEMO.WylogujRequest request) {
            return base.Channel.WylogujAsync(request);
        }
        
        public System.Threading.Tasks.Task<PierrotApp7.ServiceReference1DEMO.WylogujResponse> WylogujAsync(string pIdentyfikatorSesji) {
            PierrotApp7.ServiceReference1DEMO.WylogujRequest inValue = new PierrotApp7.ServiceReference1DEMO.WylogujRequest();
            inValue.pIdentyfikatorSesji = pIdentyfikatorSesji;
            return ((PierrotApp7.ServiceReference1DEMO.IUslugaBIRzewnPubl)(this)).WylogujAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PierrotApp7.ServiceReference1DEMO.DaneSzukajPodmiotyResponse PierrotApp7.ServiceReference1DEMO.IUslugaBIRzewnPubl.DaneSzukajPodmioty(PierrotApp7.ServiceReference1DEMO.DaneSzukajPodmiotyRequest request) {
            return base.Channel.DaneSzukajPodmioty(request);
        }
        
        public string DaneSzukajPodmioty(PierrotApp7.ServiceReference1DEMO.ParametryWyszukiwania pParametryWyszukiwania) {
            PierrotApp7.ServiceReference1DEMO.DaneSzukajPodmiotyRequest inValue = new PierrotApp7.ServiceReference1DEMO.DaneSzukajPodmiotyRequest();
            inValue.pParametryWyszukiwania = pParametryWyszukiwania;
            PierrotApp7.ServiceReference1DEMO.DaneSzukajPodmiotyResponse retVal = ((PierrotApp7.ServiceReference1DEMO.IUslugaBIRzewnPubl)(this)).DaneSzukajPodmioty(inValue);
            return retVal.DaneSzukajPodmiotyResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PierrotApp7.ServiceReference1DEMO.DaneSzukajPodmiotyResponse> PierrotApp7.ServiceReference1DEMO.IUslugaBIRzewnPubl.DaneSzukajPodmiotyAsync(PierrotApp7.ServiceReference1DEMO.DaneSzukajPodmiotyRequest request) {
            return base.Channel.DaneSzukajPodmiotyAsync(request);
        }
        
        public System.Threading.Tasks.Task<PierrotApp7.ServiceReference1DEMO.DaneSzukajPodmiotyResponse> DaneSzukajPodmiotyAsync(PierrotApp7.ServiceReference1DEMO.ParametryWyszukiwania pParametryWyszukiwania) {
            PierrotApp7.ServiceReference1DEMO.DaneSzukajPodmiotyRequest inValue = new PierrotApp7.ServiceReference1DEMO.DaneSzukajPodmiotyRequest();
            inValue.pParametryWyszukiwania = pParametryWyszukiwania;
            return ((PierrotApp7.ServiceReference1DEMO.IUslugaBIRzewnPubl)(this)).DaneSzukajPodmiotyAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PierrotApp7.ServiceReference1DEMO.DanePobierzPelnyRaportResponse PierrotApp7.ServiceReference1DEMO.IUslugaBIRzewnPubl.DanePobierzPelnyRaport(PierrotApp7.ServiceReference1DEMO.DanePobierzPelnyRaportRequest request) {
            return base.Channel.DanePobierzPelnyRaport(request);
        }
        
        public string DanePobierzPelnyRaport(string pRegon, string pNazwaRaportu) {
            PierrotApp7.ServiceReference1DEMO.DanePobierzPelnyRaportRequest inValue = new PierrotApp7.ServiceReference1DEMO.DanePobierzPelnyRaportRequest();
            inValue.pRegon = pRegon;
            inValue.pNazwaRaportu = pNazwaRaportu;
            PierrotApp7.ServiceReference1DEMO.DanePobierzPelnyRaportResponse retVal = ((PierrotApp7.ServiceReference1DEMO.IUslugaBIRzewnPubl)(this)).DanePobierzPelnyRaport(inValue);
            return retVal.DanePobierzPelnyRaportResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PierrotApp7.ServiceReference1DEMO.DanePobierzPelnyRaportResponse> PierrotApp7.ServiceReference1DEMO.IUslugaBIRzewnPubl.DanePobierzPelnyRaportAsync(PierrotApp7.ServiceReference1DEMO.DanePobierzPelnyRaportRequest request) {
            return base.Channel.DanePobierzPelnyRaportAsync(request);
        }
        
        public System.Threading.Tasks.Task<PierrotApp7.ServiceReference1DEMO.DanePobierzPelnyRaportResponse> DanePobierzPelnyRaportAsync(string pRegon, string pNazwaRaportu) {
            PierrotApp7.ServiceReference1DEMO.DanePobierzPelnyRaportRequest inValue = new PierrotApp7.ServiceReference1DEMO.DanePobierzPelnyRaportRequest();
            inValue.pRegon = pRegon;
            inValue.pNazwaRaportu = pNazwaRaportu;
            return ((PierrotApp7.ServiceReference1DEMO.IUslugaBIRzewnPubl)(this)).DanePobierzPelnyRaportAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PierrotApp7.ServiceReference1DEMO.DanePobierzRaportZbiorczyResponse PierrotApp7.ServiceReference1DEMO.IUslugaBIRzewnPubl.DanePobierzRaportZbiorczy(PierrotApp7.ServiceReference1DEMO.DanePobierzRaportZbiorczyRequest request) {
            return base.Channel.DanePobierzRaportZbiorczy(request);
        }
        
        public string DanePobierzRaportZbiorczy(string pDataRaportu, string pNazwaRaportu) {
            PierrotApp7.ServiceReference1DEMO.DanePobierzRaportZbiorczyRequest inValue = new PierrotApp7.ServiceReference1DEMO.DanePobierzRaportZbiorczyRequest();
            inValue.pDataRaportu = pDataRaportu;
            inValue.pNazwaRaportu = pNazwaRaportu;
            PierrotApp7.ServiceReference1DEMO.DanePobierzRaportZbiorczyResponse retVal = ((PierrotApp7.ServiceReference1DEMO.IUslugaBIRzewnPubl)(this)).DanePobierzRaportZbiorczy(inValue);
            return retVal.DanePobierzRaportZbiorczyResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PierrotApp7.ServiceReference1DEMO.DanePobierzRaportZbiorczyResponse> PierrotApp7.ServiceReference1DEMO.IUslugaBIRzewnPubl.DanePobierzRaportZbiorczyAsync(PierrotApp7.ServiceReference1DEMO.DanePobierzRaportZbiorczyRequest request) {
            return base.Channel.DanePobierzRaportZbiorczyAsync(request);
        }
        
        public System.Threading.Tasks.Task<PierrotApp7.ServiceReference1DEMO.DanePobierzRaportZbiorczyResponse> DanePobierzRaportZbiorczyAsync(string pDataRaportu, string pNazwaRaportu) {
            PierrotApp7.ServiceReference1DEMO.DanePobierzRaportZbiorczyRequest inValue = new PierrotApp7.ServiceReference1DEMO.DanePobierzRaportZbiorczyRequest();
            inValue.pDataRaportu = pDataRaportu;
            inValue.pNazwaRaportu = pNazwaRaportu;
            return ((PierrotApp7.ServiceReference1DEMO.IUslugaBIRzewnPubl)(this)).DanePobierzRaportZbiorczyAsync(inValue);
        }
    }
}
