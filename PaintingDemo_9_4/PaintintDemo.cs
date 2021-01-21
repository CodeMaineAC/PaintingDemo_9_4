using System;


namespace PaintingDemo_9_4
{
    class PaintintDemo
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Room[] rooms = new Room[8];

            int length, width, height;

            int x;
            for (x = 0; x < rooms.Length; ++x)
            {
                length = rand.Next(5, 25);
                width = rand.Next(5, 25);
                height = rand.Next(6, 12);

                rooms[x] = new Room(length, width, height);
            }

            int roomNumber;
            for(x = 0; x < rooms.Length; ++x)
            {
                roomNumber = x + 1;
                RoomProperties(roomNumber, rooms[x]);
            }
            
        }

        static void RoomProperties(int roomNumber, Room room)
        {
            Console.WriteLine("Room Number {0}", roomNumber);
            Console.WriteLine("{0}L X {1}W X {2}H",
                room.Length, room.Width, room.Height);
            Console.WriteLine("Room area: {0} SqrFt\nGallons of paint used: {1}"
                , room.Area, room.Gallons);
            Console.WriteLine("");
        }
    }


}
