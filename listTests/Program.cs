using System;
using System.Collections;
using System.Collections.Generic;

namespace Lists{

    class Program{

        // This program demonstrates how to use arraylists and different methods with them
        public static void Main(string[] args){

            // Testing how to create a list and add to it
            List<string> Names = new List<string>();
            Names.Add("Mr T");
            Names.Add("Bambi");
            Names.Add("Timothy");
            Console.WriteLine("The number of names are: " + Names.Count);
            Console.WriteLine("The names are: ");
            for(int i = 0; i < Names.Count; i++){
                Console.WriteLine(Names[i]);
            }

            // Insert name method
            Names.Insert(1, "New name Jim");
            foreach (var val in Names){
                Console.WriteLine(val);
            }

            // Testing an Insert Range method
            ArrayList list1 = new ArrayList(){
                100, 200, 600
            };
            ArrayList list2 = new ArrayList(){
                300, 400, 500
            };
            list1.InsertRange(2, list2);
            foreach(var item in list1){
                Console.Write(item + ", ");  
            }

            // Testing how to remove things
            ArrayList removeListTest = new ArrayList(){
                1,
                null,
                "Bill",
                300,
                " ",
                4.5f,
                300,
            };
            removeListTest.Remove(null); //Removes first occurance of null
            removeListTest.RemoveAt(4); //Removes element at index 4
            removeListTest.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)
        
            // Testing how to check if something exists in array
            ArrayList arList = new ArrayList(){
                1,
                "Bill",
                300,
                4.5f,
                300
            };
            Console.WriteLine(arList.Contains(300)); // true


        }
    }
}