namespace Design_Principles_Library.OOPS_Basics
{
    internal class AbstractExample
    {
        // compile with: /target:library
        public class D
        {
            public virtual void DoWork(int i)
            {
                // Original implementation.
            }

            //It is an error to use the abstract modifier on a static property.
        }

        /// <summary>
        /// An abstract class defines the core identity of a class and there it is used for objects of the same type.
        /// </summary>

        public abstract class E : D
        {
            //An abstract class can contain access modifiers for the subs, functions, properties
            //Overriden from base class D and marked as abstract
            //so that it will be defined in derived class of E
            public abstract override void DoWork(int i);

            /// <summary>
            /// An abstract method is implicitly a virtual method.
            /// </summary>
            /// <param name="i"></param>
            protected abstract void DoWork_Protected(int i);

            //It is an error to use the static or virtual modifiers in an abstract method declaration.
        }

        public class F : E
        {
            //An abstract inherited property can be overridden in a derived class
            //by including a property declaration that uses the override modifier.
            public override void DoWork(int i)
            {
                // New implementation.
            }

            protected override void DoWork_Protected(int i)
            {
                // New implementation.
            }
        }
    }
}