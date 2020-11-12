using System;

namespace SmartSaver
{
    public struct LoginStruct
    {
        public String username { get; set; }
        public String name { get; set; }
        public String surname { get; set; }
        public int userId { get; set; }
        public Gender gender { get; set; }
        public int limit { get; set; }
    }
}
