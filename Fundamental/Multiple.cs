class test1{

    public static void Main1()
    {
        Console.WriteLine("Enter The Number");
        var number= int.Parse(Console.ReadLine());
        if(number% 3 ==0 && number%5==0)
        {
            Console.WriteLine(number +"is multiple of 3 and 5");
        }
        else{
            if(number%3 ==0){
                Console.WriteLine(number +"is only multiple of 3");
            }
            if(number% 5==0){
                Console.WriteLine(number +"is only multiple of 5");
            }
            else{
                Console.WriteLine(number + "is not multiple of 3 or 5");
            }
        }
    }
}