
using SecurityToolbox.Models;
using SecurityToolbox.Repository;
using SecurityToolbox.Utilities;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;


using YamlDotNet.Serialization;


namespace SecurityToolbox
{
    public partial class SecToolForm : Form
    {
        public SecToolForm()
        {
            InitializeComponent();
            BootStrapGrid();
            var tabPage = tabIpTools.TabPages["apigeeSailpointEncDec"];
            
            tabIpTools.TabPages.Remove(tabPage);
        }

        public void BootStrapGrid()
        {
            string publicIP = "127.0.0.1";
            try
            {
                publicIP = new WebClient().DownloadString("http://icanhazip.com");
            }
            catch { }
            txtIpInput.Text = publicIP.Trim();
           // DoLookup();

        }

        private void tabIpTools_SelectedIndexChanged(object sender, EventArgs e)
        {
            var x = sender as TabControl;
            var m = x.SelectedIndex;

            if (m == 0)
            {
                lblTabHeader.Text = "IP Lookup Tools";
            }
            if (m == 1)
            {
                lblTabHeader.Text = "Encoding/Decoding Tools";
            }
        }

        public void DoLookup()
        {
            dgIpResults.DataSource = null;
            txtIpOutput.Text = "";
            var delimeter = "\t";
            var sList = txtIpInput.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None).ToList();
            lblCountValue.Text = sList.Count.ToString();
            var repo = new IpAddressRepo();

            var hFields = IpApiHeaders.IpApiHeaderOptions;
            RootIpAddressLookup ipResults = repo.DoBulkIpLookup(sList, hFields);

            var headerList = "";
            var hCount = hFields.Count;
            for (int i = 0; i < hFields.Count; i++)
            {
                var endDelimeter = "\t";
                var h = hFields[i];
                if (i == hFields.Count - 1)
                {
                    endDelimeter = "\r\n";
                }
                headerList += string.Format("{0}{1}", StringUtils.HeaderTextForFieldName(h), endDelimeter);
                //YourDataGridView.Columns.Add(New DataGridViewColumn());

            }

            txtIpOutput.Text = string.Format("{0}", headerList);
            foreach (IpAddressData item in ipResults.IpAddressData)
            {
                var dnsRepo = new DnsQueryRepo();
                if (cbIncludeBlacklist.Checked)
                {
                    item.BlackList = dnsRepo.GetIndividualIpBlockedStatus(item.IpAddress);
                }

                txtIpOutput.Text += string.Format("{0}{13}{1}{13}{2}{13}{3}{13}{4}{13}{5}{13}{6}{13}{7}{13}{8}{13}{9}{13}{10}{13}{11}{13}{12}\r\n",
                    item.IpAddress,
                    item.Status,
                    item.Country,
                    item.RegionName,
                    item.City,
                    item.District,
                    item.Zipcode,
                    item.ISP,
                    item.Organization,
                    item.ASN,
                    item.Latitude,
                    item.Longitude,
                    item.BlackList,
                    delimeter
                    );
            }

            dgIpResults.RowsDefaultCellStyle.BackColor = Color.Ivory;
            dgIpResults.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgIpResults.AutoGenerateColumns = true;
            dgIpResults.AutoResizeColumns();
            dgIpResults.DataSource = ipResults.IpAddressData;

        }

        

        private void btnIpLookup_Click(object sender, EventArgs e)
        {
            btnIpLookup.Enabled = false;
            btnIpReset.Enabled = false;
            linkCopyIpToClip.Enabled = false;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            DoLookup();
            sw.Stop();
            TimeSpan t = TimeSpan.FromMilliseconds(sw.ElapsedMilliseconds);
            string elapsedTime = string.Format("{0:D2}h:{1:D2}m:{2:D2}s:{3:D3}ms", t.Hours, t.Minutes, t.Seconds, t.Milliseconds);
            lblElapsedValue.Text = elapsedTime;
            btnIpLookup.Enabled = true;
            btnIpReset.Enabled = true;
            linkCopyIpToClip.Enabled = true;

        }

