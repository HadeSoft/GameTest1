using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.world
{
    public class World
    {
        private string id; // Unqiue world identifier, might not need to be stored here aswell
        private string mainRoom = ""; // Room the world loads by default

        private Dictionary<string, Room> rooms; // Dictionary of rooms in world

        public string ID
        {
            get
            {
                return this.id;
            }
        }

        public string defaultRoom
        {
            get
            {
                return mainRoom;
            }

            set
            {
                this.mainRoom = value;
            }
        }

        public World(string identifier)
        {
            this.id = identifier;
            this.rooms = new Dictionary<string, Room>();
        }

        // Construct new room and add it to rooms dictionary
        public void newRoom(string identifier)
        {
            if (identifier == "")
                throw new InvalidRoomException("Room id cannot be blank");

            this.rooms.Add(identifier, new Room());

            if (mainRoom == "")
                mainRoom = identifier;
        }

        // Get room from world
    }
}
