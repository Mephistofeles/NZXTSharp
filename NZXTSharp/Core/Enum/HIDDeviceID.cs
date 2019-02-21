﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NZXTSharp
{

    /// <summary>
    /// Contains the Manufacturer and Product IDs of NZXT devices.
    /// </summary>
    public enum HIDDeviceID {

        /// <summary>
        /// An unknown ID.
        /// </summary>
        Unknown = -1,

        /// <summary>
        /// The NZXT vendor ID.
        /// </summary>
        VendorID = 0x1e71,
        
        // Kraken Devices
        /// <summary>
        /// A KrakenM Device.
        /// </summary>
        KrakenM = 0x1715,

        /// <summary>
        /// A KrakenX Device.
        /// </summary>
        KrakenX   = 0x170e,
        
        // Hue Devices
        /// <summary>
        /// A Hue 2 Device
        /// </summary>
        Hue2       = 0x2001,

        /// <summary>
        /// A Hue Ambient Device.
        /// </summary>
        HueAmbient = 0x2002,

        // Grid Devices
        /// <summary>
        /// A Grid v2 Device.
        /// </summary>
        GridV2 = Unknown,

        /// <summary>
        /// A Grid v3 Device.
        /// </summary>
        GridV3 = 0x1711,

        // Motherboards
        /// <summary>
        /// An N7 Z370 Device.
        /// </summary>
        N7      = 0x1713,
        
        /// <summary>
        /// An N7 Z390 Device.
        /// </summary>
        N7_Z390 = 0x2005,

        // Misc
        /// <summary>
        /// A Cryorig H7 Quad Lumi Device.
        /// </summary>
        H7Lumi      = 0x1712,

        /// <summary>
        /// An NZXT smart device.
        /// </summary>
        SmartDevice = 0x1714
    }
}
