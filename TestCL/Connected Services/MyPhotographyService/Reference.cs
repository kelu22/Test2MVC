﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestCL.MyPhotographyService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyPhotographyService.IMyPhotographyInfoService")]
    public interface IMyPhotographyInfoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyPhotographyInfoService/GetImagesUsingDBWithConfig", ReplyAction="http://tempuri.org/IMyPhotographyInfoService/GetImagesUsingDBWithConfigResponse")]
        System.Data.DataSet GetImagesUsingDBWithConfig();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyPhotographyInfoService/GetImagesUsingDBWithConfig", ReplyAction="http://tempuri.org/IMyPhotographyInfoService/GetImagesUsingDBWithConfigResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetImagesUsingDBWithConfigAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyPhotographyInfoService/GetContactUsingDBWithConfig", ReplyAction="http://tempuri.org/IMyPhotographyInfoService/GetContactUsingDBWithConfigResponse")]
        System.Data.DataSet GetContactUsingDBWithConfig();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyPhotographyInfoService/GetContactUsingDBWithConfig", ReplyAction="http://tempuri.org/IMyPhotographyInfoService/GetContactUsingDBWithConfigResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetContactUsingDBWithConfigAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMyPhotographyInfoServiceChannel : TestCL.MyPhotographyService.IMyPhotographyInfoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyPhotographyInfoServiceClient : System.ServiceModel.ClientBase<TestCL.MyPhotographyService.IMyPhotographyInfoService>, TestCL.MyPhotographyService.IMyPhotographyInfoService {
        
        public MyPhotographyInfoServiceClient() {
        }
        
        public MyPhotographyInfoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyPhotographyInfoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyPhotographyInfoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyPhotographyInfoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet GetImagesUsingDBWithConfig() {
            return base.Channel.GetImagesUsingDBWithConfig();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetImagesUsingDBWithConfigAsync() {
            return base.Channel.GetImagesUsingDBWithConfigAsync();
        }
        
        public System.Data.DataSet GetContactUsingDBWithConfig() {
            return base.Channel.GetContactUsingDBWithConfig();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetContactUsingDBWithConfigAsync() {
            return base.Channel.GetContactUsingDBWithConfigAsync();
        }
    }
}
