using UnityEngine;


namespace Assignment.StudentSolution.LCT01
{
    public class Car
    {
        public string Name;
        public float Speed;
        public string Color;

        public void move()
        {
            Debug.Log("Car is moving");
        }

        public void Turn()
        {
            Debug.Log("Car is Turning");
        }

        public void Honk()
        {
            Debug.Log("Car is Honking");
        }
    }

    public class LCT01SyntaxClass
    {
        public void Start()
        {
            Car car = new Car(); //สร้างวัตถุจริง
            Car car2 = new(); //ปัจจุบันทำได้

            car.Name = "HONDA";
            car.Speed = 80;
            car.Color = "Black";

            car.move();
            car.Turn();
            car.Honk();
        }
    }
}
