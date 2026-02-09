
//Arodis Abreu 2025-0982

using System;

// Clase base
public class MiembroDeLaComunidad
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
}

// Heredan de MiembroDeLaComunidad
public class Empleado : MiembroDeLaComunidad
{
    public string Cargo { get; set; }
}

public class Estudiante : MiembroDeLaComunidad
{
    public string Carrera { get; set; }
}

public class ExAlumno : MiembroDeLaComunidad
{
    public int AnioGraduacion { get; set; }
}

// Heredan de Empleado
public class Docente : Empleado
{
    public string Materia { get; set; }
}

public class Administrativo : Empleado
{
    public string Departamento { get; set; }
}

// Heredan de Docente
public class Maestro : Docente
{
    public int AniosExperiencia { get; set; }
}

public class Administrador : Docente
{
    public string Nivel { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Maestro maestro = new Maestro
        {
            Nombre = "yensy guerrero",
            Edad = 45,
            Cargo = "Docente",
            Materia = "Programación",
            AniosExperiencia = 12
        };

        Estudiante estudiante = new Estudiante
        {
            Nombre = "Arodis abreu",
            Edad = 20,
            Carrera = "Ingeniería de Software"
        };

        Console.WriteLine("=== MAESTRO ===");
        Console.WriteLine($"Nombre: {maestro.Nombre}");
        Console.WriteLine($"Edad: {maestro.Edad}");
        Console.WriteLine($"Materia: {maestro.Materia}");
        Console.WriteLine($"Experiencia: {maestro.AniosExperiencia} años");

        Console.WriteLine("\n=== ESTUDIANTE ===");
        Console.WriteLine($"Nombre: {estudiante.Nombre}");
        Console.WriteLine($"Edad: {estudiante.Edad}");
        Console.WriteLine($"Carrera: {estudiante.Carrera}");
    }
}
