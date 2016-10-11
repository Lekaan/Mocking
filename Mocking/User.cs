using System;

namespace Mocking
{
    public enum Rights { None, Some, Full }
    public class User : ILoginModule
    {
        
        public User()
        {
        }

        public int NumMessagesCreated { get; internal set; }
        public string Password { get; set; }
        public object Rights { get; internal set; }
        public string UserName { get; set; }

        public void Login(User user)
        {
            throw new NotImplementedException();
        }

        public void Register(User user)
        {
            throw new NotImplementedException();
        }

        public void ResendPassword(User user)
        {
            throw new NotImplementedException();
        }

        internal string ViewAllEmployees()
        {
            return "Here is the list";
        }
    }
}