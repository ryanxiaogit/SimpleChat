namespace simpleChats.Model
{
    public class ChatMessage
    {

        public string SenderName { get; set; } = string.Empty;
        public string ReceiverName { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;

        public DateTime ChatTime { get; set; }

    }
}
