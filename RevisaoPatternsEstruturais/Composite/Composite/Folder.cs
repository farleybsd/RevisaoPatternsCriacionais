namespace RevisaoPatternsEstruturais.Composite.Composite
{
    // Composite: Pasta que pode conter outros componentes
    internal class Folder : FileSystemComponent
    {
        private readonly List<FileSystemComponent> _children = new();

        public Folder(string name) : base(name){}

        public void Add(FileSystemComponent component)
        {
            _children.Add(component);
        }

        public void Remove(FileSystemComponent component)
        {
            _children.Remove(component);
        }

        public override void Display(string indent = "")
        {
            Console.WriteLine($"{indent}[Folder] {Name}");
            foreach (var child in _children)
            {
                child.Display(indent + "  ");
            }
        }

        public override FileSystemComponent Duplicate()
        {
            var newFolder = new Folder($"{Name}_Copy");
            foreach (var child in _children)
            {
                newFolder.Add(child.Duplicate());
            }
            return newFolder;
        }

        public override long GetSize()
        {
            long totalSize = 0;
            foreach (var child in _children)
            {
                totalSize += child.GetSize();
            }
            return totalSize;
        }
    }
}
