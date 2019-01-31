using System;
using System.Collections.Generic;
using System.Linq;
using SaltusTechAssignment.Models;
namespace SaltusTechAssignment
{
    class Program
    {

        static void Main(string[] args)
        {
            List<numberColor> colornumberlist = new List<numberColor>(); //CREATE LIST OF OBJECTS
            int colorcount = 1;
            for (var i = 0; i < 100; i++)
            {
                numberColor NewItem = new numberColor();
                if (colorcount == 4)//RESET COLOR GENERATOR
                {
                    colorcount = 1;
                }
                if (colorcount == 1)//set colors
                {
                    NewItem.color = "red";
                }
                if (colorcount == 2)//set colors
                {
                    NewItem.color = "yellow";
                }
                if (colorcount == 3)//set colors
                {
                    NewItem.color = "white";
                }
                colorcount++; //increment Color
                colornumberlist.Add(NewItem); //PUSH ITEM TO LIST
            }
            for(var idx = 0; idx < colornumberlist.Count;idx++)//REMOVE ITEMS
            {
                if(colornumberlist[idx].number%2==0 && colornumberlist[idx].color=="red")//remove even numbers that are red
                {
                    colornumberlist.RemoveAt(idx);
                    // idx--;
                }
                else if(colornumberlist[idx].number%2!=0 && colornumberlist[idx].color=="yellow")//remove odd numbers that are yellow
                {
                    colornumberlist.RemoveAt(idx);
                    // idx--;

                }
                else if(colornumberlist[idx].number%3==0 && colornumberlist[idx].color=="white")//remove numbers divisible by 3 that are white
                {
                    colornumberlist.RemoveAt(idx);
                    // idx--;

                }
            }
            colornumberlist = colornumberlist.OrderBy(x=>x.number).ToList();//SORT LOW TO HIGH
            List<numberColor> ColorSort = new List<numberColor>();//CREATE NEW LIST TO SORT BY COLOR
            ColorSort = colornumberlist.OrderBy(x=>x.color == "white").ThenBy(y=>y.color=="yellow").ThenBy(y=>y.color=="red").ToList();//SORT BY COLOR
            Console.WriteLine("=============BELOW ARE SORTED BY NUMBER=================");

            for(var idx = 0; idx < colornumberlist.Count;idx++)//CONSOLE LOG EACH ITEM IN SORTED NUMBER LIST
            { 
                Console.WriteLine(colornumberlist[idx].number + " " + colornumberlist[idx].color);
            }

            Console.WriteLine("=============BELOW ARE SORTED BY COLOR=================");
            for(var idx = 0; idx < colornumberlist.Count;idx++)//CONSOLE LOG EACH ITEM IN SORTED COLOR LIST
            { 
                Console.WriteLine(ColorSort[idx].number + " " + ColorSort[idx].color);
            }

        }
    }
}