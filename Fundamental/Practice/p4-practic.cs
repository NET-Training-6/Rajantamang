// Create a "Room"  class with at least 4 fiels and Two methods

class Room
{  
    int roomNubmer;
    double roomLength;

    double roomOfWidth;
    string roomColor;
    int numberOfWall;
    public Room()
    {
        
    }
    public Room(double l, double w, string rc, byte rn)
    {
        roomLength =l;
        roomOfWidth=w;
        roomColor=rc;
        roomNubmer=rn;
    }

    public double AreaOfRoom()
    {
        var area= roomLength * roomOfWidth;
        return area;

    }

    public int TotalWall(int Left, int Right, int straight)
    {
        var sum= Left + Right + straight;
        return sum;
    }



}