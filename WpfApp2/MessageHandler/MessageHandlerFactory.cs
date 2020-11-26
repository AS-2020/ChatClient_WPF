﻿using ChatClient.MessageHandler;

namespace WpfApp2.MessageHandler
{
    public static class MessageHandlerFactory
    {
        public static IMessageHandler GetMessageHandler(int messageId)
        {
            switch (messageId)
            {
                case 1:
                    return new ChatMessageHandler();
                case 4:
                    return new ConnectResponseMessageHandler();
                case 5:
                    return new UserCountMessageHandler();
                case 6:
                    return new DisconnectResponseMessageHandler();
               // case 8:
               //     return new RegisterResponseMessageHandler();
                case 10:
                    return new UserListResponseMessageHandler();
            }

            return null;
        }
    }
}
