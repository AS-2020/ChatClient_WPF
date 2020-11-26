using ChatProtocol;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using WpfApp2;
using WpfApp2.MessageHandler;

namespace ChatClient.MessageHandler
{
    class DisconnectResponseMessageHandler : IMessageHandler
    {
        public void Execute(MainWindowViewModel viewModel, IMessage message)
        {
            DisconnectResponseMessage disconnectResponseMessage = message as DisconnectResponseMessage;

            viewModel.ChatHistory += $"{disconnectResponseMessage.Username} disconnected{Environment.NewLine}";

        }
    }
}