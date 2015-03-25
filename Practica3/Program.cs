/*
 * Created by SharpDevelop.
 * User: MARTIN
 * Date: 24/03/2015
 * Time: 11:32 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections;

	namespace Alumno
	{

		class Alumno
		{
			static Hashtable tabla = new Hashtable();

			public string nombre;
			public string codigo;

			public static void Main(string[] args)
			{
			
			int opcion;
			bool comp = false;
			do{
				Console.Clear();
			Console.WriteLine ("Seleccionar \n\n 1) agregar nuevo alumno\n 2) eliminar alumno \n 3) ver alumnos registrados\n 4) salir");
			opcion = int.Parse(Console.ReadLine());	


			

			switch (opcion) {
			case 1:

				Console.WriteLine ("cantidad de alumnos");
				int alum = int.Parse (Console.ReadLine ());	

				for (int i=0; i<alum; i++) 
				{
					Alumno p = new Alumno ();
					Console.WriteLine ("Nombre: ");
					p.nombre = Console.ReadLine ();
					Console.WriteLine ("Codigo: ");
					p.codigo = Console.ReadLine ();
					tabla.Add (p.codigo, p.nombre);
				}
				comp = true;
				break; 
			
			case 2:
				if (comp == false)
					Console.WriteLine ("\t\"ERROR\" No existe ");
				else{
								
						Console.WriteLine ("codigo de alumno a eliminar");
						string CodElim = Console.ReadLine ();
						if (tabla.Contains (CodElim)) {
							
							Console.WriteLine ("\n Alumno a eliminar: ");
							Console.WriteLine ("\n Codigo: " + CodElim);
							Console.WriteLine (" Nombre: " + tabla [CodElim].ToString ());
							Console.WriteLine (" Esta seguro de eliminar \"s\" o \"n\"");
							char answ2 = char.Parse (Console.ReadLine ());
							if (answ2 == 's') {
								tabla.Remove (CodElim);
								Console.WriteLine ("\n Alumno eliminado");
							
						} else
							Console.WriteLine ("\n No existe el codigo que ingreso");
					} else
						Console.WriteLine ("\n Registre un alumno");
				}
				break;
			case 3:
					if (comp == false)
						Console.WriteLine ("\t\"ERROR\" no existe ningun alumno");
					else {
				
				Console.WriteLine ("\n Alumnos registrados: ");
				Console.WriteLine ("\n\t Codigo \t Nombre ");
				foreach (DictionaryEntry de in tabla)
					Console.WriteLine ("\t  {0}\t\t{1}", de.Key, de.Value);
				Console.WriteLine ();
					}
				break;

			case 4:
				Console.WriteLine ("Gracias");
				break; 
			
				default:
					Console.WriteLine("\t\"ERROR\" opcion no valida!!!");
					break;
						}

				Console.ReadLine();
					}
				while(opcion !=4);

			Console.ReadKey (true);
				}

		}
	}