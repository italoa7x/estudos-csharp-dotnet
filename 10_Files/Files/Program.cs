Console.WriteLine("### Files ###");


string caminhoOrigem = @"C:\Users\darkc\Documents\curso_csharp\10_Files\Files\dados\arquivo.txt";

// File.Create(caminhoOrigem);

File.WriteAllText(caminhoOrigem, "testando escrita de arquivo\r\n");

string novoTexto = $"O poeta é um fingidor {Environment.NewLine}Finge tão complementar\n";


File.AppendAllText(caminhoOrigem, novoTexto);