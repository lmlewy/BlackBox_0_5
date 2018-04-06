﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPA5BlackBoxReader
{
    public static class Constants
    {
        //public static string BLKTYPE_DATA { get { return " "; } }

        //typ bloku danych
        public const int BLKTYPE_DATA = 1;
        public const int BLKTYPE_FILE = 2;

        //typ wiadomości
        //public const byte MESSTYPE_LOCATION = 1;
        //public const byte MESSTYPE_ALERT = 2;
        //public const byte MESSTYPE_EVENT = 3;
        //public const byte MESSTYPE_ELS95 = 4;
        //public const byte MESSTYPE_MODE = 5;
        //public const byte MESSTYPE_FILEDESC = 6;
        //public const byte MESSTYPE_EHE2 = 7;

        public enum MessageType : byte
        {
            MESSTYPE_LOCATION = 1,
            MESSTYPE_ALERT = 2,
            MESSTYPE_EVENT = 3,
            MESSTYPE_ELS95 = 4,
            MESSTYPE_MODE = 5,
            MESSTYPE_FILEDESC = 6,
            MESSTYPE_EHE2 = 7,
        }


    }
}
