using System;

namespace DoFactory
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the ConcreteCreator1.");
            ClientCode(new ConcreteCreator1());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the ConcreteCreator2.");
            ClientCode(new ConcreteCreator2());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the ConcreteCreator3.");
            ClientCode(new ConcreteCreator3());
        }

        // El código del cliente funciona con una instancia de un creador concreto, aunque
        // a través de su interfaz base. Mientras el cliente siga trabajando con
        // el creador a través de la interfaz base, puede pasarle la subclase de cualquier creador
        private void ClientCode(Creator creator)
        {
            // ...
            Console.WriteLine($"Client: I'm not aware of the creator's class, but it still works.\n {creator.SomeOperation()}");
            // ...
        }
    }
}
