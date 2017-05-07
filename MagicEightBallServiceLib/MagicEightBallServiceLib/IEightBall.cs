using System.ServiceModel;

namespace MagicEightBallServiceLib
{
    [ServiceContract(Namespace = "http://MyCompany.com")]
    public interface IEightBall
    {
        // Faça uma pergunta, receba uma resposta!
        [OperationContract]
        string ObtainAnswerToQuestion(string userQuestion);
    }
}
