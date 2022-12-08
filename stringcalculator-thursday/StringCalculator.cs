

namespace StringCalculator;

public class StringCalculator
{
    private readonly ILogger _logger;
    private readonly IWebService _webService;

    public StringCalculator(ILogger logger, IWebService webService)
    {
        _logger = logger;
        _webService = webService;
    }

    public int Add(string numbers)
    {
      var answer = numbers == "" ? 0 :
        numbers.Split(',', '\n').Select(int.Parse).Sum();

        try
        {
            _logger.Write(answer.ToString());
        }
        catch (LoggerException ex)
        {
            _webService.Notify(ex.Message);
            
        }
        return answer;
        
    }
}

public interface IWebService
{
    void Notify(string message);
}

public interface ILogger
{
    void Write(string message);
}