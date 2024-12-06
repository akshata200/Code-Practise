// See https://aka.ms/new-console-template for more information
using Code_Practise;
using Code_Practise.Design_Patterns.Creational_Design_Patterns.Builder_Design_Pattern;
using Code_Practise.Design_Patterns.Creational_Design_Patterns.Factory_Method_Design_Pattern;
using Code_Practise.Design_Patterns.Creational_Design_Patterns.Prototype_Design_Pattern;
using Code_Practise.Design_Patterns.Creational_Design_Patterns.Singleton_Design_Pattern;
using Code_Practise.OOPS_Concept.Delegates_and_Anonymous_Functions;
using Code_Practise.OOPS_Concept.Inheritance_Logic;
using Code_Practise.OOPS_Concept.Method_Hiding;
using Code_Practise.OOPS_Concept.Misc;
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

/*
ChildClass1 cc1 = new ChildClass1();
//cc1.getClassDetails();
//cc1.getParentInterfaceDetails();
cc1.GetAbstractParentClassDetails();
*/

/*
ReverseString rsObj = new ReverseString("Akshata");
rsObj.ExecuteReverseString();
rsObj.ExecuteReverseStringUsingCharArray();
rsObj.ExecuteReverseStringUsingStringBuilder();
*/


/*
WordInSentence wsObj = new WordInSentence();
wsObj.ExecuteCheckWordInSentence();
*/

/*
CheckIfNumisPrime npObj = new CheckIfNumisPrime(); 
npObj.ExecuteCheckIfNumIsPrime();
*/

/*
EqualityOperatorAndEquals eqObj = new EqualityOperatorAndEquals();
eqObj.ExecuteEqualityOperatorAndEquals();
*/

/*
 * Method Hiding
Console.WriteLine("Child Reference Child Object");
Code_Practise.OOPS_Concept.Method_Hiding.ChildClass1 chObj = new Code_Practise.OOPS_Concept.Method_Hiding.ChildClass1();
chObj.Display();
chObj.Show();

Console.WriteLine("\n Parent Reference  Child Object");

// Parent class reference doesn't acknowledge the cheat overiding of non-abstract methods, 
//so it will execute the SHOW method from parent class only.
Code_Practise.OOPS_Concept.Method_Hiding.ParentClass1 pchObj = new Code_Practise.OOPS_Concept.Method_Hiding.ChildClass1();
pchObj.Display();
pchObj.Show();

*/

/*
 * Delegates are variable which holds reference or pointer to function
DelegatesExample delegateExample = new DelegatesExample();
delegateExample.ExecuteDelegatesExample();
*/

/*
LambdaExample lExObj = new LambdaExample();  
//lExObj.ExecuteLambdaExample();
lExObj.TryingActualLamdbaExamples();
*/


/*
LINQExample linqObj = new LINQExample();
linqObj.ExecuteLINQExample();
*/

Helper hObj = new Helper();
hObj.ExecuteHelper();




Console.ReadKey();