using System;

namespace Chat.Web.Models
{
    public class PrivateMessage
    {
        public int Id { get; set; }
        public string FromUserId { get; set; }
        public string ToUserId { get; set; }
        public string Content { get; set; }
        public DateTime SentAt { get; set; }
    }
}
