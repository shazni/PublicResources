package org.wso2.identity.esb.kerberos;

import java.io.FileInputStream;
import java.io.IOException;
import java.nio.file.Paths;
import java.util.Properties;

public class KerberosConfigDataHolder {
    public static KerberosConfigDataHolder getKerberosDataHolder() {
        return kerberosConfigDataHolder;
    }

    public String getKeyStorePath() {
        return prop.getProperty("keyStorePath");
    }

    public String getKeyStorePassword() {
        return prop.getProperty("keyStorePassword");
    }

    public String getAxis2ClientPath() {
        return prop.getProperty("axis2ClientPath");
    }

    public String getPolicyFilePath() {
        return prop.getProperty("policyFilePath");
    }

    public String getServiceEndpoint() {
        return prop.getProperty("serviceEndpoint");
    }

    private KerberosConfigDataHolder(){
//        String propertyFilePath = "C:\\Users\\amitdua\\Downloads\\Kerberos\\kerberosClient\\kerberosClient\\repo\\conf\\config.properties";
        String propertyFilePath = "repo/conf/config.properties";

        try {
            FileInputStream inputStream = new FileInputStream(propertyFilePath);
            prop.load(inputStream);
        } catch(IOException ex) {
            // ignore
            System.out.println("An error occurred while initializing. Possibly file no found" + ex);
        }
    }

    private static KerberosConfigDataHolder kerberosConfigDataHolder = new KerberosConfigDataHolder();
    Properties prop = new Properties();
}
