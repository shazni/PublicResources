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
}
