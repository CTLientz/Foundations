using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_structure_Lientz
    //I changed the namespace so it would be easier to identify in GigHub

{
    public struct pet
    //This says that the program that we're creating is public, and that it's a struct named pet
    {
        public string Name;
        //names one collum in the struct "name", and that it's in string format. 
        public string TypeOfPet;
        //names one collum in the struct " TypeOfPet", and that it's in string format.
    
    }
    class Program
    {
        static void Main()
        {
            var numberOfPets = 0;
            //var alows the complier to choice the most appropiate type of variable (integer, float, short, long, etc)
            var pets = new pet[10];  
            // This creates 10 lines of "pet"
            //the square brackets mean that it's an array with the number of rows available.

            while (true)
            //This is the beginging of the loop.
            {
                Console.WriteLine("A)dd D)elete L)ist pets.    ");
                //This writes "A)dd D)elete L)ist pets." to a fresh console
                var choice = Console.ReadLine();
                //this has the compiler pull the information and put it into a category called "choice"

            switch (choice) // Better than an if/then journey for simple instruction

                {
                    case "A": //This alows the user to key in A 
                    case "a":
                        {
                            Console.Write("Name:  ");
                            var name = Console.ReadLine();
                            //This asks the user to key in a name and pulls that text info "name"

                            Console.WriteLine("Type of pet:");
                            var typeOfPet = Console.ReadLine();
                            //This asks the user to key in a type of pet, and pulls that text into "typeOfPet"

                            // Always add the pet at the end of the array

                            pets[numberOfPets].Name = name; //Here I'm creating the collums in the struct
                            pets[numberOfPets].TypeOfPet = typeOfPet;//same.

                            numberOfPets++;
                                //This makes the next entry go into the next row
                                break;

                        }
                    case "D"://upper and lower case friendly
                    case "d":
                        {
                            if (numberOfPets==0) //if there are no entries  in the array, then the nubmer of pets is 0
                            {
                                Console.WriteLine("No Pets"); //writes to console
                                break;
                            }
                            for (var index=0; index<numberOfPets; index++) //starting at 0 (first line), stop at the end of the end of the array, tells to go up by 1 
                            {
                                Console.WriteLine("{0}. {1, -10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);
                                //Writes to console  -10 is a fixed for the minimum of 10 charactors.  That's kinda cool.
                                //index + 1 is so that humans can read it starting at 1 instead of 0.
                            }
                            Console.Write("Which Pet to remove (1-{0})", numberOfPets);

                            //This pulls up the list of up to 10 pets and writes to console.  Frankly, I contest that 10 pets is too many and that it should be ok to have more.


                            var petNumberToDelete = Console.ReadLine();// var so the compiler picks the varriable type 
                            var indexToDelete = int.Parse(petNumberToDelete);//takes the string and makes it an int

                            //squish the array from index to end

                            for(var index = indexToDelete -1; index < numberOfPets; index++) //where to start; where to end; how to progress
                                //take out the 1 becase now the computer needs to read it not the human
                            {
                                //just copy the pet from the next index to the current index 
                                pets[index] = pets[index + 1];
                                //moves up the list to create rrom at the bottom.
                            }
                            //we have one less pet  
                            numberOfPets--;

                            break;
                        }
                    case "L":
                    case "l":
                        {
                            if (numberOfPets == 0)
                            {
                                Console.WriteLine("No Pets");
                                break;

                            }
                            for (int index = 0; index < numberOfPets; index++) // the index is a varriable, lists start at 0, list ends at the last entry, progresses by 1
                            {
                                Console.WriteLine("{0}; {1, -10}; {2}", index+1, pets[index].Name, pets[index].TypeOfPet);
                            } //writes to console starting at 1., creates a minimum of 10 charactors for decent spacing for name,  then the type of pet 
                            break;
                        }
                        default: //if any character other than a/d/l is entered it vomits out this "you screwed up!" comment.
                            {
                            Console.WriteLine("Invalid Option [{0}].", choice);
                            break;
                            }
                }
            }
        }

    }
        }
    

