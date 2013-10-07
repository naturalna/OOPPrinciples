//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals.
//All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, 
//name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound. Create arrays of different
//kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class AnimalsEntryPoint
{
    static void Main()
    {
        //creating array with cats
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("Cat");
        Cat cat1 = new Cat("catOne", 13, 'f');
        Cat cat2 = new Cat("Tom", 22, 'm');
        Cat cat3 = new Cat("CatThree", 1, 'm');
        Cat[] arrCat = new Cat[3];
        arrCat[0] = cat1;
        arrCat[1] = cat2;
        arrCat[2] = cat3;
        //avarage age for 3 cats
        double result = Animal.AvarageAge(arrCat);
        Console.WriteLine(result);
        //creating array with dogs
        Console.WriteLine("----------------------------------------------------------");
        Console.WriteLine("Dogs");
        Dog dog1 = new Dog("dogOne", 13, 'f');
        Dog dog2 = new Dog("dogTom", 9, 'm');
        Dog dog3 = new Dog("Dog3", 1, 'm');
        Dog[] arrDog = new Dog[3];
        arrDog[0] = dog1;
        arrDog[1] = dog2;
        arrDog[2] = dog3;
        //avarage age for 3 cats
        double result2 = Animal.AvarageAge(arrDog);
        Console.WriteLine(result2);
        //creat frogs
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("Frog");
        Frog frog1 = new Frog("frogOne", 1, 'f');
        Frog frog2 = new Frog("frogTom", 22, 'm');
        Frog frog3 = new Frog("frog3", 1, 'm');
        Frog[] arrFrog = new Frog[3];
        arrFrog[0] = frog1;
        arrFrog[1] = frog2;
        arrFrog[2] = frog3;
        //avarage age for 3 cats
        double result3 = Animal.AvarageAge(arrDog);
        Console.WriteLine(result3);
        //creat kitten
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("Kitten");
        Kitten kitten1 = new Kitten("frogOne", 13);
        Kitten kitten2 = new Kitten("frogTom", 22);
        Kitten kitten3 = new Kitten("frog3", 19);
        Kitten[] arrKitten =new  Kitten[3];
        arrKitten[0] = kitten1;
        arrKitten[1] = kitten2;
        arrKitten[2] = kitten3;
        //avarage age for 3 cats
        double result4 = Animal.AvarageAge(arrDog);
        Console.WriteLine(result4);
        //creat tomcat
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("Tomcat");
        Tomcat tomcat1 = new Tomcat("frogOne", 13);
        Tomcat tomcat2 = new Tomcat("frogTom", 2);
        Tomcat tomcat3 = new Tomcat("frog3", 1);
        Tomcat[] arrTomcat = new Tomcat[3];
        arrTomcat[0] = tomcat1;
        arrTomcat[1] = tomcat2;
        arrTomcat[2] = tomcat3;
        //avarage age for 3 cats
        double result5 = Animal.AvarageAge(arrDog);
        Console.WriteLine(result5);
        //sounds
        tomcat1.Say("mqu mqu");
    }
}

