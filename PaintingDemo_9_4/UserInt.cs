using System;
using System.Collections.Generic;
using System.Text;

namespace PaintingDemo_9_4
{
    class UserInt
    {
        List<Room> rooms = new List<Room>();

            

        //Prompt the user for dimensions of the room
        public void GetRoomDim()
        {
            string uInput = "";
            string[] LWH;
            int length, width, height;
            
            while(true)
            {
                Console.WriteLine("List the room Length, Width, " +
                "and Height seperated by spaces");
                uInput = Console.ReadLine();
                if(uInput.Equals("Q"))
                {
                    break;
                }
                LWH = uInput.Split(' ');

                length = Convert.ToInt32(LWH[0]);
                width = Convert.ToInt32(LWH[1]);
                height = Convert.ToInt32(LWH[2]);

                Room room = new Room(length,width,height);
                rooms.Add(room);

                Console.WriteLine("Enter 'Q' to stop entering rooms else:");

            }

        }

        public void PrintRoomProperties()
        {
            Room room;
            int roomNumber;
            int x;

            for(x = 0; x < rooms.Count; ++x)
            {
                room = rooms[x];
                roomNumber = x + 1;
                Console.WriteLine("Room Number {0}", roomNumber);
                Console.WriteLine("{0}L X {1}W X {2}H",
                    room.Length, room.Width, room.Height);
                Console.WriteLine("Room area: {0} SqrFt\nGallons of paint used: {1}"
                    , room.Area, room.Gallons);
                Console.WriteLine("");
            }
            
        }
    }
}
