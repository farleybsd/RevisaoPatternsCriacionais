namespace RevisaoPatternsEstruturais.Composite.TiposDeArquivos
{
    // Passo 2
    // Classes que iram ser composta
    // Folha: Arquivo individual
    internal class File : FileSystemComponent
    {
        public long Size { get; private set; }

        public File(string name, long size) : base(name)
        {
            Size = size;
        }

        public override void Display(string indent = "")
        {
            Console.WriteLine($"{indent}- {Name} ({Size} MB)");
        }

        public override FileSystemComponent Duplicate()
        {
            return new File($"{Name}_Copy", Size);
        }

        public override long GetSize()
        {
            return Size;
        }
    }
}
