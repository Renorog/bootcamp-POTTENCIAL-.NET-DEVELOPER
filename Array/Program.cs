

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");
listaString.Add("BA");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("BA");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");











// int[] arrayInteiros = new int[3];

// arrayInteiros[0]= 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;

// int tamanho = arrayInteiros.Length;

// // percorrendo o array com o for
// // for (int contador = 0; contador < tamanho; contador++){
// //     Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
// // }


// // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// int[] arrayInteirosDrobrado = new int[arrayInteiros.Length * 2];

// Array.Copy(arrayInteiros, arrayInteirosDrobrado, arrayInteiros.Length);



// int contadorForeach = 0;
// foreach(int valor in arrayInteiros){
//     Console.WriteLine($"Posição Nº {contadorForeach} - {valor}");
//     contadorForeach++;

// }



