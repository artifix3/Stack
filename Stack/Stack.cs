//Creating Stack in string type 
Stack<string> fruits = new Stack<string>();

//Adding some fruits to our Stack

fruits.Push("Apple");
fruits.Push("Banana");
fruits.Push("Peach");
fruits.Push("Strawberries");
fruits.Push("Oranges");

// Print all stack elements 

foreach (var item in fruits)
{
    Console.WriteLine(item + " ");
}

//POP method -> print last added element and remove it . If our stack is empty we will get InvalidOperationException. 
Console.WriteLine("------------------------ Using POP method -----------------------------");
if(fruits.Count > 0) // fruit.Count function return count of elements 
{

    Console.WriteLine("The last added elemet of Stack = "+fruits.Pop());
}
else
{
    Console.WriteLine("Fruits Stack is empty "); 
}
Console.WriteLine("------------------------ After Using POP method -----------------------------");
foreach (var item in fruits)
{
    Console.WriteLine(item+ " ");
}
// Peek- > Method -> also print last added element but do not remove it 
Console.WriteLine("------------------------ Using PEEK method -----------------------------");
if (fruits.Count > 0) // fruit.Count function return count of elements 
{

    Console.WriteLine("The last added elemet of Stack = " + fruits.Peek());
}
else
{
    Console.WriteLine("Fruits Stack is empty ");
}
Console.WriteLine("------------------------ After Using PEEK method -----------------------------");
foreach (var item in fruits)
{
    Console.WriteLine(item + " ");
}

// The Contains() method checks if the specified item is in a Stack collection. Returns true if present, false otherwise.
Console.WriteLine("------------------------ Using Contains method -----------------------------");
bool orange = fruits.Contains("Orange");
bool apple = fruits.Contains("Apple");
Console.WriteLine("------------------------ Our Stack -----------------------------");
foreach (var item in fruits)
{
    Console.WriteLine(item + " ");
}
if (apple)
{
    Console.WriteLine("We have Apple in our stack");
}
else
{
    Console.WriteLine("We do not have Apple element in our stack");
}
if (orange)
{
    Console.WriteLine("We have Orange in our stack");
}
else
{
    Console.WriteLine("We do not have Orange element in our stack");
}