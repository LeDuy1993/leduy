using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class ClassTv
    {

        public static void Main(string[] args)
        {
            ClassTv tv1 = new ClassTv();
            tv1.TurnOn();
            tv1.SetChannel(30);
            tv1.SetVolume(3);
            tv1.VolumeUp();

            ClassTv tv2 = new ClassTv();
            tv2.TurnOn();
            tv2.ChannelUp();
            tv2.VolumeUp();

            Console.WriteLine("Tv1's channel is " + tv1.channel + " and volumn level is " + tv1.volumeLevel);
            Console.WriteLine("Tv2's channel is " + tv2.channel + " and volumn level is " + tv2.volumeLevel);
        }

        int channel = 1;
            int volumeLevel = 1;
            bool on = false;
        public void TurnOn() => on = true;

        public void TurnOff()
            {
                on = false;
            }

            public void SetChannel(int newChannel)
            {
                if (on && newChannel >= 1 && newChannel <= 120)
                    channel = newChannel;
            }

            public void SetVolume(int newVolumeLevel)
            {
                if (on && newVolumeLevel >= 1 && newVolumeLevel <= 7)
                    volumeLevel = newVolumeLevel;
            }

            public void ChannelUp()
            {
                if (on && channel < 120)
                    channel++;
            }

            public void ChannelDown()
            {
                if (on && channel > 1)
                    channel--;
            }

            public void VolumeUp()
            {
                if (on && volumeLevel < 7)
                    volumeLevel++;
            }

            public void VolumeDown()
            {
                if (on && volumeLevel > 1)
                    volumeLevel--;
            }

        
    }
}
