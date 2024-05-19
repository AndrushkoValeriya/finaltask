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
string [] symbol (string [] Array)
{
  int n = 0;
  for (int i = 0 ; i <Array.Length ; i++)
  {
    if (Array[i].Length <=3)
    n++;
  }
  string [] rezult = new string [n];
  int j = 0;
  for (int i = 0; i < Array.Length ; i++)
  {
    if (Array[i].Length <=3)
    {
        rezult[j] = Array[i];
        j++;
    }
  }
  return rezult;
}

void print(string [] Array)
{
    Console.Write("Массив с элеменами, где не более 3-х символов:");
    Console.Write("[");
    for (int i = 0; i < Array.Length; i++)
    {
    Console.Write($"‘{Array[i]}’"+", ");
    }
    Console.Write("]");
}
array(Array);
print(symbol(Array));
