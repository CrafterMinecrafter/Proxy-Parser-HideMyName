// author: https://github.com/CrafterMinecrafter

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bia.Countries.Iso3166;
namespace HideMyName
{
    public enum ProxyType
    {
        http = 'h',
        https = 's',
        socks4 = '4',
        socks5 = '5'
    }
    public enum AnonymouseType
    {
        High = '4',
        Medium = '3',
        Low = '2',
        None = '1'
    }
    class ProxySearchConfig
    {
        public ProxySearchConfig()
        {
        }




        /*<summary>
          Loading time of a small test page. The speed is specified at the time of testing.
         </summary>*/
        public int ProxyMaxPing = 500;



        /*
           <summary>
           How you can use it depends on the type of proxy.
           HTTP is suitable for visiting websites, and Socks 5 will allow you to connect to any addresses and protocols, make special requests.
           More details in the overview of proxy types at the bottom of the page
           </summary>
        */
        public ProxyType[] ProxyTypes = new ProxyType[]
        {
            ProxyType.http
        };




        public CountryCode[] ProxyCountries = new CountryCode[]
        {
        };




        /*
        <summary>
        None: The remote server knows your IP and knows that you are using a proxy.
        Low: The remote server does not know your IP, but knows that you are using a proxy.
        Medium: The remote server knows you are using a proxy and thinks it knows your IP, but it is not yours (these are usually multihomed proxies showing the incoming interface to the remote server as REMOTE_ADDR).
        High: The remote server does not know your IP address and cannot see headers from the proxy information family. Therefore, there is no direct evidence that you are using a proxy.
        </summary>*/
        public AnonymouseType[] AnonymouseTypes = new AnonymouseType[]
        {
        };




        /*
         <summary>
         Ports can be separated by commas or spaces, as well as ranges separated by hyphens.

         For example:   25,80-500,8080,9000-10000
         </summary>
        */


        /*
         <summary
         Ports can be separated by commas or spaces, as well as b ranges separated by hyphens.

        For example:   25,80-500,8080,9000-10000
         </summary>
        */
        public string Ports = "";

        /*
         <summary>
         Proxy page
         </summary>
         */
        public int Page = 0;

        public string ToLink()
        {
            string url = "https://hidemy.name/en/proxy-list/?";
            if (ProxyCountries.Length != 0)
            {
                url += "&country=";
                foreach (var item in ProxyCountries)
                    url += item.ToString();
            }
            if (ProxyMaxPing != 0)
                url += "&maxtime=" + ProxyMaxPing;

            if (Ports.Length != 0)
                url += "&ports=" + Ports;

            if (ProxyTypes.Length != 0)
            {
                url += "&type=";
                foreach (var item in ProxyTypes)
                    url += (char)item;
            }


            if (AnonymouseTypes.Length != 0)
            {
                url += "&anon=";
                foreach (var item in AnonymouseTypes)
                    url += (char)item;
            }
            url += "&start=" + 64 * Page + "#list";
            return url.Replace("?&", "?");
        }
    }

}
