using System.Collections.Generic;

namespace MyProject02
{
    public class AuthorizedPersons : human {
        private string RoomNumber { get; set; }
        private string Curriculum { get; set; }
        private enum Pet {
            Rat,cat,Owl
        }
        

        private bool baggage { get; set; }

        enum Role {
            Teacher , Student
        }

        private List<string> ReceivedLetter = new List<string>();

    }
}