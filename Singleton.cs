class Singleton{
    private static Singleton instance;
    private static readonly object padlock = new object();
    private Singleton(){
Console.WriteLine("Singleton instance created");
    }
    public static Singleton createinstance(){
       //double-checked locking to increase performance
       if(instance == null){
         //sigle lock is used to avoid multiple threads to create multiple instances
        lock(padlock)//"syncronization" decreases performance
        {
            if(instance==null){
            instance = new Singleton();  
        }
        else{
            Console.WriteLine("more than one instance are not allowed!!");
        }
       }

        }
        return instance;
    }
}