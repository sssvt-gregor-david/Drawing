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

        //public override void DrawSelf(Graphics g, CanvasContext context)
        //{

        //}


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

            //using (Pen pen = new Pen(Color.SaddleBrown, 9999.0f))
            //{
            //    g.DrawLine(pen, context.Left + context.Width / 2, context.Top, context.Left + context.Width / 2, context.Top + context.Height);
            //}

            //using (Pen pen = new Pen(Color.SandyBrown, 10.0f))
            //{
            //    g.DrawRectangle(pen, context.Left, context.Top, context.Width-5, context.Height-5);
            //}

            //using (Pen pen = new Pen(Color.SandyBrown, 5.0f))
            //{
            //    g.DrawLine(pen, context.Left, context.Top + context.Height / 2, context.Left + context.Width, context.Top + context.Height / 2);
            //}





            using (Pen pen = new Pen(Color.SandyBrown, 5.0f))
            {
                g.DrawRectangle(pen, 300, 150, 90, 110);
                g.DrawRectangle(pen, 300, 260, 90, 110);

            }

            using (Pen pen = new Pen(Color.SaddleBrown, 45.0f))
            {
                g.DrawRectangle(pen, 325, 175, 40, 60);
                g.DrawRectangle(pen, 325, 285, 40, 60);

            }

            using (Pen pen = new Pen(Color.Gold, 5.0f))//klika
            {
                g.DrawEllipse(pen, 360, 250, 5, 20);
                g.DrawLine(pen, 360, 255, 380, 255);

            }

            using (Pen pen = new Pen(Color.Black, 5.0f))//rámeček pro štítek pro jméno majitele bytu
            {
                g.DrawRectangle(pen, 335, 175, 20, 10);

            }

            using (Pen pen = new Pen(Color.White, 5.0f))//štítek
            {
                g.DrawRectangle(pen, 339, 179, 12, 2);

            }
        }

    }



}
