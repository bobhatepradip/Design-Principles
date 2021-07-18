using System;

namespace Design_Principles_Library
{
    // If any module is using a Base class then the reference to that Base class can be replaced with a Derived class without affecting the functionality of the module.

    // Or

    // While implementing derived classes, one needs to ensure that, derived classes just extend the functionality of base classes without replacing the functionality of base classes.
    public class Rectangle
    {
        protected int mWidth = 0;
        protected int mHeight = 0;

        public virtual void SetWidth(int width)
        {
            Console.WriteLine(string.Format("Rectangle Width:{0}", width));
            mWidth = width;
        }

        public virtual void SetHeight(int height)
        {
            Console.WriteLine(string.Format("Rectangle Width:{0}", height));
            mHeight = height;
        }

        public virtual int GetArea()
        {
            Console.WriteLine(string.Format("Rectangle Area:"));
            return mWidth * mHeight;
        }
    }

    // While implementing derived class if one replaces the functionality of base class then,
    // it might results into undesired side effects when such derived classes are used in existing program modules.
    public class Square : Rectangle
    {
        // This class modifies the base class functionality instead of extending the base class functionality

        // Now below methods implementation will impact base class functionality.
        public override void SetWidth(int width)
        {
            Console.WriteLine(string.Format("Square Width and Height:{0}", width));
            mWidth = width;
            mHeight = width;
        }

        public override void SetHeight(int height)
        {
            Console.WriteLine(string.Format("Square Height/Width:{0}", height));
            mWidth = height;
            mHeight = height;
        }

        public override int GetArea()
        {
            Console.WriteLine(string.Format("$$$ Square Area:"));
            if (mWidth<10)
            {
                throw new Exception("width should be less than 10");
            }
            return mWidth * mHeight;
        }
    }

    public static class LiskovSubstitutionPrincipleDemo
    {
        public static Rectangle CreateInstance(bool isRectangle)
        {
            // As per Liskov Substitution Principle "Derived types must be completely substitutable for their base types".
            //bool isRectangle = false;
            if (isRectangle == true)
            {
                return new Rectangle();
            }
            else
            {
                return new Square();
            }
        }

        public static void LSPDemo(bool isRectangle)
        {
            Console.WriteLine("\n\nLiskov Substitution Principle Demo ");

            Rectangle RectangleObject = CreateInstance(isRectangle);

            // User assumes that RectangleObject is a rectangle and (s)he is able to set the width and height as for the base class
            RectangleObject.SetWidth(5);
            RectangleObject.SetHeight(10);

            // Now this results into the area 100 (10 * 10 ) instead of 50 (10 * 5).
            Console.WriteLine("Liskov Substitution Principle has been violated and returned wrong result : " + RectangleObject.GetArea());

            // So once again I repaet that sub classes should extend the functionality, sub classes functionality should not impact base class functionality.
        }
    }
}