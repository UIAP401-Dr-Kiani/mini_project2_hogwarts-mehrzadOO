using System.Collections.Generic;

namespace MyProject02
{
    public class AuthorizedPersons : human {
        public string RoomNumber { get; set; }
        public string Curriculum { get; set; }
        public string Pet { get; set; }
        

        public bool baggage { get; set; }

        public string role { get; set; } 

        public List<string> ReceivedLetter = new List<string>();

    }
}