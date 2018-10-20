using System;

namespace Key_Values
{
    class Program
    {
        static void Main()
        {
            MyDictionary = new MyDictionary();
                var d = new MyDictionary();
                try
                {
                    Console.WriteLine(d["Cats"]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                d["Cats"] = 42;
                d["Dogs"] = 17;
                Console.WriteLine($"{(int)d["Cats"]}, {(int)d["Dogs"]}");
            
        
        }
    }

    public class MyDictionary : KeyValue
    {
        int values_stored;
        double[] numb = { 42, 17 };

        string Key { get; set; }
        object Value { get; set; }

        
    }
    public  struct KeyValue
    {
        readonly
        string key;
        
        readonly
        object value;
    
    }
}
