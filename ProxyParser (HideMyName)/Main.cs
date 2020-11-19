using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HideMyName;
using Bia.Countries.Iso3166;
using xNet;
using System.Text.RegularExpressions;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace ProxyParser
{
    public partial class Main : Form
    {
        private string proxySave;
        private Parser parser = new Parser();
        private string ProxySave
        {
            get
            {
                return proxySave;
            }
            set
            {
                if (UseOutputBox.Checked) OutputBox.Text = value + Environment.NewLine;
                proxySave = value + Environment.NewLine;
            }
        }

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            #region CountryLoad
            CountriesList.Items.Add("All");
            string ProxyCountries = "ALARAMAUBDBEBZBJBOBABWBRBGBIKHCMCACLCNCOCGCRHRCYCZDOECFIFRGEDEGHGRGTGNHNHKHUINIDIRIQIEITJPKZKEKRLVLBLYLTMKMWMYMTMXMDMNNPNLNZNINGPKPSPAPYPEPHPLPRRORURSSCSGSKSISOZAESSECHSYTWTZTHTRUGUAAEGBUSUYUZVEVNVGZW";
            for (int i = 0; i < ProxyCountries.Length; i += 2)
                try
                {
                    CountriesList.Items.Add(Countries.GetCountryByAlpha2(ProxyCountries[i].ToString() + ProxyCountries[i + 1].ToString()));
                }
                catch
                {
                    MessageBox.Show(ProxyCountries[i].ToString() + ProxyCountries[i + 1].ToString());
                }
            #endregion
            #region AnonymouseTypesLoad
            AnonymouseType[] items = new AnonymouseType[] {
                AnonymouseType.High, AnonymouseType.Medium, AnonymouseType.Low, AnonymouseType.None
                };
            for (int i = 0; i < items.Length; i++)
                AnonymouseTypesList.Items.Add(items[i]);
            #endregion
            #region ProxyTypeLoad
            HideMyName.ProxyType[] PTitems = new HideMyName.ProxyType[] {
                HideMyName.ProxyType.http, HideMyName.ProxyType.https, HideMyName.ProxyType.socks4, HideMyName.ProxyType.socks5
                };
            for (int i = 0; i < PTitems.Length; i++)
                ProxyTypeList.Items.Add(PTitems[i]);
            #endregion
        }
        private void CountriesList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 0)
            {
                bool IsAll = (int)e.NewValue == 1;
                for (int i = 1; i < CountriesList.Items.Count; i++)
                    CountriesList.SetItemChecked(i, IsAll);
            }
        }

        private void Parse_button_Click(object sender, EventArgs e)
        {
            #region country
            List<CountryCode> CCodes = new List<CountryCode>();

            for (int i = 0; i < CountriesList.CheckedItems.Count; i++)
            {
                try
                {
                    var v = (CountriesList.CheckedItems[i] as Country);
                    if (v != null)
                        CCodes.Add(v.Alpha2);
                }
                catch { }
            }
            #endregion
            #region anon
            List<AnonymouseType> Anoni = new List<AnonymouseType>();

            for (int i = 0; i < AnonymouseTypesList.CheckedItems.Count; i++)
                Anoni.Add((AnonymouseType)AnonymouseTypesList.CheckedItems[i]);
            #endregion
            #region ProxyType
            List<HideMyName.ProxyType> Typel = new List<HideMyName.ProxyType>();

            for (int i = 0; i < ProxyTypeList.CheckedItems.Count; i++)
                Typel.Add((HideMyName.ProxyType)ProxyTypeList.CheckedItems[i]);
            #endregion
            #region Parser
            if (PageBox.Text.Contains('-'))
            {
                string[] SplitPage = PageBox.Text.Split('-');
                int b = int.Parse(SplitPage[1]);
                for (int a = int.Parse(SplitPage[0]); a < b; a++)
                    ProxySave += parser.HideMyNameDownloadAndParse(new ProxySearchConfig()
                    {
                        ProxyCountries = CCodes.ToArray(),
                        AnonymouseTypes = Anoni.ToArray(),
                        ProxyTypes = Typel.ToArray(),
                        Ports = PortsBox.Text,
                        Page = a
                    }.ToLink());
            }
            else
            {
                int result;
                if (int.TryParse(PageBox.Text, out result))
                    ProxySave += parser.HideMyNameDownloadAndParse(new ProxySearchConfig()
                    {
                        ProxyCountries = CCodes.ToArray(),
                        AnonymouseTypes = Anoni.ToArray(),
                        ProxyTypes = Typel.ToArray(),
                        Ports = PortsBox.Text,
                        Page = result
                    }.ToLink());
                else MessageBox.Show("Page parse error");
            }
            #endregion
        }

        #region keypresses
        private void MaxPingBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void PortsBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !"-,".Contains(e.KeyChar);
        }

        private void PageBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-';
        }
        #endregion
        private void OutputBox_TextChanged(object sender, EventArgs e)
        {
            Output_label.Text = "Output(" + OutputBox.Lines.Length + " Lines)";
        }
        private void SaveProxy_Click(object sender, EventArgs e)
        {
            if (!UseOutputBox.Checked)
            {
                MessageBox.Show("Saving " + Regex.Matches(ProxySave, @"\n").Count + " lines");
            }
            var path = Directory.GetCurrentDirectory() + "\\HideMyName_Proxy_" + DateTime.Now.Ticks + ".txt";
            File.WriteAllText(path, ProxySave);
            Process.Start("explorer", "/select,\"" + path+"\"");
        }
        #region Helper

        private void Page_label_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Page index, 0(from)-5(to) or 0(any number)");
        }

        private void ProxyType_label_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How you can use it depends on the type of proxy.\nHTTP is suitable for visiting websites, and Socks 5 will allow you to connect to any addresses and protocols, make special requests.\nMore details in the overview of proxy types at the bottom of the page.");
        }

        private void Anonymity_Label_Click(object sender, EventArgs e)
        {
            MessageBox.Show("None: The remote server knows your IP and knows that you are using a proxy.\nLow: The remote server does not know your IP, but knows that you are using a proxy.\n\nMedium: The remote server knows you are using a proxy and thinks it knows your IP, but it is not yours(these are usually multihomed proxies showing the incoming interface to the remote server as REMOTE_ADDR).\n\nHigh: The remote server does not know your IP address and cannot see headers from the proxy information family.Therefore, there is no direct evidence that you are using a proxy.");
        }

        private void MaxPing_label_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loading time of a small test page. The speed is specified at the time of testing.");
        }

        private void ProxyCountry_label_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proxy Server Location");
        }
        private void Ports_label_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ports can be separated by commas or spaces, as well as ranges separated by hyphens.\n\nFor example: 25, 80 - 500, 8080, 9000 - 10000");
        }

        #endregion
    }
}
