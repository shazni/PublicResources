using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Principal;
using System.ServiceModel;
using System.Text;

namespace WSO2.Echo
{
    public class EchoService : echoPortType
    {
        echoStringArraysResponse echoPortType.echoStringArrays(echoStringArraysRequest request)
        {
            echoStringArraysResponse res = new echoStringArraysResponse();
            res.@return = new SimpleBean();
            res.@return.a_r = request.a;
            res.@return.b_r = request.b;
            res.@return.c = request.c;
            res.@return.cSpecified = true;

            return res;
        }

        echoOMElementResponse echoPortType.echoOMElement(echoOMElementRequest request)
        {
            return new echoOMElementResponse();
        }
        echoIntResponse echoPortType.echoInt(echoIntRequest request)
        {
            return new echoIntResponse();
        }
        throwAxisFaultResponse echoPortType.throwAxisFault(throwAxisFaultRequest request)
        {
            return new throwAxisFaultResponse();
        }
        echoStringResponse echoPortType.echoString(echoStringRequest request)
        {
            echoStringResponse resp = new echoStringResponse();
            resp.@return = request.@in;

            return resp;
        }

    }
}
