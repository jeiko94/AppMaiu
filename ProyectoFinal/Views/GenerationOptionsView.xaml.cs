using ProyectoFinal.Models;

namespace ProyectoFinal.Views;

public partial class GenerationOptionsView : ContentPage
{
	public List<string> Options { get; set; }
	public List<ArtStyle> Estilos { get; set; }

	public GenerationOptionsView()
	{
		InitializeComponent();
        FillOptions();
        BindingContext = this;
	}

	private void FillOptions()
	{
        Options = new List<string>
		{
			"Tierra",
			"Invierno",
			"Arboles"
		};

        Estilos = new List<ArtStyle>()
        {
            new ArtStyle() {Nombre = "Cartoon", ImagenUrl = "cartoon.png"},
            new ArtStyle() {Nombre = "Surrealista", ImagenUrl = "surrealista.png"},
            new ArtStyle() {Nombre = "Pop Art", ImagenUrl = "pop.png"},
            new ArtStyle() {Nombre = "Impresionista", ImagenUrl = "impresionista.png"},
            new ArtStyle() {Nombre = "Realistic", ImagenUrl = "realistic.png"},
            new ArtStyle() {Nombre = "Anime", ImagenUrl = "anime.png"},
            new ArtStyle() {Nombre = "Pixel Art", ImagenUrl = "pixel.png"},
            new ArtStyle() {Nombre = "Acuarela", ImagenUrl = "acuarela.png"}
            
        };

    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GeneradorImagenView());
    }
}