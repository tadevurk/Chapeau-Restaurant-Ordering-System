using System;

namespace RosModel
{
    public enum Roles
    {
        Manager = 1, Waiter, Chef, Bartender, None
    }
    public class Employee
    {
        public int EmplID { get; set; }
        public string Name { get; set; }
        public Roles Roles { get; set; }
        public string Username { get; set; }
        public string PinCode { get; set; }
        public string Salt { get; set; }

        public string Digest { get; set; }
    }
}
