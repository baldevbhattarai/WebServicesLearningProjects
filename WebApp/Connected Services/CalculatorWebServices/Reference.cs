﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp.CalculatorWebServices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://www.baldebbhattarai.com/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.baldebbhattarai.com/", ConfigurationName="CalculatorWebServices.CalculatorWebServiceSoap")]
    public interface CalculatorWebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.baldebbhattarai.com/Add", ReplyAction="*")]
        int Add(int firstNumber, int secondNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.baldebbhattarai.com/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int firstNumber, int secondNumber);
        
        // CODEGEN: Generating message contract since element name GetRecentTransectionResult from namespace http://www.baldebbhattarai.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.baldebbhattarai.com/GetRecentTransection", ReplyAction="*")]
        WebApp.CalculatorWebServices.GetRecentTransectionResponse GetRecentTransection(WebApp.CalculatorWebServices.GetRecentTransectionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.baldebbhattarai.com/GetRecentTransection", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApp.CalculatorWebServices.GetRecentTransectionResponse> GetRecentTransectionAsync(WebApp.CalculatorWebServices.GetRecentTransectionRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRecentTransectionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRecentTransection", Namespace="http://www.baldebbhattarai.com/", Order=0)]
        public WebApp.CalculatorWebServices.GetRecentTransectionRequestBody Body;
        
        public GetRecentTransectionRequest() {
        }
        
        public GetRecentTransectionRequest(WebApp.CalculatorWebServices.GetRecentTransectionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetRecentTransectionRequestBody {
        
        public GetRecentTransectionRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRecentTransectionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRecentTransectionResponse", Namespace="http://www.baldebbhattarai.com/", Order=0)]
        public WebApp.CalculatorWebServices.GetRecentTransectionResponseBody Body;
        
        public GetRecentTransectionResponse() {
        }
        
        public GetRecentTransectionResponse(WebApp.CalculatorWebServices.GetRecentTransectionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.baldebbhattarai.com/")]
    public partial class GetRecentTransectionResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebApp.CalculatorWebServices.ArrayOfString GetRecentTransectionResult;
        
        public GetRecentTransectionResponseBody() {
        }
        
        public GetRecentTransectionResponseBody(WebApp.CalculatorWebServices.ArrayOfString GetRecentTransectionResult) {
            this.GetRecentTransectionResult = GetRecentTransectionResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalculatorWebServiceSoapChannel : WebApp.CalculatorWebServices.CalculatorWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorWebServiceSoapClient : System.ServiceModel.ClientBase<WebApp.CalculatorWebServices.CalculatorWebServiceSoap>, WebApp.CalculatorWebServices.CalculatorWebServiceSoap {
        
        public CalculatorWebServiceSoapClient() {
        }
        
        public CalculatorWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(int firstNumber, int secondNumber) {
            return base.Channel.Add(firstNumber, secondNumber);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int firstNumber, int secondNumber) {
            return base.Channel.AddAsync(firstNumber, secondNumber);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApp.CalculatorWebServices.GetRecentTransectionResponse WebApp.CalculatorWebServices.CalculatorWebServiceSoap.GetRecentTransection(WebApp.CalculatorWebServices.GetRecentTransectionRequest request) {
            return base.Channel.GetRecentTransection(request);
        }
        
        public WebApp.CalculatorWebServices.ArrayOfString GetRecentTransection() {
            WebApp.CalculatorWebServices.GetRecentTransectionRequest inValue = new WebApp.CalculatorWebServices.GetRecentTransectionRequest();
            inValue.Body = new WebApp.CalculatorWebServices.GetRecentTransectionRequestBody();
            WebApp.CalculatorWebServices.GetRecentTransectionResponse retVal = ((WebApp.CalculatorWebServices.CalculatorWebServiceSoap)(this)).GetRecentTransection(inValue);
            return retVal.Body.GetRecentTransectionResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApp.CalculatorWebServices.GetRecentTransectionResponse> WebApp.CalculatorWebServices.CalculatorWebServiceSoap.GetRecentTransectionAsync(WebApp.CalculatorWebServices.GetRecentTransectionRequest request) {
            return base.Channel.GetRecentTransectionAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApp.CalculatorWebServices.GetRecentTransectionResponse> GetRecentTransectionAsync() {
            WebApp.CalculatorWebServices.GetRecentTransectionRequest inValue = new WebApp.CalculatorWebServices.GetRecentTransectionRequest();
            inValue.Body = new WebApp.CalculatorWebServices.GetRecentTransectionRequestBody();
            return ((WebApp.CalculatorWebServices.CalculatorWebServiceSoap)(this)).GetRecentTransectionAsync(inValue);
        }
    }
}