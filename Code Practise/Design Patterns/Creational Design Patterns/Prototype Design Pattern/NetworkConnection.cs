using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practise.Design_Patterns.Creational_Design_Patterns.Prototype_Design_Pattern
{
    public class NetworkConnection : ICloneable
    {
        // value type variables
        private string IP;
        private int port;
        private string response;

        // Reference type variable
        private List<string> domain = new List<string>();  

        public NetworkConnection() { }

        #region Getters and Setter
        public void setIP(string IP)
        {
            this.IP = IP;
        }

        public string getIP() {  return this.IP; }

        public void setPort(int port)
        {
            this.port = port;
        }

        public int getPort() { return this.port; }

        public string getResponse() { return this.response; }

        public void setResponse(string response)
        {
            this.response = response;
        }

        public void setDomain(List<string> domains)
        {
            this.domain = domains;
        }

        public List<string> getDomains() { return this.domain; }

        #endregion

        public void LoadResponse()
        {
            // Heavy method
            Thread.Sleep(2000);
            this.response = "This is the response from servers";
        }

        public override string? ToString()
        {
            string result = string.Empty; ;
            result = IP + "   :   " + port + "     :   ";
            foreach (string domain in domain) { 
                result = result + domain + "    ";
            }
            result = result +  "    :   " + response;
            return result;
        }

        public object Clone()
        {
            /*
             * Shallow Copy : In Shallow copy, value type and reference type variables are just copied, 
             *                  so any change made to original or copy will be reflected to all the related objects
             * Deep Copy    : In Deep copy, value types and object of reference type are copied or created newly
             *                  by custom Clone method implementation (override)
             *                  so change in original or any copy do not effect others
             */
            NetworkConnection connection = new NetworkConnection();

            // set value type directly
            connection.setIP(this.IP);
            connection.setPort(this.port);
            connection.setResponse(this.response);

            // for reference type, create the new object
            foreach (string domain in this.domain) {
                connection.getDomains().Add(domain);
            }

            return connection;
        }
    }
}
