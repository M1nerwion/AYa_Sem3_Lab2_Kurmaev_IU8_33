namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите количество учеников в классе: ");
            //int count = Console.Read();

            Pupil o1 = new Pupil();
            Pupil o2 = new ExcelentPupil();
            Pupil o3 = new GoodPupil();
            Pupil o4 = new BadPupil();

            ClassRoom ElevenA = new ClassRoom(o1, o2, o3, o4);//Возможные варианты вызова
            //ClassRoom ElevenA = new ClassRoom(o1, o3, o4);
            //ClassRoom ElevenA = new ClassRoom(o1, o4);
            //ClassRoom ElevenA = new ClassRoom(o1);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Ученик #{i+1}:\n");
                ElevenA.students[i].Study();
                ElevenA.students[i].Read();
                ElevenA.students[i].Write();
                ElevenA.students[i].Relax();
                Console.WriteLine("\n");
            }
        }
    }
}

class ClassRoom
{
    public Pupil[] students;
    public ClassRoom(params Pupil[] pupils)
    {
        students = new Pupil[4];
        for (int i = 0; i < pupils.GetLength(0); i++)
        {
            students[i] = pupils[i];
        } 
        switch (pupils.GetLength(0))
        {
            case 1:
                students[1] = new ExcelentPupil();
                students[2] = new BadPupil();
                students[3] = new Pupil();
                break;
            case 2:
                students[2] = new BadPupil();
                students[3] = new Pupil();
                break;
            case 3:
                students[3] = new Pupil();
                break;
        }
    }
}


class Pupil
{
    public virtual void Study() 
    {
        Console.WriteLine("Studing\n");
    }
    public virtual void Read() 
    {
        Console.WriteLine("Reading\n");
    }
    public virtual void Write() 
    {
        Console.WriteLine("Writing\n");
    }
    public virtual void Relax()
    {
        Console.WriteLine("Relaxing\n");
    }
}

class ExcelentPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Studing Excelent\n");
    }
    public override void Read()
    {
        Console.WriteLine("Reading Excelent\n");
    }
    public override void Write()
    {
        Console.WriteLine("Writing Excelent\n");
    }
    public override void Relax()
    {
        Console.WriteLine("Relaxing Excelent\n");
    }
}
class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Studing Good\n");
    }
    public override void Read()
    {
        Console.WriteLine("Reading Good\n");
    }
    public override void Write()
    {
        Console.WriteLine("Writing Good\n");
    }
    public override void Relax()
    {
        Console.WriteLine("Relaxing Good\n");
    }
}

class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Studing Bad\n");
    }
    public override void Read()
    {
        Console.WriteLine("Reading Bad\n");
    }
    public override void Write()
    {
        Console.WriteLine("Writing Bad\n");
    }
    public override void Relax()
    {
        Console.WriteLine("Relaxing Bad\n");
    }
}