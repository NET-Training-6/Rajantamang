class ArrayLerner
{
    public void LearnArrays()
    {
        //one dimensional arays
        byte[] ages = { 18, 89, 56, 34, 55 };
        var x = ages[4];// x have 55 of ages (index of ages)
        //ages[5]= 33;
        var l = ages.Length;
        Console.WriteLine(l);


        int [] numbers = new int[100];//fix size arrays with any types of datatye

        //Multi dimensional arrays
        double[,] matrix = new double[2,2];
        //or
        //var matrix = new double[2,2];

        matrix[0,0]= 45;
        matrix[0,1]= 25;
        matrix[1,0]= 50;
        matrix[1,1]= 22;

        //jagged array
        var jArray = new decimal[20][];
        jArray [0]= new decimal[]{2,5,45,25,9};
        jArray [1]= new decimal[]{45,22,65};
        




    }
}