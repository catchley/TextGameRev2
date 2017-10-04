
namespace TextGame
{
    class Player
    {



        public int location { get; set; } = 49;
        public bool hasBooze { get; set; } = false;
        public bool hasKeys { get; set; } = false;
        public bool freshClothes { get; set; } = true;
        public bool isDirty { get; set; } = false;
        public bool hasBlanket { get; set; } = false;


       


        public void moveUp()
        {
                location -= 6;
        }

        public void moveDown()
        {
                location += 6;
        }

        public void moveLeft()
        {
                location -= 1;
        }
        public void moveRight()
        {
            location += 1;
        }


    }
}
