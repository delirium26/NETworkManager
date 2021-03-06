﻿using NETworkManager.Models.Lookup;
using System.Net;

namespace NETworkManager.Models.Network
{
    public class PortInfo
    {
        public IPAddress IPAddress { get; set; }
        public string Hostname { get; set; }
        public int Port { get; set; }
        public PortLookupInfo LookupInfo { get; set; }
        public PortStatus Status { get; set; }

        public PortInfo()
        {

        }

        public PortInfo(IPAddress ipAddress, string hostname, int port, PortLookupInfo lookupInfo, PortStatus status)
        {
            IPAddress = ipAddress;
            Hostname = hostname;
            Port = port;
            LookupInfo = lookupInfo;
            Status = status;
        }

        public static PortInfo Parse(PortScannedArgs e)
        {
            return new PortInfo(e.IPAddress, e.Hostname, e.Port, e.LookupInfo, e.Status);
        }

        public enum PortStatus
        {
            Open,
            Closed
        }
    }
}
