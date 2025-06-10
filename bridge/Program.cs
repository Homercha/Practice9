using System;

namespace BridgeDemo
{
    public interface IMessageSender
    {
        void SendMessage(string message);
    }
    public class EmailSender : IMessageSender
    {
        public void SendMessage(string message) => Console.WriteLine($"Email: {message}");
    }
    public class SmsSender : IMessageSender
    {
        public void SendMessage(string message) => Console.WriteLine($"SMS: {message}");
    }
    public abstract class Message
    {
        protected IMessageSender sender;
        public Message(IMessageSender sender)
        {
            this.sender = sender;
        }
        public abstract void Send(string content);
    }
    public class TextMessage : Message
    {
        public TextMessage(IMessageSender sender) : base(sender) { }
        public override void Send(string content)
        {
            sender.SendMessage("Текст: " + content);
        }
    }
    public class HtmlMessage : Message
    {
        public HtmlMessage(IMessageSender sender) : base(sender) { }
        public override void Send(string content)
        {
            sender.SendMessage("<html><body>" + content + "</body></html>");
        }
    }
    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
    }
    public class TV : IDevice
    {
        public void TurnOn() => Console.WriteLine("Телевізор увімкнено");
        public void TurnOff() => Console.WriteLine("Телевізор вимкнено");
    }
    public class Radio : IDevice
    {
        public void TurnOn() => Console.WriteLine("Радіо увімкнено");
        public void TurnOff() => Console.WriteLine("Радіо вимкнено");
    }
    public class RemoteControl
    {
        protected IDevice device;
        public RemoteControl(IDevice device)
        {
            this.device = device;
        }
        public virtual void TogglePower()
        {
            Console.WriteLine("Увімкнення пристрою...");
            device.TurnOn();
        }
    }
    public class AdvancedRemote : RemoteControl
    {
        public AdvancedRemote(IDevice device) : base(device) { }
        public void TurnOff()
        {
            Console.WriteLine("Вимкнення пристрою...");
            device.TurnOff();
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("== Bridge: Messages ==");
            Message msg1 = new TextMessage(new SmsSender());
            msg1.Send("Привіт!");
            Message msg2 = new HtmlMessage(new EmailSender());
            msg2.Send("HTML повідомлення");
            Console.WriteLine("\n== Bridge: Devices ==");
            RemoteControl tvRemote = new RemoteControl(new TV());
            tvRemote.TogglePower();
            AdvancedRemote radioRemote = new AdvancedRemote(new Radio());
            radioRemote.TogglePower();
            radioRemote.TurnOff();
        }
    }
}
