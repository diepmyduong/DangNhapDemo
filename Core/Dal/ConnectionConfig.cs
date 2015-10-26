using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Core.Dal
{
    public class ConnectionConfig
    {
        public static void updateConfigFile()
        {
            ConnectionString con = new ConnectionString();
            con.Name = "UserEntities";
            con.ConnectString = "metadata=res://*/Dal.UserModel.csdl|res://*/Dal.UserModel.ssdl|res://*/Dal.UserModel.msl;provider=System.Data.SqlClient;provider connection string=';data source=adminpc;initial catalog=LoginDemo;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework';";
            con.ProviderName = "System.Data.EntityClient";
            //updating config file
            XmlDocument XmlDoc = new XmlDocument();
            //Loading the Config file
            XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement xElement in XmlDoc.DocumentElement)
            {
                if (xElement.Name == "connectionStrings")
                {
                    XmlNode node = xElement.OwnerDocument.ImportNode(con.getConnectString(), true);
                    xElement.InnerXml = "";
                    xElement.AppendChild(node);
                    break;
                }
            }
            //writing the connection string in config file
            XmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        }
    }

    public class ConnectionString
    {
        public string Name { get; set; }
        public string ConnectString { get; set; }
        public string ProviderName { get; set; }

        public XmlNode getConnectString()
        {
            XmlNode node = new XmlDocument().CreateNode(XmlNodeType.Element, "add", "");
            XmlAttribute atrName = node.OwnerDocument.CreateAttribute("name");
            atrName.Value = this.Name;
            node.Attributes.Append(atrName);
            XmlAttribute atrConnectionString = node.OwnerDocument.CreateAttribute("connectionString");
            atrConnectionString.Value = this.ConnectString;
            node.Attributes.Append(atrConnectionString);
            XmlAttribute atrProviderName = node.OwnerDocument.CreateAttribute("providerName");
            atrProviderName.Value = this.ProviderName;
            node.Attributes.Append(atrProviderName);
            return node;
        }
    }
}
