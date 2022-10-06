// Top:
// Console.Write("Gunu daxil edin: ");
// int day = Convert.ToInt32(Console.ReadLine());



// switch (day)
// {
//     case 1:
//         Console.WriteLine("Bazar ertesi");
//         break;
//     case 2:
//         Console.WriteLine("Cersenbe axsami");
//         break;
//     case 3:
//         Console.WriteLine("Cersenbe");
//         break;
//     case 4:
//         Console.WriteLine("Cume axsami");
//         break;
//     case 5:
//         Console.WriteLine("Cume");
//         break;
//     case 6:
//         Console.WriteLine("Senbe");
//         break;
//     case 7:
//         Console.WriteLine("Bazar");
//         break;
//     default:
//         Console.WriteLine("1-7 arasi reqem secin");
//         goto Top;
// }

// var dateDay = DateTime.Now;
// Console.WriteLine(dateDay);
// Console.WriteLine(dateDay.Day);
// Console.WriteLine(dateDay.DayOfWeek);
// Console.WriteLine(dateDay.TimeOfDay);
// Console.WriteLine(dateDay.Date);
// Console.WriteLine(dateDay.Year);
// Console.WriteLine(dateDay.DayOfYear);
// Console.WriteLine(dateDay.Month);


// Evvele:
// Console.WriteLine("Enter your age:");
// int age = Convert.ToInt32(Console.ReadLine());
// int year = DateTime.Now.Year - age;
// if(age < 0){
//     goto Evvele;
// }
// Console.WriteLine(year);


// Evvele:
// Console.Write("Enter your date of birthday:");
// int personYear = Convert.ToInt32(Console.ReadLine());
// int personAge = DateTime.Now.Year - personYear;
// if(personYear > DateTime.Now.Year)
//     goto Evvele;
// Console.WriteLine(personAge);

// string text = "Lorem Ipsum.";


// Console.WriteLine(text);
// Console.WriteLine(text.ToLower());
// Console.WriteLine(text.ToUpper());
// Console.WriteLine(text.Substring(0,5));
// Console.WriteLine(text.Substring(3,5));
// Console.WriteLine(text.Substring(3));
// Console.WriteLine(text.Length);


// string[] students = {"Nihad","Murad","Yusif","Hesen","Arzu", "Ehmed"};

// Console.WriteLine(students[0]);
// Console.WriteLine(students[1]);
// Console.WriteLine(students[2]);
// Console.WriteLine(students[3]);
// Console.WriteLine(students[4]);
// Console.WriteLine(students[5]);

// for(int i = 0; i < students.Length; i++)
// {
//     Console.WriteLine(students[i]);
// }

// int[] numbers = {1,2,3,4,5,6,7,8,9,10};

// for (int num = 0; num < numbers.Length; num++)
// { 
//     if (numbers[num] % 2 != 0)
//     {
//         Console.WriteLine(numbers[num]);
//     }
// }

// string[] students = {"Nihad","Murad","Yusif","Hesen","Arzu", "Ehmed","Tofiq"};


// for (int s = 0; s < students.Length; s++)
// {
//     if (students[s].Length %2 != 0)
//     {
//         Console.WriteLine(students[s]);
//     }
// }

// int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// var result = numbers.OrderByDescending(x=>x).ToArray();


// for (int data = 0; data < result.Length; data++)
// {
//     Console.WriteLine(result[data]);
// }



// char[] word = {'a','b', 'c', 'd','e', 'a'};
// int[] matchWord = {};
// int count = 1;

// int wordCount= 1;
// char[] myArr = word.OrderBy(x=>x).ToArray();

// for (int n = 0; n < myArr.Length; n++)
// {
//     count = 1;
//     for (int m = 0; m < myArr.Length; m++)
//     {
//         if (myArr[m] == myArr[n])
//         {
//             count++;
//         }
//     }
//     System.Console.WriteLine(count);
// }





// for (int num = 1; num <= word.Length; num++)
// {
//     count *= num;
// }

// Console.WriteLine(count/1);