using System;

namespace Hl7.Message
{
    /// <summary>
    /// Describes the type of message
    /// </summary>
    public class MessageType : LookupEntity
    {
        public string Owner { get; set; }
    }
}
