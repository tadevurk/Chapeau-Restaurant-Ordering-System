using System;

namespace RosModel
{
    public class Employee
    {
        public int EmplID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public int PinCode { get; set; }
        public string Salt { get; set; }

        public string Digest { get; set; }
    }
}
