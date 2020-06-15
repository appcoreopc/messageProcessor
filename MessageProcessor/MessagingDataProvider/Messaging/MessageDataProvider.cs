using Newtonsoft.Json;

namespace MessagingDataProvider.Messaging
{
    class MessageDataProvider
    {
        public MessageDataProvider()
        {

        }
        bool HandleMessage<T>(string sourceMessage)
        {
            // 
            T targetdata = JsonConvert.DeserializeObject<T>(sourceMessage);
            //
            return true; 
        }
    }
}
