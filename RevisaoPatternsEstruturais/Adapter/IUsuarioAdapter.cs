namespace RevisaoPatternsEstruturais.Adapter
{
    // Interface do Adapter
    internal interface IUsuarioAdapter
    {
        UsuarioCommandCreate Adapt(UsuarioRequest request);
    }
}
