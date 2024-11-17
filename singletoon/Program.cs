
public class singleton
{
   
    private static singleton instance;

   
    private static readonly object lockObject = new object();

  
    private singleton()
    {
        
    }

    
    public static singleton GetInstance()
    {
        if (instance == null)
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new singleton();
                }
            }
        }
        return instance;
    }

   
    public void ShowMessage()
    {
        Console.WriteLine("instance");
    }
}


public class Program
{
    public static void Main(string[] args)
    {
       
        singleton singleton1 = singleton.GetInstance();
        singleton1.ShowMessage();

      
        singleton singleton2 = singleton.GetInstance();
        if (singleton1 == singleton2)
        {
            Console.WriteLine("Obě instance jsou stejné ");
        }
        else
        {
            Console.WriteLine("Instance jsou jiné");
        }
    }
}
