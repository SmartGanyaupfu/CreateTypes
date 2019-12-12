using System;
using System.Linq;

namespace CreateTypes
{
    class Program
    {
        
        static void Main(string[] args)
        {
            AlienStruct myAS;
            myAS.X = 50;
            myAS.Y = 50;
            myAS.Lives = 3;
            Console.WriteLine($"myAS has {myAS.ToString()}");
            AlienStruct x = new AlienStruct(40, 60);
            Console.WriteLine($"myAS has {x.ToString()}");
            AlienStruct[] swarm = new AlienStruct[100];
            Console.WriteLine($"myAS has {swarm[0].ToString()}");
            AlienState X = AlienState.dead;
            string cs = Enum.GetName(typeof(AlienState), 2);
            Console.WriteLine(X);
            Console.WriteLine(cs);
            Constructas ca = new Constructas(3);
            Console.WriteLine(ca.ToString());
            IndexersProp ip = new IndexersProp();
            ip[0] = 99;
            Console.WriteLine(ip[0]);
            var items = Enumerable.Range(0, 10);
            foreach(var i in items)
            {
                Console.WriteLine(i);
            }

            var stringEnumarator = "Hello Smart".GetEnumerator();
            while (stringEnumarator.MoveNext())
            {
                Console.WriteLine(stringEnumarator.Current);
            }

        }
    }
}
