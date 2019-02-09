//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace CodewarsAlgorithms
//{
//    public class HighestAndLowest
//    {
//        public string HighAndLow(string numbers)
//        {
//            // Code here or
           

//            string[] stringNums = numbers.Split(' ');
//            var intNums = new List<int>();
//            var biggestNum = 0;
//            var smallestNum = biggestNum;
 
//            foreach (string stringNum in stringNums)
//            {
//               int intNum =  Int32.Parse(stringNum);
//               intNums.Add(intNum);
                
//            }
//            foreach (var num in intNums)
//                {
//                    //return (num > biggestNum ? biggestNum = num : biggestNum).ToString();
//                    //return (num < smallestNum ? smallestNum = num : smallestNum).ToString();

//                    if (num > biggestNum)
//                    {
//                        biggestNum = num;
//                        return biggestNum.ToString();
//                    }
//                    else if (num < smallestNum)
//                    {
//                        smallestNum = num;
//                        return smallestNum.ToString();
//                    }
//                }

//            //return biggestNum;
//            //return smallestNum;


//            // return "throw towel";

//        }
//    }
//}
