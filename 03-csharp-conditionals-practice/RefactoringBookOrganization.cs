/*Refactoring Book Organization

You are responsible for the cataloging system of a university library. Currently, books are classified into categories based on their numeric codes, but the code is long and difficult to maintain due to the excessive use of if/else conditionals.

Books are organized into three-digit codes and cataloged according to the initial number of their code, following the table below:
1: Science Fiction
2: Classic Literature
3: Fantasy
4: Romance
5: Thriller/Mystery
6: Non-fiction
7: Biographies/Memoirs
8: Dystopia
9: Young Adult (YA)

Therefore, a book with code 451 would be cataloged as "Romance", while a book with code 762 would be "Biographies/Memoirs". Your task is to refactor the current code to use switch/case.

Console.WriteLine("Digite o código do livro: ");
int codigo = int.Parse(Console.ReadLine());
 
if (codigo >= 100 && codigo <= 199)
{
    Console.WriteLine("Ficção Científica");
}
else if (codigo >= 200 && codigo <= 299)
{
    Console.WriteLine("Literatura Clássica");
}
else if (codigo >= 300 && codigo <= 399)
{
    Console.WriteLine("Fantasia");
}
else if (codigo >= 400 && codigo <= 499)
{
    Console.WriteLine("Romance");
}
else if (codigo >= 500 && codigo <= 599)
{
    Console.WriteLine("Suspense/Mistério");
}
else if (codigo >= 600 && codigo <= 699)
{
    Console.WriteLine("Não Ficção");
}
else if (codigo >= 700 && codigo <= 799)
{
    Console.WriteLine("Biografias/Memórias");
}
else if (codigo >= 800 && codigo <= 899)
{
    Console.WriteLine("Distopia");
}
else if (codigo >= 900 && codigo <= 999)
{
    Console.WriteLine("Infantojuvenil");
}
else
{
    Console.WriteLine("Código inexistente");
}

Example Input:
Enter the book code: 142

Expected Output:
Science Fiction
*/

Console.Write("Enter the book code: ");
int bookCode = int.Parse(Console.ReadLine()!);

switch (bookCode / 100)
{
    case 1:
        Console.WriteLine("Science Fiction");
        break;
    case 2:
        Console.WriteLine("Classic Literature");
        break;
    case 3:
        Console.WriteLine("Fantasy");
        break;
    case 4:
        Console.WriteLine("Romance");
        break;
    case 5:
        Console.WriteLine("Thriller/Mystery");
        break;
    case 6:
        Console.WriteLine("Non-fiction");
        break;
    case 7:
        Console.WriteLine("Biographies/Memoirs");
        break;
    case 8:
        Console.WriteLine("Dystopia");
        break;
    case 9:
        Console.WriteLine("Young Adult (YA)");
        break;
    default:
        Console.WriteLine("Nonexistent code");
        break;
}