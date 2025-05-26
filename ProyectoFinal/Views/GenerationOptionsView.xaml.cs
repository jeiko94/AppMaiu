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
            new ArtStyle() {Nombre = "Cartoon", ImagenUrl = "bosque.png"},
            new ArtStyle() {Nombre = "Realistic", ImagenUrl = "bosque.png"},
            new ArtStyle() {Nombre = "Anime", ImagenUrl = "ciudad.png"},
            new ArtStyle() {Nombre = "Pixel Art", ImagenUrl = "ciudad.png"},
            new ArtStyle() {Nombre = "Acuarela", ImagenUrl = "desierto.png"},
            new ArtStyle() {Nombre = "Pop Art", ImagenUrl = "desierto.png"},
            new ArtStyle() {Nombre = "Impresionista", ImagenUrl = "montain.png"},
            new ArtStyle() {Nombre = "Surrealista", ImagenUrl = "montain.png"},
            new ArtStyle() {Nombre = "Minimalista", ImagenUrl = "bosque.png"},
            new ArtStyle() {Nombre = "Abstracto", ImagenUrl = "bosque.png"}
        };

    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GeneradorImagenView());
    }
}