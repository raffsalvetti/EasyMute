using System;
using System.Collections.Generic;
using System.Text;
using NAudio.CoreAudioApi;

namespace EasyMute
{
    public class Device
    {
        private MMDevice dev;

        public Device(MMDevice dev)
        {
            this.dev = dev;
        }

        public MMDevice Dev
        {
            get { return dev; }
            set { dev = value; }
        }

        public override string ToString()
        {
            return String.Format("{0} - ({1})", new object[] { dev.DeviceFriendlyName, dev.FriendlyName });
        }

        public Boolean Mute
        {
            get { return dev.AudioEndpointVolume.Mute; }
            set { dev.AudioEndpointVolume.Mute = value; }
        }
    }
}
