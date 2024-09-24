Console.OutputEncoding = System.Text.Encoding.UTF8;
string fullname = "Misha Shapka";
string[] fullnamearrage = fullname.Split(' ');
string name1 = String.Empty;
string name2 = String.Empty;
for (int i = 0; i < fullnamearrage.Length-1; i++)
{
    name1 = fullnamearrage[i];
    name2 = fullnamearrage[i + 1];
}
if(name1.Substring(0, 1) == name2.Substring(0, 1))
{
    Console.WriteLine("Прізвище починається на ту ж літеру, що і ім’я");
}
else
{
    Console.WriteLine("Прізвище не починається на ту ж літеру, що і ім’я");
}
    