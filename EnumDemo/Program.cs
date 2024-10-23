#region Code to hide
//// See https://aka.ms/new-console-template for more information


//using EnumDemo;

//var statuLivree = StatutLivraison.Livree;


//var marchndise = new Marchandise
//{
//    Id = 1,
//    CustomerName = "Alex",
//    StatutLivraison = StatutLivraison.EnCoursDePreparation
//};

//var point = new Point { X = 0, Y = 0 };



//var nieze = new Humain(age: 20,name: "Nieze");
//var alex = new Humain(age: 15, name: "Alex");
//var kris = new Humain(age: 15, name: "Kris");

//var stringMarche = nieze.Marcher();

//nieze.Energie = 100;
//nieze.IsEnergieUtiliser();

//var slogan = Humain.Slogan;

//Humain.DireSlogan();

//var humainList  = new List<Humain>();



//humainList.Add(nieze);
//humainList.Add(alex);
//humainList.Add(kris);


//foreach (var humain in humainList)
//{
//    Console.WriteLine(humain.Name);
//}


//Dictionary<string,string> dic = new Dictionary<string, string>();

//dic.Add("0", "Nieze");
//dic.Add("1", "Alex");


//foreach (var item in dic)
//{
//    Console.WriteLine($"le cle est : {item.Key} et le valeur est : {item.Value}");
//    Console.WriteLine(dic["0"]);
//}

//var humainListWithAge15 = humainList.Where(h => h.Age == 15).ToList();
//;

#endregion

using EnumDemo;
using EnumDemo.NonVivant;

var family = new Family<Humain>();

family.Name = "Johnson";

family.Members = new List<Humain>
{
    new Humain(name: "Alex", age:15),
    new Humain(name: "David", age:15),
    new Humain(name: "Nieze", age:15),
};

var familyAnimal = new Family<Animal>();

familyAnimal.Name = "Lions d'Afrique";

familyAnimal.Members = new List<Animal>
{
    new Animal{Name= "Lion1", Age=15},
    new Animal{ Name= "Lion2", Age=15 },
    new Animal{Name= "Lion3", Age=15},
};

var activeAnimals = familyAnimal.GetActiveMembers().ToList();


Family<Machine> familyMachine = new Family<Machine>();

familyMachine.Name = "machine";

familyMachine.Members = new List<Machine>
{
    new Machine{Name= "Lion1", Id=15},
    new Machine{ Name= "Lion2", Id=15 },
    new Machine{Name= "Lion3", Id=15},
};

var alex = new Humain(age: 15, name: "Alex");

var machine = new Machine
{
    Id = 555,
    Name = "Machie cafe",
    Agent = alex
};


