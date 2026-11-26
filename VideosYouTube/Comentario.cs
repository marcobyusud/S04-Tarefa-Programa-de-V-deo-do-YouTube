public class Comentario
{
    private readonly string _nomePessoa;
    private readonly string _texto;

    public Comentario(string nomePessoa, string texto)
    {
        _nomePessoa = nomePessoa;
        _texto = texto;
    }

    public string ObterNomePessoa()
    {
        return _nomePessoa;
    }

    public string ObterTexto()
    {
        return _texto;
    }
}