using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.world
{
    public class InvalidRoomException: Exception
    {
        private string roomIdentifier;
        private string errorMessage;

        private Exception innerException;

        private Room errorousRoom;

        public string roomID
        {
            get
            {
                if (this.roomIdentifier != null)
                    return this.roomIdentifier;
                else
                    return "";
            }
        }

        public Room room
        {
            get
            {
                if (this.errorousRoom != null)
                    return this.errorousRoom;
                else
                    return null;
            }
        }

        public InvalidRoomException()
        {
            this.errorMessage = "Error when creating room";
            this.innerException = new Exception();
        }

        public InvalidRoomException(string message) : base(message)
        {
            this.errorMessage = message;
            this.innerException = new Exception();
        }

        public InvalidRoomException(string message, Exception inner) : base(message, inner)
        {
            this.errorMessage = message;
            this.innerException = inner;
        }

        public InvalidRoomException(string message, string roomID)
        {
            this.errorMessage = message;
            this.innerException = new Exception();
            this.roomIdentifier = roomID;
        }

        public InvalidRoomException(string message, Room targetRoom)
        {
            this.errorMessage = message;
            this.errorousRoom = targetRoom;
            this.roomIdentifier = targetRoom.ID;
            this.innerException = new Exception();
        }

        public string ToString()
        {
            return this.errorMessage;
        }
    }
}
