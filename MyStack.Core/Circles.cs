using System;
using System.Collections.Generic;
using System.Text;

namespace MyStack.Core
{
    interface IRoundObject
    {
        void Draw();
    }

    interface IGreenObject {
        void Draw();
    }
    
    class GreenCircle : IRoundObject, IGreenObject
    {
        void IRoundObject.Draw()
        {
            throw new NotImplementedException();
        }

        void IGreenObject.Draw()
        {
            throw new NotImplementedException();
        }

        public void Draw()
        {
            ((IGreenObject)this).Draw();
        }
    }


    class Program
    {
        public static void Main()
        {
            GreenCircle gc = new GreenCircle();
            gc.Draw();

            ((IGreenObject)gc).Draw();
            ((IRoundObject)gc).Draw();
        }
    }
}
