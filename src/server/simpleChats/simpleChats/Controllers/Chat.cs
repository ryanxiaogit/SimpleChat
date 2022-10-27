using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using simpleChats.Model;

namespace simpleChats.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Chat : ControllerBase
    {
        static List<ChatMessage> chats = new List<ChatMessage>();

        [HttpGet("addchat")]
        [HttpPost("addchat")]
        public ResponseMessage AddChat(ChatMessage message)
        {
            var response = new ResponseMessage();
            message.ChatTime = DateTime.Now;
            chats.Add(message);

            return response;
        }


        [HttpGet("getChats")]
        public List<ChatMessage> GetAllChat(string senderName, string receiver)
        {
            var response = new ResponseMessage();
            var chatList = chats.FindAll(x => (x.SenderName == senderName && x.ReceiverName == receiver)
            || (x.SenderName == receiver && x.ReceiverName == senderName))
                .OrderBy(x => x.ChatTime).ToList();

            return chatList;
        }
    }
}