        private void linkCopyIpToClip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var lbutton = sender as LinkLabel;
            if (lbutton.Enabled)
            {
                Clipboard.SetText(txtIpOutput.Text);
            }

        }

        private void btnIpReset_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn.Enabled)
            {
                lblCountValue.Text = "1";
                lblElapsedValue.Text = "0:00";
                txtIpInput.Text = "";
                txtIpOutput.Text = "";
                BootStrapGrid();
            }

        }

        private void btnHexDecode_Click(object sender, EventArgs e)
        {
            txtEncodingOutput.Text = "";
            try
            {
                txtEncodingOutput.Text = HexDecodeString(txtEncodingInput.Text);
            }
            catch (Exception ex)
            {
                txtEncodingOutput.Text = ex.Message;
            }
        }

        private void btnHexEncode_Click(object sender, EventArgs e)
        {
            try
            {
                txtEncodingOutput.Text = HexEncodeString(txtEncodingInput.Text);
            }
            catch (Exception ex)
            {
                txtEncodingOutput.Text = ex.Message;
            }
        }

        protected string HexDecodeString(string hexString)
        {
            if (hexString == null || (hexString.Length & 1) == 1)
            {
                throw new ArgumentException();
            }
            var sb = new StringBuilder();
            for (var i = 0; i < hexString.Length; i += 2)
            {
                var hexChar = hexString.Substring(i, 2);
                sb.Append((char)Convert.ToByte(hexChar, 16));
            }
            return sb.ToString();
        }

        protected string HexEncodeString(string inputString)
        {
            byte[] ba = Encoding.Default.GetBytes(inputString);
            return BitConverter.ToString(ba).Replace("-", "");
        }

        private void btnB64Encode_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] data = System.Text.ASCIIEncoding.ASCII.GetBytes(txtEncodingInput.Text);
                txtEncodingOutput.Text = System.Convert.ToBase64String(data);
            }
            catch (Exception ex)
            {
                txtEncodingOutput.Text = ex.Message;
            }
        }

        private void btnB64Decode_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] data = Convert.FromBase64String(txtEncodingInput.Text);
                txtEncodingOutput.Text = Encoding.UTF8.GetString(data);
            }
            catch (Exception ex)
            {
                txtEncodingOutput.Text = ex.Message;
            }
        }

        private void btnUrlEncode_Click(object sender, EventArgs e)
        {
            try
            {
                txtEncodingOutput.Text = System.Net.WebUtility.UrlEncode(txtEncodingInput.Text);
            }
            catch (Exception ex)
            {
                txtEncodingOutput.Text = ex.Message;
            }
        }

        private void btnUrlDecode_Click(object sender, EventArgs e)
        {
            txtEncodingOutput.Text = "";
            try
            {
                txtEncodingOutput.Text = System.Net.WebUtility.UrlDecode(txtEncodingInput.Text);
            }
            catch (Exception ex)
            {
                txtEncodingOutput.Text = ex.Message;
            }
        }

        private void btnXmlPretty_Click(object sender, EventArgs e)
        {
            try
            {
                txtEncodingOutput.Text = FormatXml(txtEncodingInput.Text);

            }
            catch (Exception ex)
            {
                txtEncodingOutput.Text = ex.Message;
            }
        }

        string FormatXml(string xml)
        {
            try
            {
                XDocument doc = XDocument.Parse(xml);
                return doc.ToString();
            }
            catch (Exception ex)
            {
                xml = ex.Message;
                // Handle and throw if fatal exception here; don't just ignore them
                return xml;
            }
        }

        private void btnEncodingReset_Click(object sender, EventArgs e)
        {
            txtEncodingInput.Text = "";
            txtEncodingOutput.Text = "";
        }

        private void tsExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string version = System.Windows.Forms.Application.ProductVersion;
            this.Text = String.Format("My Application Version {0}", version);
            string appNameVersion = String.Format("Security Toolbox v{0}\r\n", version);
            string appSupportInfo = string.Format("Support Contact: darron.haworth@gmail.com");
            MessageBox.Show(String.Format("{0}{1}", appNameVersion, appSupportInfo));
        }

        private void btnYamlToJson_Click(object sender, EventArgs e)
        {
            // convert string/file to YAML object
            try
            {
                var r = new StringReader(txtYaml.Text);
                var deserializer = new DeserializerBuilder().Build();
                var yamlObject = deserializer.Deserialize(r);

                var serializer = new SerializerBuilder()
                    .JsonCompatible()
                    .Build();

                var json = serializer.Serialize(yamlObject);
                var jObj = Newtonsoft.Json.Linq.JObject.Parse(json);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                txtJson.Text = formatted;
            }
            catch(Exception ex)
            {
                txtJson.Text = ex.Message;
            }           

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void resetForm()
        {
            txtYaml.Text = "";
            txtJson.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var x = txtJson.Text;
                if (!string.IsNullOrEmpty(x))
                {
                    Clipboard.SetText(x);
                }
            }
            catch(Exception ex)
            {
                txtYaml.Text = ex.Message;
            }
        }

        private void btnDecodeJwt_Click(object sender, EventArgs e)
        {
            txtEncodingOutput.Text = new DecodeJwt().DecodeJwtToken(txtEncodingInput.Text);
        }

        private void btnAesKeyIv_Click(object sender, EventArgs e)
        {
            RijndaelManaged aesEncryption = new RijndaelManaged();
            aesEncryption.KeySize = 256;
            aesEncryption.BlockSize = 128;
            aesEncryption.Mode = CipherMode.CBC;
            aesEncryption.Padding = PaddingMode.PKCS7;
            aesEncryption.GenerateIV();
            string ivStr = Convert.ToBase64String(aesEncryption.IV);
            aesEncryption.GenerateKey();
            string keyStr = Convert.ToBase64String(aesEncryption.Key);
            string completeKey = string.Format("IV: {0}\r\nKey: {1}", ivStr, keyStr); 


            txtEncodingOutput.Text = completeKey;



        }

        private void btnHtmlEncode_Click(object sender, EventArgs e)
        {

            try
            {
                txtEncodingOutput.Text = System.Net.WebUtility.HtmlEncode(txtEncodingInput.Text);
            }
            catch (Exception ex)
            {
                txtEncodingOutput.Text = ex.Message;
            }

        }

        private void btnBtnDecode_Click(object sender, EventArgs e)
        {
            try
            {
                txtEncodingOutput.Text = System.Net.WebUtility.HtmlDecode(txtEncodingInput.Text);
            }
            catch (Exception ex)
            {
                txtEncodingOutput.Text = ex.Message;
            }
        }
    }
}
