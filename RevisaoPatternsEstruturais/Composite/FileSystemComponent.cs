namespace RevisaoPatternsEstruturais.Composite
{
     // Passo 1
    // Componente base
    // Arquivo Contem as operacoes
    internal abstract class FileSystemComponent
    {
        // Propiedade em comum
        public string Name { get; set; }

        public FileSystemComponent(string name)
        {
            Name = name;
        }

        // Operacoes
        public abstract void Display(string indent = "");
        public abstract long GetSize();
        public abstract FileSystemComponent Duplicate();
    }
}
