﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyInterface")]
public interface MyInterface
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MyInterface/PiValue", ReplyAction="http://tempuri.org/MyInterface/PiValueResponse")]
    double PiValue();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MyInterface/PiValue", ReplyAction="http://tempuri.org/MyInterface/PiValueResponse")]
    System.Threading.Tasks.Task<double> PiValueAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MyInterface/AbsValue", ReplyAction="http://tempuri.org/MyInterface/AbsValueResponse")]
    int AbsValue(int value);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MyInterface/AbsValue", ReplyAction="http://tempuri.org/MyInterface/AbsValueResponse")]
    System.Threading.Tasks.Task<int> AbsValueAsync(int value);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface MyInterfaceChannel : MyInterface, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class MyInterfaceClient : System.ServiceModel.ClientBase<MyInterface>, MyInterface
{
    
    public MyInterfaceClient()
    {
    }
    
    public MyInterfaceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public MyInterfaceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public MyInterfaceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public MyInterfaceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public double PiValue()
    {
        return base.Channel.PiValue();
    }
    
    public System.Threading.Tasks.Task<double> PiValueAsync()
    {
        return base.Channel.PiValueAsync();
    }
    
    public int AbsValue(int value)
    {
        return base.Channel.AbsValue(value);
    }
    
    public System.Threading.Tasks.Task<int> AbsValueAsync(int value)
    {
        return base.Channel.AbsValueAsync(value);
    }
}
