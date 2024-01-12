Console.WriteLine("Class Example!");

Person pe1=new Person();
pe1.Fname="Teppo";
pe1.Lname="Testi";
pe1.Age=36;
Console.WriteLine("etunimi = "+pe1.Fname);
pe1.PersonInfo();

Person pe2=new Person("Aino","Joki",37);
pe2.PersonInfo();

Person pe3=new Person();
Console.WriteLine("Anna etunimi");
pe3.Fname=Console.ReadLine();
Console.WriteLine("Anna sukunimi");
pe3.Lname=Console.ReadLine();
Console.WriteLine("Anna ikä");
pe1.Age=int.Parse(Console.ReadLine());

pe3.PersonInfo();
