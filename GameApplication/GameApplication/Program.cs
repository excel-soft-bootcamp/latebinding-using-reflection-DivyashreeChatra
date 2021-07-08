using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApplication
{  
        public enum Options
        {
            BASIC = 1, INTERMEDIATE, ADVANCED
        }
        class Program
        {
            static void Main(string[] args)
            {
            string choice = string.Empty;

            do
            {
                Console.WriteLine("Word Guess Game");
                ConsoleInputReader inputReader = new ConsoleInputReader();
                Options _choice = inputReader.InputReader();
                switch (_choice)
                {
                        case Options.BASIC:
                        Console.WriteLine("Basic Level");

                        System.Reflection.Assembly basicLevelLib =
                        System.Reflection.Assembly.LoadFile(@"C:\Users\divyashree.chatra\source\repos\GameApplication\GameApplication\bin\Debug\BasicLevelLib.dll");

                        System.Type basicLevelTypeClassRef = basicLevelLib.GetType("BasicLevelLib.BasicLevelType");
                        if (basicLevelTypeClassRef != null)
                        {
                            if (basicLevelTypeClassRef.IsClass)
                            {

                                Object objRef = System.Activator.CreateInstance(basicLevelTypeClassRef);

                                System.Reflection.MethodInfo _methodRef = basicLevelTypeClassRef.GetMethod("Play");
                                if (!_methodRef.IsStatic)
                                {

                                    object result = _methodRef.Invoke(objRef, new object[] { });
                                    Console.WriteLine(result.ToString());
                                }

                            }
                        }
                        break;
                        case Options.INTERMEDIATE:
                        Console.WriteLine("Intermediate Level");

                        System.Reflection.Assembly intermediateLevelLib =
                        System.Reflection.Assembly.LoadFile(@"C:\Users\divyashree.chatra\source\repos\GameApplication\GameApplication\bin\Debug\IntermediateLevelLib.dll");

                        System.Type intermediateTypeClassRef = intermediateLevelLib.GetType("IntermediateLevelLib.IntermediateLevelType");
                        if (intermediateTypeClassRef != null)
                        {
                            if (intermediateTypeClassRef.IsClass)
                            {

                                Object objRef = System.Activator.CreateInstance(intermediateTypeClassRef);
                                System.Reflection.MethodInfo _methodRef = intermediateTypeClassRef.GetMethod("Start");
                                if (!_methodRef.IsStatic)
                                {
                                    object result = _methodRef.Invoke(objRef, new object[] { "Divya" });
                                    Console.WriteLine(result.ToString());
                                }
                            }
                        }
                        break;
                    case Options.ADVANCED:
                        Console.WriteLine("Advanced Level");

                        System.Reflection.Assembly advancedLevelLib =
                        System.Reflection.Assembly.LoadFile(@"C:\Users\divyashree.chatra\source\repos\GameApplication\GameApplication\bin\Debug\AdvancedLevelLib.dll");

                        System.Type advancedTypeClassRef = advancedLevelLib.GetType("AdvancedLevelLib.AdvancedLevelType");
                        if (advancedTypeClassRef != null)
                        {
                            if (advancedTypeClassRef.IsClass)
                            {

                                Object objRef = System.Activator.CreateInstance(advancedTypeClassRef);
                                System.Reflection.MethodInfo _methodRef = advancedTypeClassRef.GetMethod("Begin");
                                if (!_methodRef.IsStatic)
                                {
                                    object result = _methodRef.Invoke(objRef, new object[] { "Lucas", 100 });
                                    Console.WriteLine(result.ToString());
                                }
                            }
                        }
                        break;
                   
                         default:
                        {
                            Console.WriteLine("Invalid Choice .Please try again",_choice);
                            break;
                        }
                }

                        do
                        { 
                            Console.WriteLine("Do you want to continue - Yes or No");
                            choice = Console.ReadLine().ToUpper();
                            if (choice != "YES" && choice != "NO")
                            {
                                Console.WriteLine("Invalid choice.Please say Yes or No");
                            }
                        } while (choice != "YES" && choice != "NO");
                } while (choice == "YES") ;
            
            }
       }
}
