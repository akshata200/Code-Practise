// See https://aka.ms/new-console-template for more information
using Code_Practise;
using Code_Practise.Design_Patterns.Creational_Design_Patterns.Builder_Design_Pattern;
using Code_Practise.Design_Patterns.Creational_Design_Patterns.Factory_Method_Design_Pattern;
using Code_Practise.Design_Patterns.Creational_Design_Patterns.Prototype_Design_Pattern;
using Code_Practise.Design_Patterns.Creational_Design_Patterns.Singleton_Design_Pattern;
using Code_Practise.OOPS_Concept.Inheritance_Logic;
using Code_Practise.Simple_Code;

Console.WriteLine("Hello, World!");

/*
 * *** Swap Numbers
SwapNumbers swapObj = new SwapNumbers(2,10);
swapObj.SwapUsingTemp();
swapObj.SwapWithoutTemp();
*/

/*
 * *** Check if word/string is Palindrome
Palindrome palindromeObj = new Palindrome("Madam");
palindromeObj.CheckWordPalindrome();
*/

/*
 * *** Builder Design Pattern
BuilderUserClient clientObj = new BuilderUserClient();
clientObj.ExecuteUserBuilderDesignPattern();
*/

/*
 * *** Prototype Design Pattern
PrototypeClient prototypeClientObj = new PrototypeClient();
prototypeClientObj.ExecutePrototypeDesignPattern();
*/


/*
 * *** Singleton Design Pattern
SingletonClient singletonClientObj = new SingletonClient();
singletonClientObj.ExecuteSingletonDesignPattern();
*/

/*
FactoryClientCode factoryClientCode = new FactoryClientCode();
factoryClientCode.ExecuteFactoryDesignPattern();
*/

/*
 * Seperate numbers and characters from a string (word)
SeperateCharAndNum sepObj = new SeperateCharAndNum();
sepObj.PrintStrings();
*/

/*
SecondHighestNum shnObj = new SecondHighestNum();
shnObj.SecondHighestNumberinList();
shnObj.SecondHighestNuminArray();
*/

ChildClass1 cc1 = new ChildClass1();
//cc1.getClassDetails();
//cc1.getParentInterfaceDetails();
cc1.GetAbstractParentClassDetails();


Console.ReadKey();