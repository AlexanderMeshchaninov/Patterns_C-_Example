using System;
using Mediator_Example.Example1.Realization;
using Mediator_Example.Example2.Abstractions;
using Mediator_Example.Example2.Realization;

namespace Mediator_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Клиентский код
                ComponentA componentA = new ComponentA();
                ComponentB componentB = new ComponentB();
                ComponentC componentC = new ComponentC();

                new ConcreteMediator(componentA, componentB, componentC);
                
                Console.WriteLine("Client triggers operation A.");
                componentA.DoA();
                
                Console.WriteLine("Client triggers operation B.");
                componentB.DoB();
                
                Console.WriteLine("Client triggers operation C and D.");
                componentC.DoC();
                componentC.DoD();
            }

            {
                // Create chatroom
                ChatRoom chatroom = new ChatRoom();

                // Create participants and register them
                ParticipantBase George = new SimpleAccount("George");
                ParticipantBase Paul   = new SimpleAccount("Paul");
                ParticipantBase Ringo  = new SimpleAccount("Ringo");
                ParticipantBase John   = new VipAccount("John") ;
                ParticipantBase Yoko   = new VipAccount("Yoko");

                chatroom.Register(George);
                chatroom.Register(Paul);
                chatroom.Register(Ringo);
                chatroom.Register(John);
                chatroom.Register(Yoko);

                // Chatting participants
                Yoko.Send ("John", "Hi John!");
                Paul.Send ("Ringo", "All you need is love");
                Ringo.Send("George", "My sweet Lord");
                Paul.Send ("John", "Can't buy me love");
                John.Send ("Yoko", "My sweet love") ;

                // Wait for user
                Console.Read();
            }
        }
    }
}