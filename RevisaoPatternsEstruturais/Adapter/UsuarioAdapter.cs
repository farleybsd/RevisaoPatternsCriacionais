namespace RevisaoPatternsEstruturais.Adapter
{
    internal class UsuarioAdapter : IUsuarioAdapter
    {
        public UsuarioCommandCreate Adapt(UsuarioRequest request)
        {
            return new UsuarioCommandCreate
            {
                Nome = request.Nome,
                Email = request.Email,
                Idade = request.Idade
            };
        }
    }
}
