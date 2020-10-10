using System;
using System.Collections.Generic;


namespace uniy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            
            int x = 3;

            x = int.Parse(Console.ReadLine());
            x = x+1;
            x += 1;
            

            float strength = 15.5f;

            string [] monsters = {"a", "b"};
            int[] monsterLevel = new int[3];
            monsterLevel[0] = 2;
            monsterLevel[1] = 5;

            Console.WriteLine("맵에 존재하는 몬스터의 레벨");
            Console.WriteLine(monterLevel[0]);

            List<string> items = new List<strings>();
            items.Add("생명물약30");
            items.Add("마나물약30");

            items.RemoveAt(0);

            Console.WriteLine("가지고 있는 아이템");
            Console.WriteLine(items[0]);

            Console.WriteLine("dddd"+"aaaa"+monsterLevel[0]);

            int fullLevel = 99;
            int level = 20;

            //&& ||

            //string condition = isBadCondition ? "나쁨" : "좋음" true 면 앞에, false 면 뒤에 출력 

            for (int i = 0; i < monsters.Length; i++)
                Console.WriteLine("이 지역 몬스터" + monsters[i]);
            */
            
            Person a = new Person();
            a.age = 23;
            a.name = "Ho";
            a.weapon = "gun";

            a.print();




            //Console.WriteLine(x);

        }

        //pritvate static void 쓰면 아무것도 return안 해도 됨. 
        //private static int calc(int x, int) 하면 뭔가 반환해야 함 
    }
}
