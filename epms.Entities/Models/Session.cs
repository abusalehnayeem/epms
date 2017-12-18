using System;

namespace epms.Entities.Models
{
    public class Session
    {
        public string SessionId { get; set; }
        public string ApplicationName { get; set; }
        public DateTime Created { get; set; }
        public DateTime Expires { get; set; }
        public DateTime LockDate { get; set; }
        public int LockId { get; set; }
        public int Timeout { get; set; }
        public short Locked { get; set; }
        public string SessionItems { get; set; }
        public uint Flags { get; set; }
    }
}