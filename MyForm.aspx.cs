using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net; //for WebClient
using System.Xml.Linq; //for XDocument

public partial class MyForm : System.Web.UI.Page
{
    // object to invoke the WelcomeRESTXMLService
    private WebClient client = new WebClient();
    private WebClient client1 = new WebClient();


    private XNamespace xmlNamespace = XNamespace.Get("http://schemas.microsoft.com/2003/10/Serialization/");
    protected void Page_Load(object sender, EventArgs e)
    {
        // add DownloadStringCompleted event handler to WebClient
        client.DownloadStringCompleted +=
        new DownloadStringCompletedEventHandler(client_DownloadStringCompleted);
        client1.DownloadStringCompleted +=
        new DownloadStringCompletedEventHandler(client1_DownloadStringCompleted);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        // send request to WelcomeRESTXMLService
        client.DownloadStringAsync(new Uri("http://localhost:1096/Service.svc/welcome/" + TextBox1.Text));
    }
    // process web service response
    private void client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
    {
        // check if any error occurred in retrieving service data
        if (e.Error == null)
        {
            
            // parse the returned XML string (e.Result)
            XDocument xmlResponse = XDocument.Parse(e.Result);
            Label1.Text = xmlResponse.Element(xmlNamespace + "string").Value;
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        client1.DownloadStringAsync(new Uri("http://localhost:1096/Service.svc/add/" + TextBox2.Text+"/"+TextBox3.Text));
    }
    private void client1_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
    {
        // check if any error occurred in retrieving service data
        if (e.Error == null)
        {

            // parse the returned XML string (e.Result)
            XDocument xmlResponse = XDocument.Parse(e.Result);
            TextBox4.Text = xmlResponse.Element(xmlNamespace + "int").Value;
        }
    }
}