//Single inheritance
class A{

    int x;
}

class B:A // A is base/parent/super class and B is derived/child/sub class
{

    int y;
}

class C:B  //Multi-Level Inheritance
{

    int z;

    public void Test(){}
}

interface ID
{

}
//Multiple
class E: B, ID // Class  E inherits B and implements ID
{

}