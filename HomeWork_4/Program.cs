Transport transport = new Boat();
GetMoveInfo(transport);

transport = new Car();
GetMoveInfo(transport);

var human = new Person(transport);
GetMoveInfo(human);


static void GetMoveInfo<T>(T movable) where T : IMovable
{
    Console.WriteLine(movable.Move());
}