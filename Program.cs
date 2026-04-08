// ============================================================
// SISTEMA DE INVENTARIO - Clase 1.1
// Estado: Mensaje de bienvenida
// ============================================================

using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

MostrarBanner();

if(args.Length > 0)
{
    switch(args[0].ToLower())
    {
        case "--help":
            MostrarAyuda();
            Environment.Exit(0);
            break;
        case "--version":
            Console.WriteLine($"Version: {version}");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine($"Comando desconocido: {args[0]}");
            Environment.Exit(2);
            break;
    }
}

int cantidadProductos = 0;
decimal valorTotalDeInventario = 0.00m;
bool sistemaActivo = true;
string nombreSistema = "Sistema de Gestion de Inventario";

/*string? nombre = null;
int longitud = nombre.Length;
Console.WriteLine($"Longitud: {longitud}");*/

//problema un readline puede devolver null
/*Console.Write("Ingrese un valor:");
string? entrada2 = Console.ReadLine();

//Solucion
string comando = string.IsNullOrEmpty(entrada2) ? "salir" : entrada2;
Console.WriteLine($"Comando recibido: {comando}");*/


/*Console.Write("Ingrese un valor:");
string? entrada3 = Console.ReadLine();
int? longitud = entrada3?.Length;

string comandoLimpio = string.IsNullOrEmpty(entrada3) ? "salir" : entrada3.Trim().ToLower();

Console.WriteLine($"Longitud: {longitud ?? 0}");
Console.WriteLine($"Comando limpio: {comandoLimpio}");*/

Console.WriteLine("Comandos: listar, agregar, buscar, salir");
Console.WriteLine();

while(sistemaActivo)
{
    Console.Write("Inventario:");
    string? entradausuario = Console.ReadLine();

    //Aplicamos el manejo seguro
    string comando = string.IsNullOrEmpty(entradausuario) ? "salir" : entradausuario.Trim().ToLower();
    //string comando = entradausuario?.Trim().ToLower() ?? "salir";

    switch(comando)
    {
        case "salir":
            Console.WriteLine("Saliendo del programa...");
            sistemaActivo = false;
            break;
        case "listar":
            Console.WriteLine($"Productos de inventario {cantidadProductos}");
            break;
        case "":
            //Console.WriteLine("Comando vacio");
            break;  
        default:
            Console.WriteLine($"Comando desconocido: {comando}");
            Console.WriteLine("Comandos disponibles: listar, agregar, buscar, salir ");
            break;  
    }

}




/*Console.WriteLine("Estado del Sistema");
Console.WriteLine($"Nombre : {nombreSistema}");
Console.WriteLine($"Cantidad de Productos: {cantidadProductos}");
Console.WriteLine($"Valor Total del Inventario: ${valorTotalDeInventario:N2}");
Console.WriteLine($"Sistema Activo: {(sistemaActivo ? "Si" : "No")}");

Console.Write("Ingrese una cantidad:");
string? entradaCantidad = Console.ReadLine();
//conversion segura con tryparse
if(int.TryParse(entradaCantidad, out int cantidad))
{
    Console.Write($"Cantidad valida: {cantidad}\n");
    cantidadProductos = cantidad;
}
else
{
    Console.WriteLine("Error: debe ingresar un numero entero");
}

Console.Write("Ingrese un precio:");
string? entradaPrecio = Console.ReadLine();
//conversion segura con tryparse
if(decimal.TryParse(entradaPrecio, out decimal precio2))
{
    Console.Write($"Precio valido: ${precio2:N2}\n");
    valorTotalDeInventario = cantidadProductos * precio2;
    Console.WriteLine($"Valor Total del Inventario: ${valorTotalDeInventario:N2}");
}
else
{
    Console.WriteLine("Error: debe ingresar un numero decimal");
}   
//MostrarBanner();

//Modo interactivo si no hay argumentos
Console.Write("Ingrese un comando o ingrese salir para terminar: ");
string? entrada = Console.ReadLine(); //STDIN para leer la entrada de usuario

if (string.IsNullOrWhiteSpace(entrada) || entrada.ToLower() == "salir")
{
    Console.WriteLine("Saliendo del programa...");//stdout salida en pantalla al usuario
    Environment.Exit(0);
}*/


/*Console.WriteLine("Estructura del Proyecto");
Console.WriteLine(" InventarioApp/");
Console.WriteLine("    |-- Program.cs");
Console.WriteLine("    |-- InventarioApp.csproj");
Console.WriteLine("    |-- gitignore");
Console.WriteLine("    |-- README.md");
Console.WriteLine("    |-- src/");
Console.WriteLine("         |-- Models/");
Console.WriteLine("Configuracion .csproj");
Console.WriteLine("Carpeta src creada");
Console.WriteLine("Metadatos configurados");*/

///FUNCIONES////
void MostrarAyuda()
{
    Console.WriteLine("USO: InventarioApp [comando] [opciones]");
    Console.WriteLine();
    Console.WriteLine("COMANDOS:");
    Console.WriteLine("  --help, -h      Muestra esta ayuda");
    Console.WriteLine("  --version, -v   Muestra la version del programa");
    Console.WriteLine();
    Console.WriteLine("EJEMPLOS:");
    Console.WriteLine(" dotnet run -- --help");
    Console.WriteLine(" dotnet run -- --version");
}

void MostrarBanner()
{
    Console.WriteLine("==========================================");
    Console.WriteLine("    SISTEMA DE GESTIÓN DE INVENTARIO      ");
    Console.WriteLine("==========================================");
    Console.WriteLine();
    Console.WriteLine($"Version: {version}");
    Console.WriteLine($"Plataforma: {Environment.OSVersion}");
    Console.WriteLine($".NET Version: {Environment.Version}");
}