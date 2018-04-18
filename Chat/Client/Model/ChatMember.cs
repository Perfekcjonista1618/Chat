using System;

namespace Client.Model
{
    public class ChatMember
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ChatMember(string name)
        {
            Id = new Guid();
            Name = name;
        }
    }
}