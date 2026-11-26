public class Video
{
    private readonly string _titulo;
    private readonly string _autor;
    private readonly int _duracaoSegundos;
    private readonly List<Comentario> _comentarios = new();

    public Video(string titulo, string autor, int duracaoSegundos)
    {
        _titulo = titulo;
        _autor = autor;
        _duracaoSegundos = duracaoSegundos;
    }

    public void AdicionarComentario(Comentario comentario)
    {
        _comentarios.Add(comentario);
    }

    public int ObterQuantidadeComentarios()
    {
        return _comentarios.Count;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Título: {_titulo}");
        Console.WriteLine($"Autor: {_autor}");
        Console.WriteLine($"Duração: {_duracaoSegundos} segundos");
        Console.WriteLine($"Comentários: {ObterQuantidadeComentarios()}");

        foreach (Comentario comentario in _comentarios)
        {
            Console.WriteLine($"- {comentario.ObterNomePessoa()}: {comentario.ObterTexto()}");
        }
    }
}