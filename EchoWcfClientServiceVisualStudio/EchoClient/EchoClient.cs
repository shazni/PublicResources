using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WSO2.Echo;

namespace WSO2.Echo
{
    [ServiceContract(Namespace = "http://echo.services.core.carbon.wso2.org", ConfigurationName = "WSO2.Echo.echoPortType")]
    public interface echoPortType
    {
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [OperationContract(Action = "urn:echoStringArrays", ReplyAction = "urn:echoStringArraysResponse", ProtectionLevel = ProtectionLevel.Sign)]
        [XmlSerializerFormat()]
        [ServiceKnownType(typeof(Exception))]
        [return: MessageParameter(Name = "return")]
        echoStringArraysResponse echoStringArrays(echoStringArraysRequest request);

        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [OperationContract(Action = "urn:echoOMElement", ReplyAction = "urn:echoOMElementResponse", ProtectionLevel = ProtectionLevel.Sign)]
        [XmlSerializerFormat()]
        [ServiceKnownType(typeof(Exception))]
        [return: MessageParameter(Name = "return")]
        echoOMElementResponse echoOMElement(echoOMElementRequest request);

        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [OperationContract(Action = "urn:echoInt", ReplyAction = "urn:echoIntResponse", ProtectionLevel = ProtectionLevel.Sign)]
        [XmlSerializerFormat()]
        [ServiceKnownType(typeof(Exception))]
        [return: MessageParameter(Name = "return")]
        echoIntResponse echoInt(echoIntRequest request);

        // CODEGEN: Generating message contract since the operation throwAxisFault is neither RPC nor document wrapped.
        [OperationContract(Action = "urn:throwAxisFault", ReplyAction = "urn:throwAxisFaultResponse", ProtectionLevel = ProtectionLevel.Sign)]
        [XmlSerializerFormat()]
        [ServiceKnownType(typeof(Exception))]
        throwAxisFaultResponse throwAxisFault(throwAxisFaultRequest request);

        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [OperationContract(Action = "urn:echoString", ReplyAction = "urn:echoStringResponse", ProtectionLevel = ProtectionLevel.Sign)]
        [XmlSerializerFormat()]
        [ServiceKnownType(typeof(Exception))]
        [return: MessageParameter(Name = "return")]
        echoStringResponse echoString(echoStringRequest request);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface echoPortTypeChannel : WSO2.Echo.echoPortType, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class echoPortTypeClient : System.ServiceModel.ClientBase<WSO2.Echo.echoPortType>, WSO2.Echo.echoPortType
    {

        public echoPortTypeClient()
        {
        }

        public echoPortTypeClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public echoPortTypeClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public echoPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public echoPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSO2.Echo.echoStringArraysResponse WSO2.Echo.echoPortType.echoStringArrays(WSO2.Echo.echoStringArraysRequest request)
        {
            return base.Channel.echoStringArrays(request);
        }

        public WSO2.Echo.SimpleBean echoStringArrays(string[] a, string[] b, int c)
        {
            WSO2.Echo.echoStringArraysRequest inValue = new WSO2.Echo.echoStringArraysRequest();
            inValue.a = a;
            inValue.b = b;
            inValue.c = c;
            WSO2.Echo.echoStringArraysResponse retVal = ((WSO2.Echo.echoPortType)(this)).echoStringArrays(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSO2.Echo.echoOMElementResponse WSO2.Echo.echoPortType.echoOMElement(WSO2.Echo.echoOMElementRequest request)
        {
            return base.Channel.echoOMElement(request);
        }

        public object echoOMElement(object omEle)
        {
            WSO2.Echo.echoOMElementRequest inValue = new WSO2.Echo.echoOMElementRequest();
            inValue.omEle = omEle;
            WSO2.Echo.echoOMElementResponse retVal = ((WSO2.Echo.echoPortType)(this)).echoOMElement(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSO2.Echo.echoIntResponse WSO2.Echo.echoPortType.echoInt(WSO2.Echo.echoIntRequest request)
        {
            return base.Channel.echoInt(request);
        }

        public int echoInt(int @in)
        {
            WSO2.Echo.echoIntRequest inValue = new WSO2.Echo.echoIntRequest();
            inValue.@in = @in;
            Console.WriteLine("My request int is = " + inValue.@in);
            WSO2.Echo.echoIntResponse retVal = ((WSO2.Echo.echoPortType)(this)).echoInt(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSO2.Echo.throwAxisFaultResponse WSO2.Echo.echoPortType.throwAxisFault(WSO2.Echo.throwAxisFaultRequest request)
        {
            return base.Channel.throwAxisFault(request);
        }

        public string throwAxisFault()
        {
            WSO2.Echo.throwAxisFaultRequest inValue = new WSO2.Echo.throwAxisFaultRequest();
            WSO2.Echo.throwAxisFaultResponse retVal = ((WSO2.Echo.echoPortType)(this)).throwAxisFault(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSO2.Echo.echoStringResponse WSO2.Echo.echoPortType.echoString(WSO2.Echo.echoStringRequest request)
        {
            return base.Channel.echoString(request);
        }

        public string echoString(string @in)
        {
            WSO2.Echo.echoStringRequest inValue = new WSO2.Echo.echoStringRequest();
            inValue.@in = @in;
            WSO2.Echo.echoStringResponse retVal = ((WSO2.Echo.echoPortType)(this)).echoString(inValue);
            return retVal.@return;
        }
    }
}
