namespace csharp_day_1.Models
{

// access modifiers, 'class', name (UpperCamelCase)
//  Accee Modifier
// public: anyone with access to the namespace can get this class
//  [default]: internall: any class 'within' the same namespace can access but not anything outside
// protected: only classes that inherit this class can access its members
//  private: does not allow access to anything outside of this file/scope (not usually for classes)
public class Cat
{
  // Field vs Prop
  // Field (represents the actual data on the object) : fields can be accessed and modiied without restriction
  // // string name;
  // private string _name;
  // // Prop
  // // Prop controlls access with get : set (props are UpperCamelCase)
  // public string Name {
  //   get
  //   {
  //     return _name.ToUpper();
  //   }
  //   set
  //   {
  //     _name = value.ToLower();
  //   }
  //   }
  // SECTION AutoProp
  // Good for the ability to set private fields within the class
  public string Name { get; set; }
  public int Age { get; private set; }

  // Access Modifiers, Return Ype (void means nothing, no return), Name
  public void Birthday()
  {
    Age++;
  }

  public string Feed(string food){
    if (food == "fish"){
      return "Meow";
    }
    return "Mewleahrhgharhagh";
  }

  // A constructor has no return type, and the MEthod name is the same as the class
  // Parameters: Tpe then Name
  public Cat(string n, int age)
  {
    // The this keyword is implied
    Name = n;
    Age = age;
  }
}
}