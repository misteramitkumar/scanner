﻿using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using static Scanner.Services.Messenger.MessengerEnums;

namespace Scanner.Services.Messenger
{
    public class AppWideMessage
    {
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // DECLARATIONS /////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public string Title;
        public string MessageText;
        public string AdditionalText;

        public AppWideMessageSeverity Severity;

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // CONSTRUCTORS / FACTORIES /////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public AppWideMessage()
        {

        }
    }
}
