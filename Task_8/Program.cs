Console.Write("N=");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
Console.Write(" Ответ :");
while(count <= N){
if (count%2==0)
{
   Console.Write(count);
   Console.Write(",");
}

count++;
}