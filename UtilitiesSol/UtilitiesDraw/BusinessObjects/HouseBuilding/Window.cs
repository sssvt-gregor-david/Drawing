using System;
using System.Drawing;
using UtilitiesDraw.PaintersObjects;

namespace UtilitiesDraw.BusinessObjects.HouseBuilding
{



    public class Window : BuildingElement
    {



        private string modelName;
        private double width;
        private double height;



        public Window(string modelName, double width, double height)
        {
            this.modelName = modelName;
            this.width = width;
            this.height = height;
        }



        public string ModelName
        {
            get
            {
                return modelName;
            }

            set
            {
                modelName = value;
            }
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



        // Model "Standard", 0,8 metru x 1,5 metru
        public static Window GetStandardWindow()
        {
            Window window = new Window("Standard", 0.8, 1.5);
            return window;
        }



        // Model "Francouz", 1,0 metru x 2,2 metru
        public static Window GetFrenchWindow()
        {
            Window window = new Window("Francouz", 1.0, 2.2);
            return window;
        }

        public override void DrawSelf(Graphics g, CanvasContext context) //okno modelu Standard - zakomentovaná část je dynamická ale nejsou tam rozměry dle zadání
        {

            //using (Pen pen = new Pen(Color.SkyBlue, 10000000.0f))
            //{

            //    g.DrawLine(pen, context.Left + context.Width / 2, context.Top, context.Left + context.Width / 2, context.Top + context.Height);

            //}

            //using (Pen pen = new Pen(Color.SaddleBrown, 5.0f))
            //{

            //    g.DrawRectangle(pen, context.Left, context.Top, context.Width-3, context.Height-3);
            //    g.DrawLine(pen, context.Left, context.Top + context.Height / 2, context.Left + context.Width, context.Top + context.Height / 2);
            //    g.DrawLine(pen, context.Left + context.Width / 2, context.Top, context.Left + context.Width / 2, context.Top + context.Height);

            //}





            using (Pen pen = new Pen(Color.SaddleBrown, 5.0f)) //dřevěná část okna
            {


                g.DrawRectangle(pen, 250, 200, 40, 75);
                g.DrawRectangle(pen, 290, 200, 40, 75);
                g.DrawRectangle(pen, 290, 275, 40, 75);
                g.DrawRectangle(pen, 250, 275, 40, 75);
            }

            using (Pen pen = new Pen(Color.SkyBlue, 25.0f)) //skleněná část okna
            {



                g.DrawRectangle(pen, 265, 215, 10, 45);
                g.DrawRectangle(pen, 305, 290, 10, 45);
                g.DrawRectangle(pen, 305, 215, 10, 45);
                g.DrawRectangle(pen, 265, 290, 10, 45);
            }

            using (Pen pen = new Pen(Color.SaddleBrown, 5.0f)) //tohle jsou taková dřevíčka která když otočíte o 90 stupňů tak vám umožní otevřít to okno (okno je tvořeno z levé a pravé části)
            {
                g.DrawLine(pen, 283, 215, 298, 215);
                g.DrawLine(pen, 283, 335, 298, 335);
            }
        }

    }



}
