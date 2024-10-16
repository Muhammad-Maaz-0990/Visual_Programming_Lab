using System;

namespace Lab4
{
    class Task
    {
        static void Main(string[] args)
        {

            // string vowels = "hello and welcome to this demo! ";

            response();
        }







       static void response()
        {
            int[] array = { 0, 0, 0, 0, 0 };
            

            for(int i=0;i<40;i++)
            {
                Console.Write("Enter Student " + (i+1) + " Response : ");
                int user_input = Convert.ToInt32(Console.ReadLine());
                user_input = check_input(user_input);
                array[user_input]++;
            }


            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Respone " + i+1 +" given by : " + array[i] + "  people");
            }
            
        }


        static int check_input(int value)
        {
            while(true)
            {
                if (value >= 1 && value <= 5)
                {
                    return value;
                }
                Console.WriteLine("Enter Correct Value [1-5] : ");
                value = Convert.ToInt32(Console.ReadLine());
            }
            
        }



        static string extract_vowels(string value)
        {
            string[] vowel_array = null;
            int start=0;
            

            for(int i=0;i<value.Length;i++)
            {
                if (value[i] ==" ")
                {
                    bool check =false;
                    string word = "";
                    for (int j=string;j<(i-1);j++)
                    {
                        word += value[j];
                        if (value[i] == 'A' || value[i] == 'a' || value[i] == 'E' || value[i] == 'e' || value[i] == 'I' || value[i] == 'i' || value[i] == 'O' || value[i] == 'o' || value[i] == 'U' || value[i] == 'u')
                        {
                            check = true;
                        }
                    }

                    if(check==true && (word.Length!=4 || word.Length!=5) )
                    {
                        check = false;
                    }

                    if(check==true)
                    {
                        vowel_array
                    }

                }
            }
        }
        



        static string Merged(string[] pass_array)
        {
            string value = "";
            foreach (string pass in pass_array)
            {
                value += pass;
            }
            return value;
        }


        static void PrintArray(int[,] pass_array)
        {
            Console.Write("2D Integer Array Values : { ");
            foreach (int i in pass_array)
            {
                Console.Write(i + " ");
            }
            Console.Write("}");
            Console.WriteLine();
        }
    }
};