List<Video> videos = new();

Video video1 = new("Como fazer pão", "Forno do Bento", 480);
video1.AdicionarComentario(new Comentario("Yara", "A receita ficou ótima!"));
video1.AdicionarComentario(new Comentario("Caio", "Posso usar farinha integral?"));
video1.AdicionarComentario(new Comentario("Dandara", "Fiz hoje e deu certo."));
videos.Add(video1);

Video video2 = new("Introdução à fotografia", "Luz & Lente da Yara", 635);
video2.AdicionarComentario(new Comentario("Ícaro", "As dicas de iluminação ajudaram bastante."));
video2.AdicionarComentario(new Comentario("Maitê", "Qual câmera você recomenda para iniciantes?"));
video2.AdicionarComentario(new Comentario("Luan", "Gostei do exemplo com luz natural."));
video2.AdicionarComentario(new Comentario("Noemi", "Vídeo muito claro, obrigado!"));
videos.Add(video2);

Video video3 = new("Passeio por Lisboa", "Rota do Ícaro", 912);
video3.AdicionarComentario(new Comentario("Zoe", "Quero visitar esse lugar."));
video3.AdicionarComentario(new Comentario("Breno", "A vista é linda!"));
video3.AdicionarComentario(new Comentario("Tainá", "Onde fica esse café?"));
videos.Add(video3);

foreach (Video video in videos)
{
    video.ExibirInformacoes();
    Console.WriteLine();
}