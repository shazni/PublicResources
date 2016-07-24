package org.wso2.identity.esb.kerberos;

import org.apache.axiom.om.OMAbstractFactory;
import org.apache.axiom.om.OMElement;
import org.apache.axiom.om.OMNamespace;
import org.apache.axiom.om.OMFactory;
import org.apache.axiom.om.impl.builder.StAXOMBuilder;
import org.apache.axis2.AxisFault;
import org.apache.axis2.addressing.EndpointReference;
import org.apache.axis2.client.Options;
import org.apache.axis2.client.ServiceClient;
import org.apache.axis2.context.ConfigurationContext;
import org.apache.axis2.context.ConfigurationContextFactory;
import org.apache.neethi.Policy;
import org.apache.neethi.PolicyEngine;
import org.apache.rampart.RampartMessageData;

public class KerberosClient {

    final static String ADDRESSING_ENGAGING_MODULE = "addressing";
    final static String RAMPART_ENGAGING_MODULE = "rampart";

    private static ConfigurationContext confContext;
    private static Policy servicePolicy;

    public KerberosClient(){
    }

    public static void main(String[] args) throws Exception {
        KerberosConfigDataHolder kerberosConfigDataHolder = KerberosConfigDataHolder.getKerberosDataHolder();

        String trustStore ;

        //Import Identity Server public certificate to this key store
        trustStore = kerberosConfigDataHolder.getKeyStorePath();
        System.setProperty("javax.net.ssl.trustStore", trustStore);
        System.setProperty("javax.net.ssl.trustStorePassword", kerberosConfigDataHolder.getKeyStorePassword());

        //Create configuration context
        confContext = ConfigurationContextFactory.createConfigurationContextFromFileSystem(kerberosConfigDataHolder.getAxis2ClientPath());
        servicePolicy = loadServicePolicy(kerberosConfigDataHolder.getPolicyFilePath());

        String RELYING_PARTY_SERVICE_EPR = kerberosConfigDataHolder.getServiceEndpoint();

        ServiceClient client ;
        try{
            client = new ServiceClient(confContext, null);

            Options options = new Options();

            //Request data
            options.setTo(new EndpointReference(RELYING_PARTY_SERVICE_EPR));
            options.setProperty(RampartMessageData.KEY_RAMPART_POLICY, servicePolicy);

            client.setOptions(options);
            client.engageModule(ADDRESSING_ENGAGING_MODULE);
            client.engageModule(RAMPART_ENGAGING_MODULE);

            String value = "Hello Shazni!!!!!!!";

            System.out.println("Calling service with parameter - " + value);

            OMElement response = client.sendReceive(getPayload(value));
            System.out.println("The response is : " + response);
            System.out.flush();

        } catch (AxisFault axisFault){
            axisFault.printStackTrace();
            System.out.println("Could not create service client");
        }
    }

    private static Policy loadServicePolicy(String xmlPath) throws Exception {
        StAXOMBuilder builder;
        Policy policy;

        builder = new StAXOMBuilder(xmlPath);
        policy = PolicyEngine.getPolicy(builder.getDocumentElement());

        return policy;
    }

    private static OMElement getPayload(String value1) {
        OMFactory factory = OMAbstractFactory.getOMFactory();
        OMNamespace ns = factory.createOMNamespace("http://echo.services.core.carbon.wso2.org","p");
        OMElement elem = factory.createOMElement("echoString", ns);
        OMElement childElem = factory.createOMElement("in", null);
        childElem.setText(value1);
        elem.addChild(childElem);

        System.out.println("Request = " + elem);
        return elem;
    }
}
