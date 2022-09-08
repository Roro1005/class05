using SampleCode05;

Console.WriteLine("クラスのサンプルプログラム");

//↓はint型のnumberという名前の変数
//int number = 10;
//↓はCar型のcarInstanceという名前の変数
Car carInstance = new Car(10f);
Car carInstance2 = new Car(15f);

/*
Console.WriteLine("before 1:" + carInstance.Position);
Console.WriteLine("before 2:" + carInstance2.Position);
carInstance.Run(10f);
carInstance2.Run(10f);
Console.WriteLine("after 1:" + carInstance.Position);
Console.WriteLine("after 2:" + carInstance2.Position);
*/


//ハンズオン03
/*
Console.WriteLine("before:" + carInstance.Position);
Functions.HandsOn03(carInstance);
Console.WriteLine("after:" + carInstance.Position);
*/

//ハンズオン04
Character player = new Character(100f, 10f, 5f);
Character enemy = new Character(50f, 8f, 2f);

Console.WriteLine("プレイヤー:" + player.HP + ", 敵:" + enemy.HP);

bool battleEnded = false;
while(!battleEnded)
{
    player.Attack(enemy);
    enemy.Attack(player);
    Console.WriteLine("プレイヤー:" + player.HP + ", 敵:" + enemy.HP);

    if(player.HP <=0 || enemy.HP <= 0) battleEnded = true;
}

Console.WriteLine("バトル終了");

