using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator;

public class StringCalculatPartTwo
{

    

	[Theory]
	[InlineData("1,2", "3")]
	[InlineData("1,2,3,4,5,6,7,8,9", "45")]
	[InlineData("", "0")]
	
	public void ResultsAreLogged(string numbers, string message)
	{
		var mockedLogger = new Mock<ILogger>();
		var calculator = new StringCalculator(mockedLogger.Object, new Mock<IWebService>().Object);
		
		calculator.Add(numbers);

		// Was the logger's write method called with "3"?
		// Hey Logger? How was it in there? Can you verify that your Write method was called with "3"?
		mockedLogger.Verify(m => m.Write(message), Times.Once());
	}

    [Theory]
    [InlineData("1,2", "blammo")]
	[InlineData("99", "TACOS!")]
    public void LoggerThrows(string numbers, string message)
    {
		// Given (Establish Context)
        var stubbedLogger = new Mock<ILogger>();
		var mockedWebService = new Mock<IWebService>();
        var calculator = new StringCalculator(stubbedLogger.Object, mockedWebService.Object);
		stubbedLogger.Setup(m => m.Write(It.IsAny<string>())).Throws(new LoggerException(message));

		// When
        calculator.Add(numbers);


		// Then
		// Was the logger's write method called with "3"?
		// Hey Logger? How was it in there? Can you verify that your Write method was called with "3"?
		mockedWebService.Verify(m => m.Notify(message), Times.Once());
    }

}
