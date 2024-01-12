class Person{
    public string Fname{get; set;}
    public string Lname{get; set;}
    public int Age{get; set;}
    public void PersonInfo(){
        Console.WriteLine("*************************");
        Console.WriteLine("Nimeni on "+Fname+" "+Lname);
        Console.WriteLine("olen "+Age+" vuotias");
        Console.WriteLine("*************************");
    }
    //luodaan muodostin eli konstruktori
    //jolla voidaan asettaa data oliota luotaessa
    //konstruktorilla on aina sama nimi kuin luokalla
    public Person(string fn, string ln, int a){
        Fname=fn;
        Lname=ln;
        Age=a;
    }
    //jotta olion voi luoda myös ilman dataa
    //luodaan lisäksi tyhjä konstruktori
    public Person(){}
}