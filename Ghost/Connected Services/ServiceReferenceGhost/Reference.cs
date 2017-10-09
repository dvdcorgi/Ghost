﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ghost.ServiceReferenceGhost {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceGhost.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/LogIn", ReplyAction="http://tempuri.org/IService/LogInResponse")]
        void LogIn(string user, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/LogIn", ReplyAction="http://tempuri.org/IService/LogInResponse")]
        System.Threading.Tasks.Task LogInAsync(string user, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetSub", ReplyAction="http://tempuri.org/IService/GetSubResponse")]
        void GetSub();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetSub", ReplyAction="http://tempuri.org/IService/GetSubResponse")]
        System.Threading.Tasks.Task GetSubAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Get", ReplyAction="http://tempuri.org/IService/GetResponse")]
        int Get();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Get", ReplyAction="http://tempuri.org/IService/GetResponse")]
        System.Threading.Tasks.Task<int> GetAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetSync", ReplyAction="http://tempuri.org/IService/GetSyncResponse")]
        int GetSync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetSync", ReplyAction="http://tempuri.org/IService/GetSyncResponse")]
        System.Threading.Tasks.Task<int> GetSyncAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : Ghost.ServiceReferenceGhost.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<Ghost.ServiceReferenceGhost.IService>, Ghost.ServiceReferenceGhost.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void LogIn(string user, string pass) {
            base.Channel.LogIn(user, pass);
        }
        
        public System.Threading.Tasks.Task LogInAsync(string user, string pass) {
            return base.Channel.LogInAsync(user, pass);
        }
        
        public void GetSub() {
            base.Channel.GetSub();
        }
        
        public System.Threading.Tasks.Task GetSubAsync() {
            return base.Channel.GetSubAsync();
        }
        
        public int Get() {
            return base.Channel.Get();
        }
        
        public System.Threading.Tasks.Task<int> GetAsync() {
            return base.Channel.GetAsync();
        }
        
        public int GetSync() {
            return base.Channel.GetSync();
        }
        
        public System.Threading.Tasks.Task<int> GetSyncAsync() {
            return base.Channel.GetSyncAsync();
        }
    }
}
