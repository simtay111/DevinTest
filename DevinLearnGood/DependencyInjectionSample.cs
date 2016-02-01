using System.Security.Cryptography.X509Certificates;

namespace DevinLearnGood
{
    public class Employee
    {
        private readonly ITranslator _translator;

        public Employee(ITranslator translator)
        {
            _translator = translator;
        }

        public string Speak(string sentanceToSay)
        {
            return _translator.Translate(sentanceToSay);
        }

        public string IntroduceSelf()
        {
            return string.Empty;
        }
    }

    public interface ITranslator
    {
        string Translate(string stringToTranslate);
    }


    public interface IBoltRemover
    {
        bool RemoveBolt(int sizeOfBolt);
    }

    public class EnglishTranslator : ITranslator
    {
        public string Translate(string stringToTranslate)
        {
            return "";
        }
    }

    public class FrenchTranslator : ITranslator
    {
        public string Translate(string stringToTranslate)
        {
            return stringToTranslate + "French";
        }
    }
    public class GermanTranslator : ITranslator
    {
        public string Translate(string stringToTranslate)
        {
            throw new System.NotImplementedException();
        }
    }
}