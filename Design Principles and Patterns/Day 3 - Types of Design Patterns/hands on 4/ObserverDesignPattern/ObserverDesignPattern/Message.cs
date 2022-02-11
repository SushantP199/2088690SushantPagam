using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    public class Message
    {

        String messageContent;

        public Message(String message)
        {
            this.messageContent = message;
        }
        public String getMessageContent()
        {
            return messageContent;
        }
    }
}
