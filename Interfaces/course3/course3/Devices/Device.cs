﻿namespace course3.Devices {
    abstract class Device {

        public int SerialNumber { get; set; }

        public abstract void ProcessDoc(string document);

    }
}
