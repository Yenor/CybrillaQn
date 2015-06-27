using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URLShortnerCSharp
{
    public partial class Form1 : Form
    {
        private List<string> urlListItems = new List<string>();
        private Dictionary<string, string> database =
        new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void GetShortButton_Click(object sender, EventArgs e)
        {
            var url = URLBox.Text;
            if(!validateURL(url))
            {
                MessageBox.Show("Not a valid URL");
                return;
            }
            if(!checkURLExists(url))
            {
                urlListItems.Add(url);
                addlongURL(url);
            }
            else
            {
                MessageBox.Show("URL alredy Shortened");
            }

            
        }
        private bool checkURLExists(string url)
        {
            foreach (string val in urlListItems)
            {
                if(url == val)
                {
                    return true;
                }
            }
            return false;
        }
        private string createShortURL(string url)
        {
            string shorten = "";
           var array = url.Split('/');
            foreach(string val in array)
            {
                if (shorten.Length > 1)
                {
                    shorten = shorten + "/";
                }
                var array2 = val.Split('.');
                foreach(string val2 in array2)
                {
                    if (val2.Length > 1 && val2 != "http:" && val2 != "www")
                    {
                        shorten = shorten + val2.Substring(0, 1) + val2.Substring(val2.Length-1, 1);
                    }
                    
                }
               
                 

            }
            Random rnd = new Random();
            int rand = rnd.Next(1, 100);
            shorten = "http://" + shorten + rand.ToString();
            return shorten;
        }
        private bool validateURL(string url)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult) && uriResult.Scheme == Uri.UriSchemeHttp;
            return result;
        }
        private void addlongURL(string url)
        {
            var val = createShortURL(url);
            while(!shorturlExists(val))
            {
                val = createShortURL(url);
            }
            database.Add(val, url);
            URLShortList.Items.Add(val);
            
           
        }
        private bool shorturlExists(string url)
        {
            var arrayOfAllKeys = database.Keys.ToArray();
            foreach(string key in arrayOfAllKeys)
            {
                if(url == key)
                {
                    return false;
                }
            }
            return true;
        }

        private void GoToURL_Click(object sender, EventArgs e)
        {
            string selected = "";
            if (URLShortList.SelectedItem != null)
            {
                selected = URLShortList.SelectedItem.ToString();
                foreach (KeyValuePair<string, string> pair in database)
                {
                   if( pair.Key == selected)
                   {
                       OutputUrl.Text = "Output:" + pair.Value;
                   }
                    
                }
            }
            else
            {
                MessageBox.Show("please select one url");
            }
        }

    }
}
