Transport transport = new Boat();
GetMoveInfo(transport);

transport = new Car();
GetMoveInfo(transport);

var human = new Person(transport);
GetMoveInfo(human);


static void GetMoveInfo(IMovable movable)
{
    Console.WriteLine(movable.Move());
}