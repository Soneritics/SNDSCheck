using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;

namespace SNDSCheck.SmartNetworkDataService
{
    public class SNDSFile
    {
        private Uri uri;
        public String Contents { get; private set; }

        public SNDSFile(Uri uri)
        {
            this.uri = uri;
            Update();
        }

        public void Update()
        {
            try
            {
                WebClient client = new WebClient();
                Contents = client.DownloadString(uri);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception occured: " + ex.Message);
                Contents = "";
            }
        }
    }
}