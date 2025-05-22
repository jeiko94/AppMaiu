using ProyectoFinal.Models;
using System.Collections.ObjectModel;

namespace ProyectoFinal.Views;

public partial class DashboardView : ContentPage
{
	public ObservableCollection<Profile> Perfiles { get; set; }
    public ObservableCollection<GenerarImagen> GenerarImagenes { get; set; }

    public DashboardView()
	{
		InitializeComponent();
		LoadData();
		BindingContext = this;
	}

	private void LoadData()
	{
		Perfiles = new ObservableCollection<Profile>
		{
            new Profile
            {
                ImagenPerfil = "montain.png",
                Nombre = "Yeisson",
                NumeroFotos = 10
            },
            new Profile
            {
                ImagenPerfil = "dotnet_bot.png",
                Nombre = "Camila",
                NumeroFotos = 7
            },
            new Profile
            {
                ImagenPerfil = "dotnet_bot.png",
                Nombre = "Mateo",
                NumeroFotos = 15
            },
            new Profile
            {
                ImagenPerfil = "dotnet_bot.png",
                Nombre = "Valentina",
                NumeroFotos = 12
            },
            new Profile
            {
                ImagenPerfil = "dotnet_bot.png",
                Nombre = "Santiago",
                NumeroFotos = 9
            }
        };

        GenerarImagenes = new ObservableCollection<GenerarImagen>
        {
            new GenerarImagen
            {
                RutaImagen = "montain.png",
                MainKeyword = "Montaña",
                Keywords = new List<string> { "paisaje", "naturaleza", "nieve" }
            },
            new GenerarImagen
            {
                RutaImagen = "ciudad.png",
                MainKeyword = "Ciudad",
                Keywords = new List<string> { "edificios", "nocturno", "luces" }
            },
            new GenerarImagen
            {
                RutaImagen = "playa.png",
                MainKeyword = "Playa",
                Keywords = new List<string> { "arena", "mar", "sol" }
            },
            new GenerarImagen
            {
                RutaImagen = "bosque.png",
                MainKeyword = "Bosque",
                Keywords = new List<string> { "árboles", "verde", "sendero" }
            },
            new GenerarImagen
            {
                RutaImagen = "desierto.png",
                MainKeyword = "Desierto",
                Keywords = new List<string> { "arena", "calor", "dunas" }
            }
        };
    }
}