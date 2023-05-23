Transport transport = new Boat();
GetMoveInfo(transport);
GetMoveInfo2(transport);

transport = new Car();
GetMoveInfo(transport);
GetMoveInfo2(transport);

var human = new Person();
human._Transport = transport;
GetMoveInfo(human);
GetMoveInfo2(human);

static void GetMoveInfo(IMovable movable)
{
    Console.WriteLine(movable.Move());
}

static void GetMoveInfo2<T>(T movable) where T : Transport
{
    Console.WriteLine(movable.Move());
}