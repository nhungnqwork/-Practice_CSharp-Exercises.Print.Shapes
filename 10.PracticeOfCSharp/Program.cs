#region Exercise 01
/*9.Write a program in C# Sharp to display a right angle triangle with an asterisk.
The pattern like :

*
**
***
*****/
Console.WriteLine("--------------EXERCISE 01--------------");
Console.Write("Enter the line number of the Triangle: ");
int temp1 = int.Parse(Console.ReadLine());
for (int i = 0; i<=temp1; i++)
{
    for (int j = 0;j<i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine("");
}
#endregion

#region Exercise 02
/*10.Write a program in C# Sharp to display a pattern like a right angle triangle with a number.
The pattern like :

1
12
123
1234*/
Console.WriteLine("\n--------------EXERCISE 02--------------");
Console.Write("Enter the line number of the Triangle: ");
int temp2 = int.Parse(Console.ReadLine());
for (int i = 0; i <= temp2; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write($"{j}");
    }
    Console.WriteLine("");
}
#endregion

#region Exercise 03
/*11.Write a program in C# Sharp to make such a pattern like a right angle triangle with a number which repeats a number in a row.
The pattern like :

1
22
333
4444*/
Console.WriteLine("\n--------------EXERCISE 03--------------");
Console.Write("Enter the line number of the Triangle: ");
int temp3 = int.Parse(Console.ReadLine());
for (int i = 0; i <= temp3; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write($"{i}");
    }
    Console.WriteLine("");
}
#endregion

#region Exercise 04
/*12.Write a C# Sharp program to make such a pattern like a right angle triangle with the number increased by 1.
The pattern like :

1
2 3
4 5 6
7 8 9 10*/
Console.WriteLine("\n--------------EXERCISE 04--------------");
Console.Write("Enter the line number of the Triangle: ");
int temp4 = int.Parse(Console.ReadLine());
int k = 1;
for (int i = 0; i <= temp4; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(k++ + " ");
    }
    Console.WriteLine("");
}
#endregion

#region Exercise 05
/*13.Write a program in C# Sharp to make such a pattern like a pyramid with numbers increasing by 1.

   1 
  2 3 
 4 5 6 
7 8 9 10*/
Console.WriteLine("\n--------------EXERCISE 05--------------");
Console.Write("Enter the number of lines of the isosceles Triangle: ");
int temp5 = int.Parse(Console.ReadLine());
int spc = temp5 + 3 - 1;
int k5 = 1;
for (int i = 0; i <= temp5; i++)
{
    for (int z = spc; z >= 1; z--)
    {
        Console.Write(" ");
    }
    for (int j = 1; j <= i; j++)
    {
        Console.Write(k5++ + " ");
    }
    Console.WriteLine();
    spc--;
}
#endregion

#region Exercise 06
/*14.Write a program in C# Sharp to make such a pattern like a pyramid with an asterisk.

   *
  * * 
 * * *
* * * **/
Console.WriteLine("\n--------------EXERCISE 06--------------");
Console.Write("Enter the number of lines of the isosceles Triangle: ");
int temp6 = int.Parse(Console.ReadLine());
spc = temp6 + 4 - 1;
for (int i = 0; i <= temp6; i++)
{
    for (int z = spc; z >= 1; z--)
    {
        Console.Write(" ");
    }

    for (int j = 1; j <= i; j++)
        Console.Write("* ");
    Console.Write("\n");
    spc--;
}
#endregion

#region Exercise 07
/*17.Write a program in C# Sharp to make such a pattern like a pyramid with a number which will repeat the number in the same row.

   1
  2 2
 3 3 3
4 4 4 4*/
Console.WriteLine("\n--------------EXERCISE 07--------------");
Console.Write("Enter the number of lines of the isosceles Triangle: ");
int temp7 = int.Parse(Console.ReadLine());
spc = temp7 + 4 - 1;
for (int i = 0; i <= temp7; i++)
{
    for (int z = spc; z >= 1; z--)
    {
        Console.Write(" ");
    }

    for (int j = 1; j <= i; j++)
        Console.Write(i + " ");
    Console.Write("\n");
    spc--;
}
#endregion

#region Exercise 08
/*20.Write a program in C# Sharp to display the pattern like pyramid using an asterisk and each row contain an odd number of an asterisks.

  *
 ***
******/
Console.WriteLine("\n--------------EXERCISE 07--------------");
Console.Write("Enter the number of lines of the isosceles Triangle: ");
int temp8 = int.Parse(Console.ReadLine());
for (int i = 0; i <= temp8; i++)
{
    for (int j = i; j <= temp8; j++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < (2*i)-1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
#endregion

#region Exercise 09
/*22. Write a program in C# Sharp to print Floyd's Triangle.

1
01
101
0101
10101*/
Console.WriteLine("\n--------------EXERCISE 09--------------");
Console.Write("Enter the line number of the Triangle: ");
int temp9 = int.Parse(Console.ReadLine());
int q, p;
for (int i = 0; i <= temp9; i++)
{
    if (i%2==0)
    {
        p = 1;q = 0;
    }
    else
    {
        p = 0;q = 1;
    }
    for (int j = 1; j <= i; j++)
    {
        if (j % 2 ==0)
        {
            Console.Write(p);
        }
        else
        {
            Console.Write(q);
        }
    }
    Console.WriteLine("");
}
#endregion

#region Exercise 10
/*31.Write a program in C# Sharp to display the pattern like a diamond.

    * 
   *** 
  *****
 *******
*********
 *******
  *****
   ***
    * */
Console.WriteLine("\n--------------EXERCISE 10--------------");
Console.Write("Enter the line number of the Diamond: ");
int temp10 = int.Parse(Console.ReadLine());
for (int i = 0; i <= temp10; i++)
{
    for (int j = i; j <= temp10; j++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < 2*i-1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine("");
}
for (int i = temp10 - 1; i >= 0; i--)
{
    for (int j = i; j <= temp10; j++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < 2 * i - 1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine("");
}
Console.WriteLine("");
#endregion

#region Exercise 11
/*36.Write a program in C# Sharp to display such a pattern for n number of rows using a number starting with the number 1. The first and last number of each row will be 1.

  1
 121
12321*/
Console.WriteLine("\n--------------EXERCISE 11--------------");
Console.Write("Enter the line number of the Isosceles Triangle: ");
int temp11 = int.Parse(Console.ReadLine());
for (int i = 0; i <= temp11; i++)
{
    for (int j = 1; j <= temp11 - i; j++)
        Console.Write(" ");
    /* Display number in ascending order upto middle*/
    for (int j = 1; j <= i; j++)
        Console.Write(j);

    /* Display  number in reverse order after middle */
    for (int j = i - 1; j >= 1; j--)
        Console.Write(j);

    Console.Write("\n");
}
#endregion

#region Exercise 12
/*40.Write a C# Sharp Program to display the following pattern using the alphabet.

A
A B A 
A B C B A
A B C D C B A */
Console.WriteLine("\n--------------EXERCISE 12--------------");
Console.Write("Enter the line number of the Isosceles Triangle: ");
int temp12 = int.Parse(Console.ReadLine());
char alpha = 'A';
int ctr = 1;
for (int i = 1;i <= temp12; i++)
{
    for (int j = 0; j <= (ctr/2); j++)
    {
        Console.Write(alpha++);
    }
    alpha--;
    alpha--;
    for (int j = 0; j < (ctr / 2); j++)
    {
        Console.Write(alpha--);
    }
    ctr = ctr + 2;
    alpha = 'A';
    Console.Write("\n");
}

#endregion