Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

string [] Array = new string [n];
void array(string [] Array)
{
  for (int i = 0; i < Array.Length ; i++)
  {
     Console.WriteLine($"Введите {i+1} элемент массива");
     Array[i] = Console.ReadLine();
  }
}

