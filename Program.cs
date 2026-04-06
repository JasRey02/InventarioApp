// ============================================================
// SISTEMA DE INVENTARIO - Clase 1.1
// Estado: Mensaje de bienvenida
// ============================================================

using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;


Console.WriteLine("==========================================");
Console.WriteLine("    SISTEMA DE GESTIÓN DE INVENTARIO      ");
Console.WriteLine("==========================================");
Console.WriteLine();
Console.WriteLine($"Version: {version}");
Console.WriteLine($"Plataforma: {Environment.OSVersion}");
Console.WriteLine($".NET Version: {Environment.Version}");
Console.WriteLine("Estado: Proyecto inicializado");
Console.WriteLine("Estructura del Proyecto");
Console.WriteLine("Configuracion .csproj");
Console.WriteLine("Carpeta src creada");
Console.WriteLine("Metadatos configurados");
Console.WriteLine("Metadatos configurados");

