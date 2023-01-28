using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Messanger<T> where T : Message
    {
        public void SendMessage(T message)
        {
            Console.WriteLine(message.Text);
        }
    }
    internal class Message
    {
        public string Text { get; set; }
        public Message(string text)
        {
            Text = text;
        }
    }
    class EmailMessage : Message
    {
        public EmailMessage(string text) : base(text)
        {
        }
    }
}
