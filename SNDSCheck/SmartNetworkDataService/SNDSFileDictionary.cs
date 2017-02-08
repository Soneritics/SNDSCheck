using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Web;

namespace SNDSCheck.SmartNetworkDataService
{
    public class SNDSFileDictionary : Dictionary<String, SNDSFile>
    {
        private Timer updateTimer;

        public SNDSFileDictionary() : this(30) { }

        public SNDSFileDictionary(int fileCacheMinutes)
        {
            updateTimer = new Timer() { Interval = fileCacheMinutes * 60000, Enabled = true };
            updateTimer.Elapsed += OnTimerEvent;
        }

        private void OnTimerEvent(Object source, ElapsedEventArgs e)
        {
            if (this.Count > 0)
            {
                foreach (var sndsFile in Values)
                {
                    sndsFile.Update();
                }
            }
        }
    }
}