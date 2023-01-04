
string [] EnterArray (int size)   
{
string [] NewArray = new string [size];
for (int i = 0; i < NewArray.Length; i++)
{
Console.WriteLine ("enter the cell value"); 
NewArray [i] = Console.ReadLine();
}
Console.WriteLine (string.Join(",", NewArray));
return NewArray;
}


const int SIZE = 7;

string [] Arr = EnterArray (SIZE);
