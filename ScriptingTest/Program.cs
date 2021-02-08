using System;
using ScriptingTest.Entities;
using System.Collections.Generic;

namespace ScriptingTest {
    class Program {
        static void Main(string[] args) {

            bool bigWhile = true;

            int[] fullInteiros = new int[50];
            int[] fullInside = new int[50];
            int[] fullOResults = new int[50];

            while (bigWhile) {

                int[] inteiros = new int[50];
                int[] inside = new int[50];
                int[] oResults = new int[20];

                string[] variables = new string[50];
                Dictionary<string, int> oneDic = new Dictionary<string, int>();                

                int forEachControl1 = 0;
                int forEachControl2 = 0;
                int forEachControl3 = 0;
                int forEachControl4 = 0;
                int forEachControl5 = 0;


                int controlInside = 0;
                int controlVariables = 0;
                int controlOResults = 0;
                int controlOutR = 0;
                int controlInteiros = 0;                

                bool isThereSpace = false; // doing nothing now

                int howManyPlus = 0;
                int[] isso = new int[20];

                string[] getK = new string[10]; // <<< HERE     || LIMITATION OF POSITIONS                

                bool flagOut = false;
                try {
                    Console.WriteLine("\n");
                    string[] clean1 = Console.ReadLine().Split(" ");

                    // FIRST FOREACH BELOW // FIRST FOREACH BELOW // FIRST FOREACH BELOW // FIRST FOREACH BELOW // FIRST FOREACH BELOW // FIRST FOREACH BELOW

                    foreach (string str in clean1) {
                        if (str.intTest()) {
                            inteiros[controlInteiros] = int.Parse(str);
                            controlInteiros++;
                        }
                        if (str == "int") {
                            if (clean1[forEachControl1 + 1].Length == 1) { // STR STRING SIZE
                                variables[controlVariables] = clean1[forEachControl1 + 1];
                                oneDic.Add(clean1[forEachControl1 + 1], int.Parse(clean1[forEachControl1 + 3]));
                                controlVariables++;
                            }
                            if (clean1[forEachControl1 + 2] == "=") { // This if doesn't do anything important
                                if (clean1[forEachControl1 + 3].intTest()) {
                                    inside[controlInside] = int.Parse(clean1[forEachControl1 + 3]);
                                    controlInside++;
                                }
                            }
                        }
                        forEachControl1++;
                    }

                    // SECOND FOREACH BELOW // SECOND FOREACH BELOW // SECOND FOREACH BELOW // SECOND FOREACH BELOW // SECOND FOREACH BELOW // SECOND FOREACH BELOW 

                    foreach (string str in clean1) { // IT IS NECESSARY TWO Foreachs INDEED!!!                        
                        if (str == ">>") {
                            forEachControl2 = clean1.Length;
                            for (int i = clean1.Length - 1; i >= 0; i--) {
                                if (clean1[i] == "+") {
                                    isso[howManyPlus] = howManyPlus + 1;
                                    clean1[i] = "abcdefgh" + isso[howManyPlus].ToString();
                                    getK[howManyPlus] = clean1[i];
                                    howManyPlus++;
                                }
                                forEachControl2--; // It will automaticllty count till 0
                            }
                        }
                    }

                    int dicSum = 0;
                    int eoq = 0;
                    foreach (int thatInt in isso) {
                        if (thatInt != 0) {
                            eoq++;
                        }
                    }

                    // THIRD FOREACH BELOW // THIRD FOREACH BELOW // THIRD FOREACH BELOW // THIRD FOREACH BELOW // THIRD FOREACH BELOW // THIRD FOREACH BELOW

                    forEachControl3 = 0;
                    foreach (string str in clean1) { // IT IS NECESSARY TWO Foreachs INDEED!!!                                                
                        if (str == "abcdefgh" + eoq && !(flagOut)) {

                            forEachControl4 = forEachControl3;
                            forEachControl5 = forEachControl3;

                            for (int i = forEachControl4; i < clean1.Length; i++) {
                                if (clean1[i] != "!") {
                                    foreach(string sobj in getK) {
                                        if(clean1[i] == sobj) {
                                            if (controlOResults == 0) {
                                                if (oneDic.ContainsKey(clean1[i - 1]) || oneDic.ContainsKey(clean1[i + 1])) {
                                                    if (oneDic.ContainsKey(clean1[i - 1])) {
                                                        dicSum += oneDic[clean1[i - 1]] + oneDic[clean1[i + 1]];
                                                        controlOResults++; // A FLAG
                                                    }
                                                    else {
                                                        dicSum += oneDic[clean1[i + 1]];
                                                        controlOResults++; // A FLAG
                                                    }
                                                }
                                            }
                                            else {
                                                if (oneDic.ContainsKey(clean1[i + 1])) {
                                                    dicSum += oneDic[clean1[i + 1]];
                                                }
                                            }
                                        }                                        
                                    }                                    
                                }
                                else {
                                    isThereSpace = true;
                                    controlOResults = 0; // reseting                                           
                                    oResults[controlOutR] = dicSum;
                                    controlOutR++; // <<< nothing important
                                    dicSum = 0;
                                }
                                forEachControl4++;
                                forEachControl5 += 2;
                            }                                                        
                            eoq--;
                            flagOut = true;
                        }                        
                        forEachControl3++; // SHOULD MATCH WITH str
                        isThereSpace = false;
                    }

                    // END OF LAST FOREACH // END OF LAST FOREACH // END OF LAST FOREACH // END OF LAST FOREACH // END OF LAST FOREACH // END OF LAST FOREACH

                    Console.Write("\nAll integer numbers inside the user imput: ");              // <<< NOT BEING USED RIGHT NOW
                    foreach (int intObj in inteiros) {
                        if (intObj != 0)
                            Console.Write(intObj + " ");
                    }
                    Console.WriteLine("\n");


                    // SEPARATION // SEPARATION // SEPARATION // SEPARATION // SEPARATION // SEPARATION // SEPARATION // SEPARATION // SEPARATION

                    Console.Write("All numbers storage in some variable: ");
                    foreach (int obj in inside) {
                        if (obj != 0) {
                            Console.Write(obj + " ");
                        }
                    }

                    Console.WriteLine("\n");
                    int ioR = 1;
                    foreach (int obj in oResults) {
                        if (obj != 0) {
                            Console.WriteLine($"operation({ioR}) result: " + obj);
                            ioR++;
                        }
                    }

                    fullInteiros = inteiros;
                    fullInside = inside;
                    fullOResults = oResults;
                }
                catch (Exception e) {
                    Console.WriteLine("\n" + e);
                }
            }
            // END OF BigWhile
        }
    }
}
