using System;
using System.Drawing;
using UtilitiesDraw.PaintersObjects;


namespace UtilitiesDraw.BusinessObjects.HouseBuilding
{



    public class Door : BuildingElement
    {



        private double width;
        private double height;
        private bool isDoubleWinged;



        public Door(double width, double height, bool isDoubleWinged)
        {
            this.width = width;
            this.height = height;
            this.isDoubleWinged = isDoubleWinged;
        }



        public double Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public bool IsDoubleWinged
        {
            get
            {
                return isDoubleWinged;
            }

            set
            {
                isDoubleWinged = value;
            }
        }



        // Dveře: 0,9 metru x 2,2 metru, jednokřídlé
        public static Door GetSingleDoor()
        {
            Door door = new Door(0.9, 2.2, false);
            return door;
        }



        // Dveře: 1,8 metru x 2,1 metru, dvoukřídlé
        public static Door GetDoubleDoor()
        {
            Door door = new Door(1.8, 2.1, true);
            return door;
        }

        public override void DrawSelf(Graphics g, CanvasContext context)
        {
            int doorHeight = 250;
            int doorWidth = 150;
            int innerRectangleHeight = 100;
            int innerRectangleWidth = 100;
            int doorHandleHeight = 5;
            int doorHandleWidth = 30;
            Rectangle door = new Rectangle(context.Left + 50, context.Height - doorHeight + 20, doorWidth, doorHeight);
            Rectangle doorInnerRectangle = new Rectangle(door.Left + 25, context.Height - doorHeight + 40, innerRectangleWidth, innerRectangleHeight);
            Rectangle doorHandle = new Rectangle(door.Left + 15, context.Height - doorHeight + 150, doorHandleWidth, doorHandleHeight);
            
            using (Pen pen = new Pen(Color.Black, 2.0f))
            {
                g.DrawRectangle(pen, door);
                g.DrawRectangle(pen, doorInnerRectangle);
                g.DrawRectangle(pen, doorHandle);
                
            }
        }



    }



}
