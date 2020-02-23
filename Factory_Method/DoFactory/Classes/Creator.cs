namespace DoFactory
{
    // La clase Creator declara el método de fábrica que devuelve
    // un objeto de una clase de Producto. Las subclases del Creador generalmente proporcionan
    // la implementación de este método.
    public abstract class Creator
    {
        // Tenga en cuenta que el Creador también puede proporcionar alguna implementación predeterminada de
        // el factory method.
        public abstract IProduct FactoryMethod();

        // También tenga en cuenta que, a pesar de su nombre, la responsabilidad principal del Creador no es crear productos.
        // Por lo general, contiene cierta lógica empresarial central que se basa en objetos de Producto, devueltos por el método de fábrica.
        // Las subclases pueden cambiar indirectamente esa lógica empresarial anulando el método de fábrica y devolviendo un tipo diferente de producto.
        public string SomeOperation()
        {
            // Llame al método de fábrica para crear un objeto Producto.
            IProduct product = FactoryMethod();

            // Ahora, use el producto
            return $"Creator: The same creator's code has just worked with {product.Operation()}";
        }
    }
}
