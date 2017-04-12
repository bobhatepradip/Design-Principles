using System;

namespace Design_Principles_Library.OOPS_Principles
{
    internal class _03_Observer_Pattern
    {
        //1. Declaration of Delegates. Subscriber's function should match with this return value and signature.
        public delegate void PublisherDelegateFunction(int resultValue);

        //2. Implementation of Publisher. Publisher will not depend on subscribers or their implementations.
        public class PublisherImplementation
        {
            //3. A Delegate's object for subscribers to subscribe.
            public static PublisherDelegateFunction PublisherDelegateFunctionObject;

            //4. Perform required publisher operation
            public static void PublisherImplementationFunction()
            {
                //5. Implement the required logic to be performed for the publisher.

                //LogicA.
                //LogicB.
                //LogicC.

                //6. If any subscriber registers for notification, use the Delegate's instance and send the value to subscribers.
                if (PublisherDelegateFunctionObject != null)
                {
                    // Call delegates, and pass required information, so that it will intimate the subscribers that publisher task has been completed.
                    PublisherDelegateFunctionObject(3);
                }
            }
        }

        //1. Implementation of Subscriber. Subscriber will not depend on publisher or publisher's implementations.
        public class SubScriberImplementation
        {
            public static void Main()
            {
                //2. Subscriber uses the Delegate object provided by publisher and registers for state change notification with delegates ( This will be placed in InitializeComponent() method in Web/Windows Forms)
                //2.1 Comment this registration and run, publisher will not notify the subscriber.
                PublisherImplementation.PublisherDelegateFunctionObject += new PublisherDelegateFunction(Subscriber1Function);

                //2.2 Uncomment this registration and run, it will notify only 2nd subsriber as we are not using "+=", it will overwrite the subscriber1's notification.
                //PublisherImplementation.PublisherDelegateFunctionObject = new PublisherDelegateFunction(Subscriber2Function);

                //3. Generally this step will not be part of the subscriber, testing purpose we are calling publisher publisher (Generally this will be triggered by user click events in Web/Windows Forms)
                PublisherImplementation.PublisherImplementationFunction();
            }

            //4. Perform required subscriber operation. Should match deligates method signature and return value.
            public static void Subscriber1Function(int valueFromPublisher)
            {
                //5. Implement the required logic to be performed for the subscriber.
                //Logic I.
                //Logic J.
                //Logic K.
                Console.WriteLine("Publisher Deligates informed me that an event happened and returned this value: {0}.", valueFromPublisher);
            }

            public static void Subscriber2Function(int valueFromPublisher)
            {
                //5. Implement the required logic to be performed for the subscriber.
                //Logic X.
                //Logic Y.
                //Logic Z.
                Console.WriteLine("Publisher Deligates informed me that an event happened and returned this value: {0}.", valueFromPublisher);
            }
        }
    }
}