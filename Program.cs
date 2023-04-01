// See https://aka.ms/new-console-template for more information
Console.WriteLine("--Troco--");
decimal valorcompra, valorpago, valortroco;

Console.Write("Valor compra R$:");
valorcompra = Convert.ToDecimal(Console.ReadLine());

Console.Write("Valor pago R$:");
valorpago = Convert.ToDecimal(Console.ReadLine());

valortroco = valorpago - valorcompra;

Console.Write($"\nTroco: {valortroco}");
