namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker p;
            Console.WriteLine("Введите ключ доступа");
            string? s = Console.ReadLine();
           
            switch (s)
            {
                case "456123":
                    p = new ProDocumentWorker();
                    break;
                case "987654":
                    p = new ExpertDocumentWorker();
                    break;
                default:
                    p = new DocumentWorker();
                    break;
            }

            
            p.OpenDocument();
            p.EditDocument();
            p.SaveDocument();

        }
    }
}

class DocumentWorker
{
    public virtual void OpenDocument()
    {
        Console.WriteLine("Документ открыт");
    }
    public virtual void EditDocument()
    {
        Console.WriteLine("Редактирование документа доступно в версии Pro");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Сохранение документа доступно в версии Pro");
    }
}

class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Документ отредактирован");
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
    }
}

class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в новом формате");
    }
}
