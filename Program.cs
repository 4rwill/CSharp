class Program
{
    static void Main()
    {
        ILogger logger = new FileLogger("mylog.txt");
        Conta conta1 = new Conta("Will", 10,logger );
        Conta conta2 = new Conta("Chris", 300,logger );
        var calculeSoma = new Calcule(Sum);
        var result = calculeSoma(1, 2);

        //lambda
        var soma = (int x, int y) => x + y;
        
        List<Conta> contaList = new List<Conta>
        {  
            conta1, 
            conta2 
        };

        Console.WriteLine($"Resultado: {result}");
        foreach (var conta in contaList)
        {
            Console.WriteLine($"Nome: {conta.GetNome()}\nSaldo: {conta.Saldo} \n");
        }

    }
    static int Sum(int x, int y)
    {
        return x + y;   
    }

}

delegate int Calcule (int x, int y);

class ConsoleLogger : ILogger{}

class FileLogger : ILogger
{
    private readonly string filePath;

    public FileLogger(string filePath)
    {
        this.filePath = filePath;
    }
    public void Log(string msg)
    {
        File.AppendAllText(filePath, $"{msg}\n");
    }
}


interface ILogger
{
    void Log(string msg)
    {
        Console.WriteLine($"LOGGER: {msg}");
    }
}

class Conta 
{
    private string nome;
    private readonly ILogger logger;
    public decimal Saldo {
        get; private set;        
    }



    public Conta(string nome, decimal saldo, ILogger logger)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {

            throw new ArgumentNullException($"Nome inválido: {nameof(nome)}");
        }

        if (saldo < 0)
        {
            throw new Exception("Saldo não pode ser negativo");
        }

        this.nome = nome;
        Saldo = saldo;
        this.logger = logger;
    }

    public void deposito(decimal valor)
    {
        if (valor <= 0)
        {
            logger.Log($"Não é possível depositar {valor} na conta de {nome}");
            return;
        }

        Saldo += valor;
    }

  
    public string GetNome()
    {
        return nome;
    }

 



}

