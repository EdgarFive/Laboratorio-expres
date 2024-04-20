using LaboratorioProgra1.ClaseHija;
using LaboratorioProgra1.EjemploPolimorfismo;
using LaboratorioProgra1.EjemploPolimorfismo.Heredados;
using LaboratorioProgra1.Laboratorio;

static void EjemploPolimorfismo()
{
    Animal[] animales = new Animal[3];
    animales[0] = new Tortuga();
    animales[1] = new Gato();
    animales[2] = new Perro();
    foreach (Animal animal in animales)
    {
        animal.HacerSonido();
    }
}   

static void Laboratorio()
{
    VideoJuego vvvideoJuego = new VideoJuego();
    vvvideoJuego.Titulo = "The Legend of Zelda: Breath of the Wild";
    vvvideoJuego.Desarrolladora = "Nintendo";
    vvvideoJuego.Calificacion = 50;
    vvvideoJuego.AnioLanzamiento = 2017;
    vvvideoJuego.MostrarInformacion();
}

static void ffJuegoAccion()
{
    JuegoAccion CCjuegoAccion = new JuegoAccion();
    CCjuegoAccion.Titulo = "Call of Duty";
    CCjuegoAccion.Desarrolladora = "Activision";
    CCjuegoAccion.Calificacion = 9;
    CCjuegoAccion.AnioLanzamiento = 2014;

    CCjuegoAccion.Esparamenores = true;

    CCjuegoAccion.MostrarInformacion_Juegoaccion();
}

static void ffJuegoDeportes()
{
    JuegoDeportes CCjuegodeportes = new JuegoDeportes();
    CCjuegodeportes.Titulo = "Juegos Olimpicos";
    CCjuegodeportes.Desarrolladora = "Nintendo";
    CCjuegodeportes.Calificacion = 10;
    CCjuegodeportes.AnioLanzamiento = 2018;
    CCjuegodeportes.Deportes = "Atletismo.\nFutbol.\nNatación.";

    CCjuegodeportes.MostrarInformacion_Juegodeportes();
}

static void ffJuegosAventura()
{
    JuegoAventura CCjuegoaventura = new JuegoAventura();
    CCjuegoaventura.Titulo = "ManuelBros";
    CCjuegoaventura.Desarrolladora = "Nintendo";
    CCjuegoaventura.Calificacion = 3;
    CCjuegoaventura.AnioLanzamiento = 2013;
    CCjuegoaventura.Mundo_abierto = true;

    CCjuegoaventura.MostrarInformacion_JuegoAventura();
}


ffJuegoAccion();
Console.WriteLine("");
ffJuegoDeportes();
Console.WriteLine("");
ffJuegosAventura();

Console.ReadKey();
//Laboratorio();
//VideoJuego.listaDeJuegos();





Console.WriteLine();



