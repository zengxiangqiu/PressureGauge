using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 压力监控系统_初版
{
    public static class Crc16
    {
        public static byte[] CRCCalc(byte[] bytedata)
        {
            byte[] result = new byte[2];
            byte[] crcbuf = bytedata.ToArray();
            int crc = 0xffff;
            int len = crcbuf.Length;
            for (int n = 0; n < len; n++)
            {
                byte i;
                crc = crc ^ crcbuf[n];
                for (i = 0; i < 8; i++)
                {
                    int TT;
                    TT = crc & 1;
                    crc = crc >> 1;
                    crc = crc & 0x7fff;
                    if (TT == 1)
                    {
                        crc = crc ^ 0xa001;
                    }
                    crc = crc & 0xffff;
                }

            }
            byte[] redata = new byte[2];
            redata[1] =(byte)((crc >> 8) & 0xff);
            redata[0] = (byte)(crc & 0xff);
            return redata;
        }
    }
}
