using System;

namespace PeopleRecursive
{
//    Tu red social esta empezando y lo vas a petar, se va a llamar CaraLibro
//    (no tienes equipo de marketing aún) Se te va a proveer de un array de personas
//    y debes de indicar con cuantas personas ha de hablar para llegar a otra personas

//así pues

//si tienes algo así

//|Juan| Pedro| |Juan| Fernando| |Fernando| Maria| |Maria| Clara|

//Saludar(Juan, Pedro) = Juan -> Pedro Saludar(Fernando, Maria) = Fernando -> Maria
//Saludar(Juan, Maria) = Juan -> Fernando -> Maria Saludar(Juan, Clara) = Juan -> Fernando ->
//Maria -> Clara Saludar(Juan, Luis) = not found

//Extra Saludar(Pedro, Fernando) = Pedro -> Fernando -
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe las personas que quieres que se saluden");
            string people = Console.ReadLine();
            Console.WriteLine("Las personas que van a saludarse son: ");
            Console.WriteLine(Saludar(people));
            Console.WriteLine("El primer saludo se va a realizar con: ");
            string people1 = Console.ReadLine();
            Console.WriteLine("Saludo realizado entre:  ");
            Console.WriteLine(PrimerSaludo(people1));
            


        }
        //Juan, string Pedro, string Maria, string Clara, string Fernando
        //con esto consigo mostrar la lista de las personas que quiero que se saluden
        public static string Saludar(string people )
        {
            if(people.Length<= 1)
            {
                return people;
            }
            char PrimerNombre = people[0];

            string lista = people.Substring(1);
            return people;
        }
        //ahora tengo que implementar quien se debe saludar con quien
        public static string PrimerSaludo(string people1)
        {
            if (people1.Length <= 1)
            {
                return people1;
            }
            char PrimerNombre = people1[0];
            //substring--> empieza por la posicion especificada y acaba cuando termina la string.
            string lista = people1.Substring(1);
            return people1;
        }

    }
}
