// Banda banda = new Banda("Evanescence");

// Album album = new Album("The Open Door");

// Musica musica = new Musica(banda, "Tourniquet")
// {
//     Duracao = 200,
//     Disponivel = true
// };

// Musica musica1 = new Musica(banda, "teste 2")
// {
//     Duracao = 254,
//     Disponivel = false
// };

// musica.ExibirFichaTecnica();

// album.AdicionarMusica(musica);
// album.AdicionarMusica(musica1);
// album.ExibirMusicasDoAlbum();


// banda.AdicionarAlbum(album);
// banda.ExibirDiscografia(); 


Episodio ep1 = new (1, "Teste 1", 45);
ep1.AddConvidados("Luiz");
ep1.AddConvidados("Aline");


Episodio ep2 = new (2, "Teste 2", 67);
ep2.AddConvidados("Luiz");
ep2.AddConvidados("Aline");


Podcast podcast = new("PodCast", "daniel");
podcast.AddEp(ep1); 
podcast.AddEp(ep2);

podcast.ExibirDetalhes();
