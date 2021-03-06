using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    public enum Options
    {
        BASIC=1,INTERMEDIATE,ADVANCED
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Word Guess Game");
            
           
            string displayMessage = $"Enter Your Choice {(int)Options.BASIC}->Basic,{(int)Options.INTERMEDIATE}->Intermediate,{(int)Options.ADVANCED}->Advanced";
            Console.WriteLine(displayMessage);
            do
            {
                try
                {
                    Options _choice = (Options)Int32.Parse(Console.ReadLine());
                    if (_choice == Options.BASIC || _choice == Options.INTERMEDIATE || _choice == Options.ADVANCED)
                    {
                        switch (_choice)
                        {
                            case Options.BASIC:
                                Console.WriteLine("Basic Level");
                                System.Reflection.Assembly basicLevelLib =
                                System.Reflection.Assembly.LoadFile(@"C:\Users\divyashree.chatra\Documents\GitHub\latebinding-using-reflection-DivyashreeChatra\GameApp\bin\Debug\LevelLibs\BasicLevelLib.dll");

                                System.Type basicLevelTypeClassRef = basicLevelLib.GetType("BasicLevelLib.BasicLevelType");
                                CheckConditionLib.CheckConditionType.CheckForNullIsClassIsStatic(basicLevelTypeClassRef, "Play", new object[] { });

                                break;

                            case Options.INTERMEDIATE:
                                Console.WriteLine("Intermediate Level");

                                System.Reflection.Assembly intermediateLevelLib =
                                System.Reflection.Assembly.LoadFile(@"C:\Users\divyashree.chatra\Documents\GitHub\latebinding-using-reflection-DivyashreeChatra\GameApp\bin\Debug\LevelLibs\IntermediateLevelLib.dll");

                                System.Type intermediateLevelTypeClassRef = intermediateLevelLib.GetType("IntermediateLevelLib.IntermediateLevelType");
                                CheckConditionLib.CheckConditionType.CheckForNullIsClassIsStatic(intermediateLevelTypeClassRef,"Start", new object[] { "Divyashree" });

                                break;

                            case Options.ADVANCED:
                                Console.WriteLine("Advanced Level");

                                System.Reflection.Assembly advancedLevelLib =
                                System.Reflection.Assembly.LoadFile(@"C:\Users\divyashree.chatra\Documents\GitHub\latebinding-using-reflection-DivyashreeChatra\GameApp\bin\Debug\LevelLibs\AdvancedLevelLib.dll");

                                System.Type advancedLevelTypeClassRef = advancedLevelLib.GetType("AdvancedLevelLib.AdvancedLevelType");
                                CheckConditionLib.CheckConditionType.CheckForNullIsClassIsStatic(advancedLevelTypeClassRef, "Begin", new object[] { "Divyashree", 100 }); 
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                }
                catch (SystemException)
                {
                    Console.WriteLine("Choice should be number");
                }
            } while (true);

               
        }
    }
}
